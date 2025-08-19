namespace G3_edad.Forms
{
    partial class cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.lbltotalgastado = new System.Windows.Forms.Label();
            this.txttotalgastado = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(377, 92);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(380, 150);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(26, 13);
            this.lbldni.TabIndex = 2;
            this.lbldni.Text = "DNI";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(376, 121);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(44, 13);
            this.lblapellido.TabIndex = 3;
            this.lblapellido.Text = "Apellido";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(447, 84);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(214, 25);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(446, 143);
            this.txtDNI.Multiline = true;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(214, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(447, 115);
            this.txtapellido.Multiline = true;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(214, 22);
            this.txtapellido.TabIndex = 6;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(681, 92);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(109, 47);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // dgvclientes
            // 
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellidos,
            this.DNI,
            this.Celular});
            this.dgvclientes.Location = new System.Drawing.Point(358, 206);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.Size = new System.Drawing.Size(442, 210);
            this.dgvclientes.TabIndex = 8;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(446, 169);
            this.txtcelular.Multiline = true;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(214, 22);
            this.txtcelular.TabIndex = 9;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Location = new System.Drawing.Point(375, 174);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(39, 13);
            this.lblcelular.TabIndex = 10;
            this.lblcelular.Text = "Celular";
            // 
            // lbltotalgastado
            // 
            this.lbltotalgastado.AutoSize = true;
            this.lbltotalgastado.Location = new System.Drawing.Point(585, 437);
            this.lbltotalgastado.Name = "lbltotalgastado";
            this.lbltotalgastado.Size = new System.Drawing.Size(97, 13);
            this.lbltotalgastado.TabIndex = 11;
            this.lbltotalgastado.Text = "TOTAL GASTADO";
            // 
            // txttotalgastado
            // 
            this.txttotalgastado.Location = new System.Drawing.Point(685, 431);
            this.txttotalgastado.Multiline = true;
            this.txttotalgastado.Name = "txttotalgastado";
            this.txttotalgastado.Size = new System.Drawing.Size(115, 25);
            this.txttotalgastado.TabIndex = 12;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(681, 145);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(109, 30);
            this.btnlimpiar.TabIndex = 13;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 561);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txttotalgastado);
            this.Controls.Add(this.lbltotalgastado);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.dgvclientes);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.lblnombre);
            this.Name = "cliente";
            this.Text = "cliente";
            this.Load += new System.EventHandler(this.cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvclientes;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.Label lbltotalgastado;
        private System.Windows.Forms.TextBox txttotalgastado;
        private System.Windows.Forms.Button btnlimpiar;
    }
}