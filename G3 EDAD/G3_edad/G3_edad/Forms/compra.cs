using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G3_edad.Entidades;
using G3_edad.Datos;

namespace G3_edad.Forms
{
    public partial class compra : Form
    {
        private List<G3_Producto> productosSeleccionados = new List<G3_Producto>();
        private G3_Cliente clienteEncontrado = null;

        public compra()
        {
            InitializeComponent();
            dgvcompra.Rows.Clear();
            CargarProductos();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dgvcompra.Rows.Clear();
            dgvcompra.CellDoubleClick += dgvcompra_CellDoubleClick;
            if (btnfinalizar != null) btnfinalizar.Click += btnfinalizar_Click;
            if (btnbuscarcliente != null) btnbuscarcliente.Click += btnbuscarcliente_Click;
            if (btnlimpiar != null) btnlimpiar.Click += btnlimpiar_Click;
        }

        private void CargarProductos()
        {
            dgvcompra.Rows.Clear();
            var productos = G3_Archivos.G3_LeerProductos();
            foreach (var p in productos)
            {
                if (p.G3_Stock > 0)
                    dgvcompra.Rows.Add(p.G3_Id, p.G3_Nombre, p.G3_Categoria, p.G3_Precio);
            }
        }

        private void AsignarProductosACliente(string dniCliente)
        {
            var clientes = G3_Archivos.G3_LeerClientes();
            var cliente = clientes.FirstOrDefault(c => c.G3_DNI == dniCliente);
            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado");
                return;
            }
            foreach (var prod in productosSeleccionados)
            {
                G3_Archivos.G3_GuardarCompra(cliente.G3_DNI, prod.G3_Id, prod.G3_Nombre, prod.G3_Precio, DateTime.Now);
            }
            MessageBox.Show("Productos asignados al cliente correctamente.");
        }

        private void dgvcompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvcompra.Rows[e.RowIndex].Cells[0].Value);
                var producto = G3_Archivos.G3_LeerProductos().FirstOrDefault(p => p.G3_Id == id);
                if (producto != null && producto.G3_Stock > 0)
                {
                    // Evitar duplicados
                    if (!productosSeleccionados.Any(p => p.G3_Id == producto.G3_Id))
                    {
                        productosSeleccionados.Add(producto);
                        MessageBox.Show($"Producto '{producto.G3_Nombre}' agregado a la compra.");
                    }
                    else
                    {
                        MessageBox.Show($"El producto '{producto.G3_Nombre}' ya fue agregado.");
                    }
                }
            }
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese el DNI del cliente.");
                return;
            }
            var clientes = G3_Archivos.G3_LeerClientes();
            clienteEncontrado = clientes.FirstOrDefault(c => c.G3_DNI == dni);
            if (clienteEncontrado != null)
            {
                txtcliente.Text = clienteEncontrado.G3_Nombre + " " + clienteEncontrado.G3_Apellido;
                MessageBox.Show("Cliente encontrado: " + txtcliente.Text);
                // Agregar todos los productos a la tabla de clientes (dgvclientes) si el formulario de clientes está abierto
                foreach (System.Windows.Forms.Form frm in System.Windows.Forms.Application.OpenForms)
                {
                    if (frm is cliente cliForm)
                    {
                        var dgv = cliForm.Controls["dgvclientes"] as System.Windows.Forms.DataGridView;
                        if (dgv != null)
                        {
                            var productos = G3_Archivos.G3_LeerProductos();
                            foreach (var p in productos)
                            {
                                dgv.Rows.Add(p.G3_Nombre, "-", "-", "-");
                            }
                        }
                    }
                }
            }
            else
            {
                txtcliente.Clear();
                MessageBox.Show("Cliente no encontrado.");
            }
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            // Validar que al menos una fila esté seleccionada en dgvcompra
            if (dgvcompra.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un producto de la tabla para finalizar la compra.");
                return;
            }
            if (clienteEncontrado == null)
            {
                MessageBox.Show("Debe buscar y seleccionar un cliente válido antes de finalizar la compra.");
                return;
            }
            // Limpiar la lista de productos seleccionados y agregar los seleccionados en la tabla
            productosSeleccionados.Clear();
            foreach (DataGridViewRow row in dgvcompra.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    var producto = G3_Archivos.G3_LeerProductos().Find(p => p.G3_Id == id);
                    if (producto != null)
                        productosSeleccionados.Add(producto);
                }
            }
            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un producto válido de la tabla.");
                return;
            }
            AsignarProductosACliente(clienteEncontrado.G3_DNI);
            decimal suma = 0;
            foreach (var prod in productosSeleccionados)
            {
                suma += prod.G3_Precio;
            }
            // Mostrar la suma en el txttotalgastado del formulario de clientes si está abierto
            foreach (System.Windows.Forms.Form frm in System.Windows.Forms.Application.OpenForms)
            {
                if (frm is cliente cliForm)
                {
                    var totalGastadoField = cliForm.Controls["txttotalgastado"] as System.Windows.Forms.TextBox;
                    if (totalGastadoField != null)
                        totalGastadoField.Text = suma.ToString("C");
                }
            }
            productosSeleccionados.Clear();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dgvcompra.Rows.Clear();
            productosSeleccionados.Clear();
            // Limpiar stock visual en el formulario de stock si está abierto
            foreach (System.Windows.Forms.Form frm in System.Windows.Forms.Application.OpenForms)
            {
                if (frm is stock stockForm)
                {
                    var dgv = stockForm.Controls["dgvstock"] as System.Windows.Forms.DataGridView;
                    if (dgv != null)
                        dgv.Rows.Clear();
                    var txtsuma = stockForm.Controls["txtsumatotal"] as System.Windows.Forms.TextBox;
                    if (txtsuma != null)
                        txtsuma.Text = string.Empty;
                }
            }
        }

        private void compra_Load(object sender, EventArgs e)
        {

        }
    }
}
