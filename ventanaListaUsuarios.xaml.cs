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
using System.IO;

namespace TrabajoAula
{
    /// <summary>
    /// Interaction logic for ventanaListaUsuarios.xaml
    /// </summary>
    public partial class ventanaListaUsuarios : Window
    {
        Usuario usuario1 = new Usuario();
        private void mostrarUsuarios()
        {
            
            List<Usuario> usuarios = usuario1.recibirUsuarios();
            comboUsuarios.Items.Clear();
            for (int i = 0; i < usuarios.Count; i++)
            {
                comboUsuarios.Items.Add(usuarios[i].Nombre);
            }
            comboUsuarios.IsEnabled = true;
            if (usuarios.Count > 0)
                comboUsuarios.SelectedIndex = 0;
        }
        public ventanaListaUsuarios()
        {
            InitializeComponent();
            mostrarUsuarios();
            cargarUsuarios();
        }
        public void cargarUsuarios()
        {
            usuario1.cargarUsuarios();
        }
        private void BotonSeleccionarUsuario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BotonVolverLista_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaPrincipalVolverLista = new MainWindow();
            ventanaPrincipalVolverLista.Show();
            this.Hide();
        }

        private void comboUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
