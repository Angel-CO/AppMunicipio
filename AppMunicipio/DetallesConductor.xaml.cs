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
    /// Interaction logic for DetallesConductor.xaml
    /// </summary>
    public partial class DetallesConductor : Window
    {
        public DetallesConductor()
        {
            InitializeComponent();
        }

        private void registrarVehiculo_Click(object sender, RoutedEventArgs e)
        {
            RegistrarVehiculo registrarVehiculo = new RegistrarVehiculo();
            registrarVehiculo.Show();
            this.Close();
        }
    }
}
