﻿using System;
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
    }
}
