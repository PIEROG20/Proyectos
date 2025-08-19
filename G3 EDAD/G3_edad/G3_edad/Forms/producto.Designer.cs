namespace G3_edad.Forms
{
    partial class producto
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblctg = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            this.comboxcategoria = new System.Windows.Forms.ComboBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(455, 116);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(214, 33);
            this.txtnombre.TabIndex = 12;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(455, 73);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(214, 33);
            this.txtcodigo.TabIndex = 10;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(380, 125);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(44, 13);
            this.lblcategoria.TabIndex = 9;
            this.lblcategoria.Text = "Nombre";
            // 
            // lblctg
            // 
            this.lblctg.AutoSize = true;
            this.lblctg.Location = new System.Drawing.Point(377, 165);
            this.lblctg.Name = "lblctg";
            this.lblctg.Size = new System.Drawing.Size(52, 13);
            this.lblctg.TabIndex = 8;
            this.lblctg.Text = "Categoria";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(380, 85);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 7;
            this.lblcodigo.Text = "Codigo";
            // 
            // dgvproducto
            // 
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Categoria,
            this.Precio});
            this.dgvproducto.Location = new System.Drawing.Point(368, 228);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(442, 208);
            this.dgvproducto.TabIndex = 14;
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
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(698, 133);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(109, 47);
            this.btnagregar.TabIndex = 13;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // comboxcategoria
            // 
            this.comboxcategoria.FormattingEnabled = true;
            this.comboxcategoria.Location = new System.Drawing.Point(455, 160);
            this.comboxcategoria.Name = "comboxcategoria";
            this.comboxcategoria.Size = new System.Drawing.Size(214, 21);
            this.comboxcategoria.TabIndex = 15;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(455, 190);
            this.txtprecio.Multiline = true;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(214, 25);
            this.txtprecio.TabIndex = 16;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(381, 197);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 17;
            this.lblprecio.Text = "Precio";
            // 
            // producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 502);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.comboxcategoria);
            this.Controls.Add(this.dgvproducto);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblctg);
            this.Controls.Add(this.lblcodigo);
            this.Name = "producto";
            this.Text = "producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblctg;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.ComboBox comboxcategoria;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecio;
    }
}