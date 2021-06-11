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

namespace AppMunicipio.vista
{
    /// <summary>
    /// Interaction logic for MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnReporteVehicular_Click(object sender, RoutedEventArgs e)
        {
            HistorialReportes historialReportes = new HistorialReportes();
            historialReportes.Show();
            this.Close();
        }
        private void btnconductores_Click(object sender, RoutedEventArgs e)
        {
            CrudConductor crudConductor = new CrudConductor();
            crudConductor.Show();
            this.Close();
        }

        private void btnvehiculos_Click(object sender, RoutedEventArgs e)
        {
            CrudVehiculo crudVehiculo = new CrudVehiculo();
            crudVehiculo.Show();
            this.Close();
        }

        
    }
}
