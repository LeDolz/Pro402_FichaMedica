namespace FichaMedica
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.labelIngreseRut = new System.Windows.Forms.Label();
            this.textBoxIngreseRut = new System.Windows.Forms.TextBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxNombre1 = new System.Windows.Forms.TextBox();
            this.textBoxNombre2 = new System.Windows.Forms.TextBox();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.richTextBoxDireccion = new System.Windows.Forms.RichTextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.labelIngreseDatos = new System.Windows.Forms.Label();
            this.textBoxFechaNac = new System.Windows.Forms.TextBox();
            this.labelEstadoCivil = new System.Windows.Forms.Label();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.labelComentarios = new System.Windows.Forms.Label();
            this.richTextBoxComentarios = new System.Windows.Forms.RichTextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonAbrirListaDatos = new System.Windows.Forms.Button();
            this.separador3 = new FichaMedica.Separador();
            this.separador2 = new FichaMedica.Separador();
            this.separador1 = new FichaMedica.Separador();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ficha médica";
            // 
            // labelIngreseRut
            // 
            this.labelIngreseRut.AutoSize = true;
            this.labelIngreseRut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreseRut.Location = new System.Drawing.Point(12, 142);
            this.labelIngreseRut.Name = "labelIngreseRut";
            this.labelIngreseRut.Size = new System.Drawing.Size(192, 36);
            this.labelIngreseRut.TabIndex = 1;
            this.labelIngreseRut.Text = "RUT: *\r\nFormato: XXXXXXXX-X";
            this.labelIngreseRut.Click += new System.EventHandler(this.labelIngreseRut_Click);
            // 
            // textBoxIngreseRut
            // 
            this.textBoxIngreseRut.Location = new System.Drawing.Point(229, 140);
            this.textBoxIngreseRut.Name = "textBoxIngreseRut";
            this.textBoxIngreseRut.Size = new System.Drawing.Size(130, 20);
            this.textBoxIngreseRut.TabIndex = 2;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombres.Location = new System.Drawing.Point(12, 189);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(103, 18);
            this.labelNombres.TabIndex = 3;
            this.labelNombres.Text = "Nombres: *";
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiudad.Location = new System.Drawing.Point(12, 368);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(87, 18);
            this.labelCiudad.TabIndex = 4;
            this.labelCiudad.Text = "Ciudad: *";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.Location = new System.Drawing.Point(12, 239);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(106, 18);
            this.labelApellidos.TabIndex = 5;
            this.labelApellidos.Text = "Apellidos: *";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(12, 304);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(105, 18);
            this.labelDireccion.TabIndex = 6;
            this.labelDireccion.Text = "Dirección: *";
            // 
            // textBoxNombre1
            // 
            this.textBoxNombre1.Location = new System.Drawing.Point(229, 191);
            this.textBoxNombre1.Name = "textBoxNombre1";
            this.textBoxNombre1.Size = new System.Drawing.Size(130, 20);
            this.textBoxNombre1.TabIndex = 7;
            // 
            // textBoxNombre2
            // 
            this.textBoxNombre2.Location = new System.Drawing.Point(378, 190);
            this.textBoxNombre2.Name = "textBoxNombre2";
            this.textBoxNombre2.Size = new System.Drawing.Size(130, 20);
            this.textBoxNombre2.TabIndex = 8;
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Location = new System.Drawing.Point(229, 237);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(130, 20);
            this.textBoxApellido1.TabIndex = 9;
            this.textBoxApellido1.TextChanged += new System.EventHandler(this.textBoxApellido2_TextChanged);
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Location = new System.Drawing.Point(378, 237);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(130, 20);
            this.textBoxApellido2.TabIndex = 10;
            // 
            // richTextBoxDireccion
            // 
            this.richTextBoxDireccion.Location = new System.Drawing.Point(229, 283);
            this.richTextBoxDireccion.Name = "richTextBoxDireccion";
            this.richTextBoxDireccion.Size = new System.Drawing.Size(279, 56);
            this.richTextBoxDireccion.TabIndex = 11;
            this.richTextBoxDireccion.Text = "";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(12, 415);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(100, 18);
            this.labelTelefono.TabIndex = 13;
            this.labelTelefono.Text = "Teléfono: *";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(229, 366);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(130, 20);
            this.textBoxCiudad.TabIndex = 12;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(229, 413);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(130, 20);
            this.textBoxTelefono.TabIndex = 14;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(12, 458);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(179, 18);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Correo electrónico: *";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(229, 456);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(279, 20);
            this.textBoxEmail.TabIndex = 16;
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaNac.Location = new System.Drawing.Point(12, 504);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(200, 54);
            this.labelFechaNac.TabIndex = 17;
            this.labelFechaNac.Text = "Fecha de nacimiento: *\r\nFormato: yyyy-mm-dd\r\n\r\n";
            // 
            // labelIngreseDatos
            // 
            this.labelIngreseDatos.AutoSize = true;
            this.labelIngreseDatos.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreseDatos.Location = new System.Drawing.Point(10, 80);
            this.labelIngreseDatos.Name = "labelIngreseDatos";
            this.labelIngreseDatos.Size = new System.Drawing.Size(397, 29);
            this.labelIngreseDatos.TabIndex = 18;
            this.labelIngreseDatos.Text = "Complete los siguientes campos";
            this.labelIngreseDatos.Click += new System.EventHandler(this.labelIngreseDatos_Click);
            // 
            // textBoxFechaNac
            // 
            this.textBoxFechaNac.Location = new System.Drawing.Point(229, 505);
            this.textBoxFechaNac.Name = "textBoxFechaNac";
            this.textBoxFechaNac.Size = new System.Drawing.Size(130, 20);
            this.textBoxFechaNac.TabIndex = 19;
            // 
            // labelEstadoCivil
            // 
            this.labelEstadoCivil.AutoSize = true;
            this.labelEstadoCivil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoCivil.Location = new System.Drawing.Point(12, 564);
            this.labelEstadoCivil.Name = "labelEstadoCivil";
            this.labelEstadoCivil.Size = new System.Drawing.Size(125, 18);
            this.labelEstadoCivil.TabIndex = 20;
            this.labelEstadoCivil.Text = "Estado civil: *";
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Es complicado"});
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(229, 564);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(130, 21);
            this.comboBoxEstadoCivil.TabIndex = 21;
            // 
            // labelComentarios
            // 
            this.labelComentarios.AutoSize = true;
            this.labelComentarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentarios.Location = new System.Drawing.Point(12, 670);
            this.labelComentarios.Name = "labelComentarios";
            this.labelComentarios.Size = new System.Drawing.Size(118, 18);
            this.labelComentarios.TabIndex = 22;
            this.labelComentarios.Text = "Comentarios:";
            // 
            // richTextBoxComentarios
            // 
            this.richTextBoxComentarios.Location = new System.Drawing.Point(229, 612);
            this.richTextBoxComentarios.Name = "richTextBoxComentarios";
            this.richTextBoxComentarios.Size = new System.Drawing.Size(279, 120);
            this.richTextBoxComentarios.TabIndex = 23;
            this.richTextBoxComentarios.Text = "";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(557, 131);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(115, 37);
            this.buttonGuardar.TabIndex = 24;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCerrar.Location = new System.Drawing.Point(557, 695);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(115, 37);
            this.buttonCerrar.TabIndex = 25;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(557, 200);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(115, 37);
            this.buttonLimpiar.TabIndex = 26;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonAbrirListaDatos
            // 
            this.buttonAbrirListaDatos.Location = new System.Drawing.Point(557, 283);
            this.buttonAbrirListaDatos.Name = "buttonAbrirListaDatos";
            this.buttonAbrirListaDatos.Size = new System.Drawing.Size(115, 37);
            this.buttonAbrirListaDatos.TabIndex = 30;
            this.buttonAbrirListaDatos.Text = "Ir al listado de datos";
            this.buttonAbrirListaDatos.UseVisualStyleBackColor = true;
            this.buttonAbrirListaDatos.Click += new System.EventHandler(this.buttonAbrirListaDatos_Click);
            // 
            // separador3
            // 
            this.separador3.esVertical = false;
            this.separador3.leGrosor = 1;
            this.separador3.Location = new System.Drawing.Point(527, 679);
            this.separador3.Name = "separador3";
            this.separador3.Size = new System.Drawing.Size(169, 10);
            this.separador3.TabIndex = 29;
            this.separador3.Text = "separador3";
            // 
            // separador2
            // 
            this.separador2.esVertical = false;
            this.separador2.leGrosor = 1;
            this.separador2.Location = new System.Drawing.Point(527, 256);
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(169, 10);
            this.separador2.TabIndex = 28;
            this.separador2.Text = "separador2";
            // 
            // separador1
            // 
            this.separador1.esVertical = true;
            this.separador1.leGrosor = 1;
            this.separador1.Location = new System.Drawing.Point(514, 80);
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(24, 652);
            this.separador1.TabIndex = 27;
            this.separador1.Text = "separador1";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 748);
            this.Controls.Add(this.buttonAbrirListaDatos);
            this.Controls.Add(this.separador3);
            this.Controls.Add(this.separador2);
            this.Controls.Add(this.separador1);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.richTextBoxComentarios);
            this.Controls.Add(this.labelComentarios);
            this.Controls.Add(this.comboBoxEstadoCivil);
            this.Controls.Add(this.labelEstadoCivil);
            this.Controls.Add(this.textBoxFechaNac);
            this.Controls.Add(this.labelIngreseDatos);
            this.Controls.Add(this.labelFechaNac);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.richTextBoxDireccion);
            this.Controls.Add(this.textBoxApellido2);
            this.Controls.Add(this.textBoxApellido1);
            this.Controls.Add(this.textBoxNombre2);
            this.Controls.Add(this.textBoxNombre1);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.labelNombres);
            this.Controls.Add(this.textBoxIngreseRut);
            this.Controls.Add(this.labelIngreseRut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "Formulario ficha médica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIngreseRut;
        private System.Windows.Forms.TextBox textBoxIngreseRut;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxNombre1;
        private System.Windows.Forms.TextBox textBoxNombre2;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.RichTextBox richTextBoxDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelFechaNac;
        private System.Windows.Forms.Label labelIngreseDatos;
        private System.Windows.Forms.TextBox textBoxFechaNac;
        private System.Windows.Forms.Label labelEstadoCivil;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivil;
        private System.Windows.Forms.Label labelComentarios;
        private System.Windows.Forms.RichTextBox richTextBoxComentarios;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonLimpiar;
        private Separador separador1;
        private Separador separador2;
        private Separador separador3;
        private System.Windows.Forms.Button buttonAbrirListaDatos;
    }
}

