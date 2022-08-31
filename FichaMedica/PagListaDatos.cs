using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaMedica
{
    public partial class PagListaDatos : Form
    {
        Form ventanaOld;
        public PagListaDatos(Form antiguaVentana)
        {
            InitializeComponent();
            ventanaOld = antiguaVentana;
            try
            {
                Procesos.RellenarTabla(dgvUsuarios, "select * from Paciente");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void PagListaDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventanaOld.Visible = true;
        }

        private void buttonBuscarApellido_Click(object sender, EventArgs e)
        {
            Procesos.BuscarPorApellidoPaterno(dgvUsuarios, this.textBoxIngresarApellido.Text);
        }
    }
}
