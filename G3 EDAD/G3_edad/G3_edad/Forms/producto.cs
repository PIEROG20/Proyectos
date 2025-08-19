using System;
using System.Collections.Generic;
using System.Windows.Forms;
using G3_edad.Entidades;
using G3_edad.Datos;

namespace G3_edad.Forms
{
    public partial class producto : Form
    {
        public producto()
        {
            InitializeComponent();
            dgvproducto.Rows.Clear();
            btnagregar.Click += Btnagregar_Click;
            comboxcategoria.Items.AddRange(new object[]
            {
                "Lácteos",
                "Carnes",
                "Bebidas",
                "Panadería",
                "Frutas",
                "Verduras",
                "Limpieza",
                "Snacks",
                "Congelados",
                "Despensa",
                "Cuidado Personal",
                "Mascotas"
            });
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dgvproducto.Rows.Clear();
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text.Trim();
            string nombre = txtnombre.Text.Trim();
            string categoria = comboxcategoria.Text.Trim();
            string precio = txtprecio.Text.Trim();
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(precio))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            var productos = G3_Archivos.G3_LeerProductos();
            int nuevoId = productos.Count > 0 ? productos[productos.Count - 1].G3_Id + 1 : 1;
            productos.Add(new G3_Producto
            {
                G3_Id = nuevoId,
                G3_Nombre = nombre,
                G3_Categoria = categoria,
                G3_Precio = decimal.Parse(precio),
                G3_Stock = 1 // Por defecto, puedes ajustar
            });
            G3_Archivos.G3_GuardarProductos(productos);
            dgvproducto.Rows.Add(codigo, nombre, categoria, precio);
            txtcodigo.Clear();
            txtnombre.Clear();
            comboxcategoria.SelectedIndex = -1;
            txtprecio.Clear();
        }
    }
}

