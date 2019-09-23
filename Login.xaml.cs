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
    }
}
