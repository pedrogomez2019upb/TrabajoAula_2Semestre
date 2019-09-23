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
    /// Lógica de interacción para ResumenInventario.xaml
    /// </summary>
    public partial class ResumenInventario : Window
    {
        public ResumenInventario()
        {
            InitializeComponent();
        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow buttonAceptarResuInve = new MainWindow();
            buttonAceptarResuInve.Show();
            this.Hide();
        }
    }
}
