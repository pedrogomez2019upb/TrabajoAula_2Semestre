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
    }
}
