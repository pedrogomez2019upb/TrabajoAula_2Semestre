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
    /// Interaction logic for creacionProducto.xaml
    /// </summary>
    public partial class creacionProducto : Window
    {
        public creacionProducto()
        {
            InitializeComponent();
        }

        private void BotonVolverCreacion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textboxNombreCreaProd.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del producto no debe estar vacío");
                return;

            }

            Regex r = new Regex("^[0-5\\s]*$");
            if (!r.IsMatch(textBoxIsbnCreaProd.Text))
            {
                MessageBox.Show("El campo ISBN no debe quedar vacío");
                textBoxIsbnCreaProd.Focus();
            }
        }
    }
}
