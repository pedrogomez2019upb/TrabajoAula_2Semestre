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
            double num = 0;
            bool isNum = double.TryParse(textboxNombreCreaProd.Text, out num);
            if (!isNum)
            {
                MessageBox.Show("El campo ISBN no debe contener caracteres alfabeticos");
                return;
            }

            if (textBoxTipoCreaProd.Text.Trim().Length == 0)
            {
                MessageBox.Show("El tipo no debe quedar vacío");
                return;
            }
            if (textBoxMarcaCreaProd.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre de la marca no debe estar vacío");
                return;

            }









        }
    }
}
