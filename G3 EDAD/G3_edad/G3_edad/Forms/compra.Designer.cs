namespace G3_edad.Forms
{
    partial class compra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, resources should be disposed.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.lbldni = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.dgvcompra = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnfinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompra)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(670, 151);
            this.txtDNI.Multiline = true;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(115, 33);
            this.txtDNI.TabIndex = 10;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(389, 151);
            this.txtcliente.Multiline = true;
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(214, 33);
            this.txtcliente.TabIndex = 9;
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(618, 163);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(26, 13);
            this.lbldni.TabIndex = 8;
            this.lbldni.Text = "DNI";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(339, 163);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(39, 13);
            this.lblcliente.TabIndex = 7;
            this.lblcliente.Text = "Cliente";
            // 
            // dgvcompra
            // 
            this.dgvcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Categoria,
            this.Precio});
            this.dgvcompra.Location = new System.Drawing.Point(342, 205);
            this.dgvcompra.Name = "dgvcompra";
            this.dgvcompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcompra.MultiSelect = true;
            this.dgvcompra.Size = new System.Drawing.Size(442, 208);
            this.dgvcompra.TabIndex = 15;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.Location = new System.Drawing.Point(670, 120);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(115, 25);
            this.btnbuscarcliente.TabIndex = 17;
            this.btnbuscarcliente.Text = "Buscar Cliente";
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(540, 420);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(115, 30);
            this.btnlimpiar.TabIndex = 19;
            this.btnlimpiar.Text = "Limpiar Tabla";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Location = new System.Drawing.Point(670, 420);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(115, 30);
            this.btnfinalizar.TabIndex = 16;
            this.btnfinalizar.Text = "Finalizar Compra";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 562);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.dgvcompra);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.lblcliente);
            this.Name = "compra";
            this.Text = "compra";
            this.Load += new System.EventHandler(this.compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.DataGridView dgvcompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnfinalizar;
    }
}