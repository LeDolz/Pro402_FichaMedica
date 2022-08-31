using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FichaMedica
{
    public partial class VentanaPrincipal : Form
    {
        
        //SqlConnection conn = Datos.ConectarBaseDatos(@"PCDIEGO\DOLZ", "PRO402_Sumativa1");
        public VentanaPrincipal()
        {
            InitializeComponent();
            
        }


        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
        }
        private void VentanaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void labelIngreseDatos_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        private void buttonAbrirListaDatos_Click(object sender, EventArgs e)
        {

            PagListaDatos nuevaVentana = new PagListaDatos(this);
            nuevaVentana.Visible = true;
            nuevaVentana.Focus();
            this.Visible = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (Procesos.ExisteElRegistro(this.textBoxIngreseRut.Text) )
            {
                Procesos.SobreescribirRegistro(
                    this.textBoxNombre1.Text, this.textBoxNombre2.Text, this.textBoxApellido2.Text, this.textBoxApellido1.Text,
                    this.richTextBoxDireccion.Text, this.textBoxCiudad.Text, this.textBoxTelefono.Text, this.textBoxEmail.Text, this.textBoxFechaNac.Text, this.comboBoxEstadoCivil.Text,
                    this.richTextBoxComentarios.Text, this.textBoxIngreseRut.Text
                    );
            }
            else
            {
            Procesos.IngresarPaciente(this.textBoxIngreseRut.Text, this.textBoxNombre1.Text, this.textBoxNombre2.Text, this.textBoxApellido2.Text, this.textBoxApellido1.Text, 
            this.richTextBoxDireccion.Text, this.textBoxCiudad.Text, this.textBoxTelefono.Text, this.textBoxEmail.Text, this.textBoxFechaNac.Text, this.comboBoxEstadoCivil.Text,
            this.richTextBoxComentarios.Text);
            }

        }
        private void LimpiarCampos()
        {
            Procesos.LimpiarTextBox(textBoxIngreseRut);
            Procesos.LimpiarTextBox(textBoxNombre1);
            Procesos.LimpiarTextBox(textBoxNombre2);
            Procesos.LimpiarTextBox(textBoxApellido2);
            Procesos.LimpiarTextBox(textBoxApellido1);
            Procesos.LimpiarTextBox(textBoxCiudad);
            Procesos.LimpiarTextBox(textBoxTelefono);
            Procesos.LimpiarTextBox(textBoxEmail);
            Procesos.LimpiarTextBox(textBoxFechaNac);
            Procesos.LimpiarRichTextBox(richTextBoxDireccion);
            Procesos.LimpiarRichTextBox(richTextBoxComentarios);
            this.comboBoxEstadoCivil.SelectedItem = null;
        }

        private void textBoxApellido2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIngreseRut_Click(object sender, EventArgs e)
        {

        }
    }
}
