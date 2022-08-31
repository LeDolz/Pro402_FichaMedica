namespace FichaMedica
{
    partial class PagListaDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagListaDatos));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.labelTituloListaDatos = new System.Windows.Forms.Label();
            this.textBoxIngresarApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarApellido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 179);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(656, 286);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // labelTituloListaDatos
            // 
            this.labelTituloListaDatos.AutoSize = true;
            this.labelTituloListaDatos.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloListaDatos.Location = new System.Drawing.Point(177, 9);
            this.labelTituloListaDatos.Name = "labelTituloListaDatos";
            this.labelTituloListaDatos.Size = new System.Drawing.Size(312, 32);
            this.labelTituloListaDatos.TabIndex = 2;
            this.labelTituloListaDatos.Text = "Busqueda de consulta";
            // 
            // textBoxIngresarApellido
            // 
            this.textBoxIngresarApellido.Location = new System.Drawing.Point(15, 120);
            this.textBoxIngresarApellido.Name = "textBoxIngresarApellido";
            this.textBoxIngresarApellido.Size = new System.Drawing.Size(206, 20);
            this.textBoxIngresarApellido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese un apellido para\r\nbuscar su ficha medica";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBuscarApellido
            // 
            this.buttonBuscarApellido.Location = new System.Drawing.Point(565, 108);
            this.buttonBuscarApellido.Name = "buttonBuscarApellido";
            this.buttonBuscarApellido.Size = new System.Drawing.Size(103, 42);
            this.buttonBuscarApellido.TabIndex = 5;
            this.buttonBuscarApellido.Text = "Buscar registro";
            this.buttonBuscarApellido.UseVisualStyleBackColor = true;
            this.buttonBuscarApellido.Click += new System.EventHandler(this.buttonBuscarApellido_Click);
            // 
            // PagListaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 477);
            this.Controls.Add(this.buttonBuscarApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIngresarApellido);
            this.Controls.Add(this.labelTituloListaDatos);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PagListaDatos";
            this.Text = "Lista de usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PagListaDatos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label labelTituloListaDatos;
        private System.Windows.Forms.TextBox textBoxIngresarApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarApellido;
    }
}