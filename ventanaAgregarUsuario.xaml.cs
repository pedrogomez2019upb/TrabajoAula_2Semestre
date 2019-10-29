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

namespace TrabajoAula
{
    /// <summary>
    /// Interaction logic for ventanaAgregarUsuario.xaml
    /// </summary>
    public partial class ventanaAgregarUsuario : Window
    {
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

        }
    }
}
