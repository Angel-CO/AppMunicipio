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

namespace AppMunicipio
{
    /// <summary>
    /// Interaction logic for RegistrarVehiculo.xaml
    /// </summary>
    public partial class RegistrarVehiculo : Window
    {
        public RegistrarVehiculo()
        {
            InitializeComponent();
        }
        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            ListaVehiculos listaVehiculos = new ListaVehiculos();
            listaVehiculos.Show();
            this.Close();
        }
    }
}
