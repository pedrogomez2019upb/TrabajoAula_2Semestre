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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TrabajoAula
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            fecha.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void CrearProducto_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Ventas1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}