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
    /// Interaction logic for editarUsuario.xaml
    /// </summary>
    public partial class editarUsuario : Window
    {
        public editarUsuario()
        {
            InitializeComponent();
        }

        private void BotonVolverEditarUsuario_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaPrinciapl = new MainWindow();
            ventanaPrinciapl.Show();
            this.Hide();
        }
    }
}
