using System;
using System.Collections.Generic;
using System.Windows.Forms;
using G3_edad.Entidades;
using G3_edad.Datos;

namespace G3_edad.Forms
{
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
            dgvclientes.Rows.Clear(); // Limpiar el DataGridView al iniciar
            btnagregar.Click += btnagregar_Click;
            btnlimpiar.Click += btnlimpiar_Click;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dgvclientes.Rows.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string apellido = txtapellido.Text.Trim();
            string dni = txtDNI.Text.Trim();
            string celular = txtcelular.Text.Trim();

            // Validaciones recursivas
            if (!G3_Validador.G3_EsSoloLetras(nombre))
            {
                MessageBox.Show("El nombre solo debe contener letras.");
                return;
            }
            if (!G3_Validador.G3_EsSoloLetras(apellido))
            {
                MessageBox.Show("El apellido solo debe contener letras.");
                return;
            }
            if (!G3_Validador.G3_EsSoloDigitos(dni) || !G3_Validador.G3_LongitudExacta(dni, 8))
            {
                MessageBox.Show("El DNI debe contener exactamente 8 dígitos.");
                return;
            }
            if (!G3_Validador.G3_EsSoloDigitos(celular) || !G3_Validador.G3_LongitudExacta(celular, 9))
            {
                MessageBox.Show("El celular debe contener exactamente 9 dígitos.");
                return;
            }

            // Obtener lista actual, agregar nuevo cliente y guardar
            var clientes = G3_Archivos.G3_LeerClientes();
            int nuevoId = clientes.Count > 0 ? clientes[clientes.Count - 1].G3_Id + 1 : 1;
            clientes.Add(new G3_Cliente
            {
                G3_Id = nuevoId,
                G3_Nombre = nombre,
                G3_Apellido = apellido,
                G3_DNI = dni,
                G3_Celular = celular
            });
            G3_Archivos.G3_GuardarClientes(clientes);
            CargarClientesEnGrid();
            MessageBox.Show("Cliente registrado correctamente.");
            txtnombre.Clear();
            txtapellido.Clear();
            txtDNI.Clear();
            txtcelular.Clear();
        }

        private void CargarClientesEnGrid()
        {
            dgvclientes.Rows.Clear();
            var clientes = G3_Archivos.G3_LeerClientes();
            foreach (var c in clientes)
            {
                dgvclientes.Rows.Add(c.G3_Nombre, c.G3_Apellido, c.G3_DNI, c.G3_Celular);
            }
            // Mostrar el total gastado por el último cliente seleccionado (puedes ajustar la lógica según tu necesidad)
            if (clientes.Count > 0)
            {
                var cliente = clientes[clientes.Count - 1];
                txttotalgastado.Text = CalcularTotalGastado(cliente.G3_DNI).ToString("C");
            }
            else
            {
                txttotalgastado.Text = "";
            }
        }

        private decimal CalcularTotalGastado(string dni)
        {
            decimal total = 0;
            var compras = G3_Archivos.G3_LeerCompras();
            foreach (var datos in compras)
            {
                if (datos.Length >= 5 && datos[0] == dni)
                {
                    decimal precio;
                    if (decimal.TryParse(datos[3], out precio))
                        total += precio;
                }
            }
            return total;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dgvclientes.Rows.Clear();
            txttotalgastado.Text = string.Empty;
            // Eliminar todos los clientes del archivo
            G3_edad.Datos.G3_Archivos.G3_GuardarClientes(new List<G3_edad.Entidades.G3_Cliente>());
            // Eliminar todos los productos del archivo
            G3_edad.Datos.G3_Archivos.G3_GuardarProductos(new List<G3_edad.Entidades.G3_Producto>());
            // Eliminar todas las compras del archivo
            using (var sw = new System.IO.StreamWriter("G3_compras.txt", false)) { }
            MessageBox.Show("¡Clientes, productos y compras eliminados correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
