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
    /// Lógica de interacción para EliminarProducto.xaml
    /// </summary>
    public partial class EliminarProducto : Window
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void TextBoxNombreEliminarProducto_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void TextBoxNrefeElimProducto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxNombreEliminarProducto.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del producto a eliminar no debe estar vacío");
                return;
            }
            double num1;
            bool isNum4 = double.TryParse(textBoxNrefeElimProducto.Text, out num1);
            if (!isNum4)
            {
                MessageBox.Show("Ingrese un número ne referencia válido");
                return;
            }
            else
            {
                MessageBox.Show("Los cambios se guardaron con exito");
                MainWindow ventanaPriciElimiProducto = new MainWindow();
                ventanaPriciElimiProducto.Show();
                this.Hide();
            }


        }
    }
}
