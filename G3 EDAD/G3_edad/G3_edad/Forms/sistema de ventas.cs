using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3_edad.Forms
{

    public partial class sistema_de_ventas : Form
    {

        private Panel PanelEscritorio; // Add this field to define the missing Panel.

        public sistema_de_ventas()
        {
            InitializeComponent();
            // Initialize the PanelEscritorio control.
            PanelEscritorio = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = SystemColors.Control
            };
            this.Controls.Add(PanelEscritorio); // Add the Panel to the form's controls.
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            // Limpiar el panel antes de agregar el nuevo formulario
            PanelEscritorio.Controls.Clear();

            // Crear instancia del formulario cliente
            cliente frmCliente = new cliente();
            frmCliente.TopLevel = false;
            frmCliente.FormBorderStyle = FormBorderStyle.None;
            frmCliente.Dock = DockStyle.Fill;

            // Agregar al panel y mostrar
            PanelEscritorio.Controls.Add(frmCliente);
            frmCliente.Show();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            // Limpiar el panel antes de agregar el nuevo formulario
            PanelEscritorio.Controls.Clear();

            // Crear instancia del formulario compra
            compra frmCompra = new compra();
            frmCompra.TopLevel = false;
            frmCompra.FormBorderStyle = FormBorderStyle.None;
            frmCompra.Dock = DockStyle.Fill;

            // Agregar al panel y mostrar
            PanelEscritorio.Controls.Add(frmCompra);
            frmCompra.Show();
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            // Limpiar el panel antes de agregar el nuevo formulario
            PanelEscritorio.Controls.Clear();

            // Crear instancia del formulario producto
            producto frmProducto = new producto();
            frmProducto.TopLevel = false;
            frmProducto.FormBorderStyle = FormBorderStyle.None;
            frmProducto.Dock = DockStyle.Fill;

            // Agregar al panel y mostrar
            PanelEscritorio.Controls.Add(frmProducto);
            frmProducto.Show();
        }

        private void stock_Click(object sender, EventArgs e)
        {
            // Limpiar el panel antes de agregar el nuevo formulario
            PanelEscritorio.Controls.Clear();

            // Crear instancia del formulario stock
            stock frmStock = new stock();
            frmStock.TopLevel = false;
            frmStock.FormBorderStyle = FormBorderStyle.None;
            frmStock.Dock = DockStyle.Fill;

            // Agregar al panel y mostrar
            PanelEscritorio.Controls.Add(frmStock);
            frmStock.Show();
        }
    }
}

