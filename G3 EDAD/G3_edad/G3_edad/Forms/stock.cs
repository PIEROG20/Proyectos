using System;
using System.Collections.Generic;
using System.Windows.Forms;
using G3_edad.Entidades;
using G3_edad.Datos;

namespace G3_edad.Forms
{
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dgvstock.Rows.Clear();
            MostrarProductosEnStock();
            btnsumar.Click += btnsumar_Click;
            btnlimpiarstock.Click += btnlimpiarstock_Click;
        }

        private void MostrarProductosEnStock()
        {
            dgvstock.Rows.Clear();
            var productos = G3_Archivos.G3_LeerProductos();
            foreach (var p in productos)
            {
                dgvstock.Rows.Add(p.G3_Id, p.G3_Nombre, p.G3_Categoria, p.G3_Precio);
            }
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            decimal suma = 0;
            foreach (DataGridViewRow row in dgvstock.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    decimal precio;
                    if (decimal.TryParse(row.Cells[3].Value.ToString(), out precio))
                        suma += precio;
                }
            }
            txtsumatotal.Text = suma.ToString("C");
            // Mostrar el total gastado real del cliente (sumatoria de compras) si el formulario de clientes está abierto
            foreach (System.Windows.Forms.Form frm in System.Windows.Forms.Application.OpenForms)
            {
                if (frm is cliente cliForm)
                {
                    // Obtener el DNI del cliente seleccionado en el formulario de clientes
                    var dgv = cliForm.Controls["dgvclientes"] as System.Windows.Forms.DataGridView;
                    string dni = null;
                    if (dgv != null && dgv.CurrentRow != null && dgv.CurrentRow.Cells.Count > 2)
                        dni = dgv.CurrentRow.Cells[2].Value?.ToString();
                    if (!string.IsNullOrEmpty(dni))
                    {
                        decimal totalGastado = 0;
                        var compras = G3_Archivos.G3_LeerCompras();
                        foreach (var datos in compras)
                        {
                            if (datos.Length >= 5 && datos[0] == dni)
                            {
                                decimal precio;
                                if (decimal.TryParse(datos[3], out precio))
                                    totalGastado += precio;
                            }
                        }
                        var totalGastadoField = cliForm.Controls["txttotalgastado"] as System.Windows.Forms.TextBox;
                        if (totalGastadoField != null)
                            totalGastadoField.Text = totalGastado.ToString("C");
                    }
                }
            }
        }

        private void btnlimpiarstock_Click(object sender, EventArgs e)
        {
            dgvstock.Rows.Clear();
            txtsumatotal.Text = string.Empty;
            // Eliminar todo el stock del archivo
            G3_Archivos.G3_GuardarProductos(new List<G3_Producto>());
            MessageBox.Show("¡Stock eliminado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
