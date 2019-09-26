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
    /// Lógica de interacción para ModificarProducto.xaml
    /// </summary>
    public partial class ModificarProducto : Window
    {
        public ModificarProducto()
        {
            InitializeComponent();
        }

        private void ButtonVolverModProd_Click(object sender, RoutedEventArgs e)
        {
            MainWindow volverModProd = new MainWindow();
            volverModProd.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxNombreModProd.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del producto no debe estar vacío");
                return;

            }
            double num = 0;
            bool isNum = double.TryParse(textBoxIsbnModProd.Text, out num);
            if (!isNum)
            {
                MessageBox.Show("Ingrese un ISBN válido");
                return;
            }

            if (textBoxTipoModProd.Text.Trim().Length == 0)
            {
                MessageBox.Show("El tipo no debe quedar vacío");
                return;
            }
            if (textBoxMarcaModProd.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre de la marca no debe estar vacío");
                return;

            }
            Regex num1 = new Regex("^[a-zA-Z\\s]*$");
            if (!num1.IsMatch(textBoxMarcaModProd.Text))
            {
                MessageBox.Show("El nombre de la marca solo debe contener caracteres alfabeticos");
                textBoxMarcaModProd.Focus();
            }
            if (textBoxProveedorModProd.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del proveedor no debe estar vacío");
                return;

            }
            Regex num2 = new Regex("^[a-zA-Z\\s]*$");
            if (!num2.IsMatch(textBoxProveedorModProd.Text))
            {
                MessageBox.Show("El nombre del proveedor solo debe contener caracteres alfabeticos");
                textBoxProveedorModProd.Focus();
            }
            if (textBoxPrecioModProd.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del precio no debe estar vacío");
                return;

            }

            bool isNum3 = double.TryParse(textBoxPrecioModProd.Text, out num);
            if (!isNum3)
            {
                MessageBox.Show("Digite un valor de precio valido");
                return;
            }
            else
            {
                MessageBox.Show("El producto se modificó con exito.");
                MainWindow ventanaPrinModProducto = new MainWindow();
                ventanaPrinModProducto.Show();
                this.Hide();
            }
        }
    }
}
