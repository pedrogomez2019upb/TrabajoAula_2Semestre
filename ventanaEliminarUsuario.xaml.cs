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
    /// Interaction logic for ventanaEliminarUsuario.xaml
    /// </summary>
    public partial class ventanaEliminarUsuario : Window
    {
        public ventanaEliminarUsuario()
        {
            InitializeComponent();
        }

        private void BotonRealizarEliminarUsuario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BotonVolverEliminarUsuario_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaPrincipalEliminarUsuario = new MainWindow();
            ventanaPrincipalEliminarUsuario.Show();
            this.Hide();
        }
    }
}
