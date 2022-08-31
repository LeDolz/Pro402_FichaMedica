using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace FichaMedica
{
    internal class Datos
    {
        //Cambiar el primer parametro del constructor con el nombre del host correspondiente al pc actual
        public static SqlConnection conn = ConectarBaseDatos(@"dolz", "PRO402_Sumativa1");

        public static SqlConnection ConectarBaseDatos(string servidor, string baseDatos)
        {
            try
            {
                SqlConnection con = new SqlConnection($"server={servidor};database={baseDatos};integrated security = true");
                return con;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public static DataTable ConseguirDatos(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error\n{e.Message}");
                return new DataTable();
            }
        }

        public static DataTable RealizarBusqueda(string apellido)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"select * from Paciente where ApellimoPaterno like '{apellido}';", conn);
                //' or 'z'='z
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error\n{e.Message}");
                return new DataTable();
            }
        }
        public static void AgregarRegistro(string rut, string primerNom, string segundoNom, string apellidoP, string apellidoM, string direccion, string ciudad, string telefono,
        string email, string fechaNac, string estadoCivil, string comentarios)
        {
            try
            {
                if (String.IsNullOrEmpty(primerNom) || String.IsNullOrEmpty(segundoNom) || String.IsNullOrEmpty(apellidoP) || String.IsNullOrEmpty(apellidoM) || String.IsNullOrEmpty(direccion)
                    || String.IsNullOrEmpty(ciudad) || String.IsNullOrEmpty(telefono) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(fechaNac) || String.IsNullOrEmpty(estadoCivil) || String.IsNullOrEmpty(rut))
                {
                    MessageBox.Show("Alguno de los campos obligatorios\nno se encuentra relleno");
                }
                else
                {
                    byte resultadoEvaluar = ValidarRutAndCorreo(rut, email);
                    switch (resultadoEvaluar)
                    {
                        case 0:
                            {
                                conn.Open();
                                SqlCommand cmd = new SqlCommand(
                                    $"insert into Paciente(Rut, PrimerNombre, SegundoNombre, ApellimoPaterno, ApellidoMaterno, Direccion, Ciudad, Telefono, Email, FechaNacimiento," +
                                    $" EstadoCivil, Comentarios) values(" +
                                    $"'{rut}'," +
                                    $"'{primerNom}'," +
                                    $"'{segundoNom}'," +
                                    $"'{apellidoP}'," +
                                    $"'{apellidoM}'," +
                                    $"'{direccion}'," +
                                    $"'{ciudad}'," +
                                    $"'{telefono}'," +
                                    $"'{email}'," +
                                    $"'{fechaNac}'," +
                                    $"'{estadoCivil}'," +
                                    $"'{comentarios}')"
                                    , conn);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show($"Se ha agregado el usuario {primerNom} {apellidoP}");
                                conn.Close();
                                break;
                            }
                        case 1:
                            {
                                MessageBox.Show("El correo ingresado no es valido!");
                                break;
                            }
                        case 2:
                            {
                                MessageBox.Show("El rut ingresado no es válido!");
                                break;
                            }
                        case 3:
                            {
                                MessageBox.Show("El rut y el correo ingresados no son validos!");
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Resultado inesperado de la validacion de datos");
                                break;
                            }
                    }

                }

            }catch(Exception ex)
            {
                MessageBox.Show($"Error \n{ex.Message}");
            }

        }

        public static bool ExisteElRegistro(string rut)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"select * from Paciente where Rut like '{rut}'", conn);
                DataTable registros = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(registros);
                conn.Close();
                if (registros.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error \n{ex.Message}");
                return false;
            }
            
        }

        public static void SobreescribirRegistro(string primerNom, string segundoNom, string apellidoP, string apellidoM, string direccion, string ciudad, string telefono,
        string email, string fechaNac, string estadoCivil, string comentarios, string rutObjetivo)
        {
            try
            {
                if (String.IsNullOrEmpty(primerNom) || String.IsNullOrEmpty(segundoNom) || String.IsNullOrEmpty(apellidoP) || String.IsNullOrEmpty(apellidoM) || String.IsNullOrEmpty(direccion)
                    || String.IsNullOrEmpty(ciudad) || String.IsNullOrEmpty(telefono) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(fechaNac) || String.IsNullOrEmpty(estadoCivil) || String.IsNullOrEmpty(rutObjetivo))
                {
                    MessageBox.Show("Alguno de los datos obligatorios no se encuentra completo!");
                }
                else
                {
                    byte resultadoEvaluar = ValidarRutAndCorreo(rutObjetivo, email);
                    switch (resultadoEvaluar)
                    {
                        case 0:
                            {
                                DialogResult pregunta = MessageBox.Show($"Desea sobrescribir el registro\nasociado al rut {rutObjetivo}?", "Sobrescritura", MessageBoxButtons.YesNo);
                                if (pregunta == DialogResult.Yes)
                                {
                                    conn.Open();
                                    SqlCommand cmd = new SqlCommand(
                                        $"update Paciente set PrimerNombre = '{primerNom}', SegundoNombre='{segundoNom}', ApellimoPaterno = '{apellidoM}', ApellidoMaterno ='{apellidoP}'," +
                                        $" Direccion = '{direccion}', Ciudad = '{ciudad}', Telefono = '{telefono}', Email = '{email}', FechaNacimiento = '{fechaNac}', EstadoCivil = '{estadoCivil}'," +
                                        $" Comentarios = '{comentarios}' where Rut like '{rutObjetivo}';"
                                        , conn);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show($"Se ha sobreescribido el usuario {primerNom} {apellidoM}");
                                    conn.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha sobrescrito el registro");
                                }
                                break;
                            }
                        case 1:
                            {
                                MessageBox.Show("El correo ingresado no es valido!");
                                break;
                            }
                        case 2:
                            {
                                MessageBox.Show("El rut ingresado no es válido!");
                                break;
                            }
                        case 3:
                            {
                                MessageBox.Show("El rut y el correo ingresados no son validos!");
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Resultado inesperado de la validacion de datos");
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error\n{ex.Message}");
            }
        }

        private static bool RutValido(string rut)
        {
            Regex patron = new Regex("^([0-9]+-[0-9K])$");
            if (patron.IsMatch(rut)) return true;
            else  return false;
        }
        private static bool CorreoValido(string correo)
        {
            Regex patron = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (patron.IsMatch(correo)) return true;
            else return false;
        }
        private static byte ValidarRutAndCorreo(string rut, string correo)
        {
            bool rutEsValido = RutValido(rut);
            bool CorreoEsValido = CorreoValido(correo);

            if (rutEsValido && CorreoEsValido)
            {
                return 0;
            }
            else if (rutEsValido && !CorreoEsValido)
            {
                return 1;
            }
            else if (!rutEsValido && CorreoEsValido)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
    }
}
