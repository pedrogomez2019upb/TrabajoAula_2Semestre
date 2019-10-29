using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace TrabajoAula
{
    /// <summary>
    /// Interaction logic for ventanaAgregarUsuario.xaml
    /// </summary>
    public partial class ventanaAgregarUsuario : Window
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        public ventanaAgregarUsuario()
        {
            InitializeComponent();
        }

        private void BotonVolverAgregarUsuario_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaPrincipalAgregarUsuario = new MainWindow();
            ventanaPrincipalAgregarUsuario.Show();
            this.Hide();
            //Cometario de progreso
        }

        private void botonAgregarUsuarioInstancia_Click(object sender, RoutedEventArgs e)
        {
            if (textboxNombreNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del usuario no debe estar vacío");
                return;

            }
            if (textboxApellidoNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("El apellido del usuario no debe estar vacío");
                return;

            }
            if (textboxSexoNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("El sexo del usuario no debe estar vacío");
                return;

            }
            if (textboxDireccionNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("La direccion del usuario no debe estar vacío");
                return;

            }
            if (textboxCiudadNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("La ciudad del usuario no debe estar vacío");
                return;

            }
            if (textboxLugarNacimientoNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("El lugar de nacimiento del usuario no debe estar vacío");
                return;

            }
            if (textboxEdadNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("La edad del usuario no debe estar vacío");
                return;

            }
            Regex num1 = new Regex("^[a-zA-Z\\s]*$");
            if (num1.IsMatch(textboxEdadNew.Text))
            {
                MessageBox.Show("La edad del usuario solo debe contener numeros");
                textboxEdadNew.Focus();
            }
            if (textboxDepartamentoNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("El departamento del usuario no debe estar vacío");
                return;

            }
            if (textboxNacionalidadNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("La nacionalidad del usuario no debe estar vacío");
                return;

            }
            else
            {
                Usuario usuario2 = new Usuario(textboxNombreNew.Text.ToString(), textboxApellidoNew.Text.ToString(), textboxSexoNew.Text.ToString(), textboxDireccionNew.Text.ToString(), textboxCiudadNew.Text.ToString(), fechaNew.Text.ToString(), textboxLugarNacimientoNew.Text.ToString(),Convert.ToInt32(textboxEdadNew.Text),textboxDepartamentoNew.Text.ToString(),textboxDepartamentoNew.Text.ToString());
                listaUsuarios.Add(usuario2);
                try
                {
                    StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Usuarios.txt", append: true);
                    sw.WriteLine(usuario2.ToString());
                    sw.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error con el archivo y no se pudo registrar");
                }
                finally
                {

                    textboxNombreNew.Text = "";
                    textboxApellidoNew.Text = "";
                    textboxSexoNew.Text = "";
                    textboxDireccionNew.Text = "";
                    textboxCiudadNew.Text = "";
                    fechaNew.Text = "";
                    textboxLugarNacimientoNew.Text = "";
                    textboxLugarNacimientoNew.Text = "";
                    textboxDepartamentoNew.Text = "";





                }
                MessageBox.Show("El Usuario se agregó con exito.");
                MainWindow ventanaPrinCreaProducto = new MainWindow();
                ventanaPrinCreaProducto.Show();

                this.Close();

            }

        }
    }
}
