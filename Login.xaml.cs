using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        static string usuario = "andres";
        static string contrasena = "andres1992";
       
        public Login()
        {
            InitializeComponent();
        }

        private void BotonVentanaLogin_Click(object sender, RoutedEventArgs e)
        {

            
            //Validacion Usuario y Password
            if (textboxUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Por favor revisa el usuario. Este no puede estar vacio.");
                return;
            }
            if (textboxPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Por favor revisa la contraseña. Esta no puede estar vacia.");
                return;
            }
            if (textboxUsuario.Text.Equals(usuario) && textboxPassword.Text.Equals(contrasena))
            {
                MessageBox.Show("Bievenido! Sigue hacia el programa principal.");
                MainWindow ventanaPrincipal = new MainWindow();
                ventanaPrincipal.Show();
                this.Hide();//this.Close();
            }
            
            else
            {
                MessageBox.Show("Por favor revisar el usuario/password");
            }
        }


        private void ButtonCerrarLogin_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void BotonVentanaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void botonVentanaLogin_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void textboxPassword_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
