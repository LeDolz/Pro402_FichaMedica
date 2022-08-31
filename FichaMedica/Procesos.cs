using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaMedica
{
    internal class Procesos
    {
        public static void LimpiarTextBox(TextBox cuadro)
        {
            cuadro.Text = "";
        }
        public static void LimpiarRichTextBox(RichTextBox cuadro)
        {
            cuadro.Text = "";
        }
        public static void RellenarTabla(DataGridView dgv, string sql)
        {
            dgv.DataSource = Datos.ConseguirDatos(sql);
        }
        public static void BuscarPorApellidoPaterno(DataGridView dgv, string condicion)
        {
            dgv.DataSource= Datos.RealizarBusqueda(condicion);
        }
        public static void IngresarPaciente(string rut, string primerNom, string segundoNom, string apellidoP, string apellidoM, string direccion, string ciudad, string telefono,
        string email, string fechaNac, string estadoCivil, string comentarios)
        {
            Datos.AgregarRegistro(rut, primerNom, segundoNom, apellidoP, apellidoM, direccion, ciudad, telefono, email, fechaNac, estadoCivil, comentarios);
        }
        public static bool ExisteElRegistro(string rut)
        {
            return Datos.ExisteElRegistro(rut);
        }
        public static void SobreescribirRegistro(string primerNom, string segundoNom, string apellidoP, string apellidoM, string direccion, string ciudad, string telefono,
        string email, string fechaNac, string estadoCivil, string comentarios, string rutObjetivo)
        {
            Datos.SobreescribirRegistro(primerNom, segundoNom, apellidoP, apellidoM, direccion, ciudad, telefono, email, fechaNac, estadoCivil, comentarios, rutObjetivo);
        }
    }
}
