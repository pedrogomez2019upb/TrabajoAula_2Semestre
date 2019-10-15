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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace TrabajoAula
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Producto> productos1;
        public MainWindow()
        {
            InitializeComponent();
            //fecha.Text = DateTime.Now.ToString("hh:mm:ss tt");
            llenaLista();
        }
        public void llenaLista()
        {
            string line;
            StreamReader lector = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\Productos1.txt", Encoding.UTF8);
            productos1 = new List<Producto>();

            while ((line = lector.ReadLine()) != null)
            {
                Producto prodTemp = new Producto(line);
           
                //MessageBox.Show(line.ToString());
                //string[] datos = line.Split(',');

                //prodTemp = new Producto(line);
                productos1.Add(prodTemp);

            }
            lector.Close();
            dataGridVentas.ItemsSource = productos1;
            llenarListBox();
        }
        private void llenarListBox()
        {
            listBoxVentas.Items.Clear();
            if (productos1.Count > 0)
            {
                foreach (Producto prod in productos1)
                {
                    listBoxVentas.Items.Add(prod);
                }

            }
        }
        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void CrearProducto_Click(object sender, RoutedEventArgs e)
        {
            creacionProducto cp = new creacionProducto();
            cp.Show();
            this.Hide();
        }

        private void Ventas1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
             
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BotonLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EliminarProducto_Click(object sender, RoutedEventArgs e)
        {
            EliminarProducto eliminarP = new EliminarProducto();
            eliminarP.Show();
            this.Hide();
        }

        private void ModificarProducto_Click(object sender, RoutedEventArgs e)
        {
            ModificarProducto modificarP = new ModificarProducto();
            modificarP.Show();
            this.Hide();
        }

        private void ResumenInventario_Click(object sender, RoutedEventArgs e)
        {
            ResumenInventario resumenInventario = new ResumenInventario();
            resumenInventario.Show();
            this.Hide();

        }

        private void EditarUsuario_Click(object sender, RoutedEventArgs e)
        {
            editarUsuario eD = new editarUsuario();
            eD.Show();
            this.Hide();
        }

        private void ListaUsuario_Click(object sender, RoutedEventArgs e)
        {
            ventanaListaUsuarios vLU = new ventanaListaUsuarios();
            vLU.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ventanaEliminarUsuario vEU = new ventanaEliminarUsuario();
            vEU.Show();
            this.Hide();
        }

        private void BotonAgegarUsuario_Click(object sender, RoutedEventArgs e)
        {
            ventanaAgregarUsuario vAG = new ventanaAgregarUsuario();
            vAG.Show();
            this.Hide();
        }
    }
}
