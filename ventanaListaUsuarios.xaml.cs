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
    /// Interaction logic for ventanaListaUsuarios.xaml
    /// </summary>
    public partial class ventanaListaUsuarios : Window
    {
        public ventanaListaUsuarios()
        {
            InitializeComponent();
        }

        private void BotonSeleccionarUsuario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BotonVolverLista_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaPrincipalVolverLista = new MainWindow();
            ventanaPrincipalVolverLista.Show();
            this.Hide();
        }
    }
}
