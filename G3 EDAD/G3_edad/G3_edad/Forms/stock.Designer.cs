namespace G3_edad.Forms
{
    partial class stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            this.dgvstock = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsumar = new System.Windows.Forms.Button();
            this.txtsumatotal = new System.Windows.Forms.TextBox();
            this.btnlimpiarstock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstock
            // 
            this.dgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Categoria,
            this.Precio});
            this.dgvstock.Location = new System.Drawing.Point(376, 128);
            this.dgvstock.Name = "dgvstock";
            this.dgvstock.Size = new System.Drawing.Size(443, 233);
            this.dgvstock.TabIndex = 16;
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
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(790, 370);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(80, 30);
            this.btnsumar.TabIndex = 17;
            this.btnsumar.Text = "Sumar";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // txtsumatotal
            // 
            this.txtsumatotal.Location = new System.Drawing.Point(670, 370);
            this.txtsumatotal.Name = "txtsumatotal";
            this.txtsumatotal.Size = new System.Drawing.Size(110, 22);
            this.txtsumatotal.TabIndex = 18;
            this.txtsumatotal.ReadOnly = true;
            // 
            // btnlimpiarstock
            // 
            this.btnlimpiarstock.Location = new System.Drawing.Point(560, 370);
            this.btnlimpiarstock.Name = "btnlimpiarstock";
            this.btnlimpiarstock.Size = new System.Drawing.Size(100, 30);
            this.btnlimpiarstock.TabIndex = 19;
            this.btnlimpiarstock.Text = "Limpiar Stock";
            this.btnlimpiarstock.UseVisualStyleBackColor = true;
            this.btnlimpiarstock.Click += new System.EventHandler(this.btnlimpiarstock_Click);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 430);
            this.Controls.Add(this.dgvstock);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txtsumatotal);
            this.Controls.Add(this.btnlimpiarstock);
            this.Name = "stock";
            this.Text = "stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.TextBox txtsumatotal;
        private System.Windows.Forms.Button btnlimpiarstock;
    }
}