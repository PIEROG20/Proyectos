using G3_edad.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace G3_edad
{
    public partial class Form1 : Form
    {
        public object Datos { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
                txtusuario.UseSystemPasswordChar = true;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            {
                if (txtusuario.Text == "")
                {
                    txtusuario.Text = "USUARIO";
                    txtusuario.ForeColor = Color.DimGray;
                    txtusuario.UseSystemPasswordChar = false;
                }
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.Black;
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.ForeColor = Color.DimGray;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contraseña = txtcontraseña.Text.Trim();
            this.Hide();
            sistema_de_ventas interfas = new sistema_de_ventas();
            interfas.ShowDialog();
            this.Close();
            {
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

    


       
    

    
    
    

