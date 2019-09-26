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
            bool isNum = double.TryParse(textBoxIsbnCreaProd.Text, out num);
            if (!isNum)
            {
                MessageBox.Show("Ingrese un ISBN válido");
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
            Regex num1 = new Regex("^[a-zA-Z\\s]*$");
            if (!num1.IsMatch(textBoxMarcaCreaProd.Text))
            {
                MessageBox.Show("El nombre de la marca solo debe contener caracteres alfabeticos");
                textBoxMarcaCreaProd.Focus();
            }
            if (textBoxProveeCreaProd.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del proveedor no debe estar vacío");
                return;

            }
            Regex num2 = new Regex("^[a-zA-Z\\s]*$");
            if (!num2.IsMatch(textBoxProveeCreaProd.Text))
            {
                MessageBox.Show("El nombre del proveedor solo debe contener caracteres alfabeticos");
                textBoxProveeCreaProd.Focus();
            }
            if (textBoxPrecioCreaProd.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del precio no debe estar vacío");
                return;

            }

            bool isNum3 = double.TryParse(textBoxPrecioCreaProd.Text, out num);
            if (!isNum3)
            {
                MessageBox.Show("Digite un valor de precio valido");
                return;
            }
            else { MessageBox.Show("Se agrego el producto."); }
            









        }
    }
}
