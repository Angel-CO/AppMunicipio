using AppMunicipio.modelo.dao;
using AppMunicipio.modelo.poco;
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
    /// Interaction logic for CrudVehiculo.xaml
    /// </summary>
    public partial class CrudVehiculo : Window
    {
        List<Vehiculo> vehiculos;
        public CrudVehiculo()
        {
            InitializeComponent();
            cargarVehiculos();
        }

        private void cargarVehiculos()
        {
            vehiculos = VehiculoDAO.getAllVehiculos();
            this.lvVehiculos.ItemsSource = vehiculos;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            ListaConductores listaConductores = new ListaConductores();
            listaConductores.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            FormularioVehiculo formularioVehiculo = new FormularioVehiculo((Vehiculo)lvVehiculos.SelectedItem);
            formularioVehiculo.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Vehiculo vehiculo = (Vehiculo)lvVehiculos.SelectedItem;
            List<VehiculoReporte> vehiculoReportes = VehiculoReporteDAO.getVehiculoReporte(vehiculo);
            if (vehiculoReportes.Count == 0)
            {
                MessageBoxResult resultado = MessageBox.Show("¿Esta seguro de eliminar el vehículo marca " +
                vehiculo.Marca + " modelo " + vehiculo.Modelo + " " + vehiculo.Anio + " con placas " + vehiculo.NumPlaca + "?"
                , "Confirmar acción", MessageBoxButton.OKCancel);
                if (resultado == MessageBoxResult.OK)
                {
                    VehiculoDAO.eliminarVehiculo(vehiculo);
                    cargarVehiculos();
                    MessageBox.Show("Vehiculo eliminado");
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar porque esta asociado a reportes");
            }
        }

        private void lvVehiculos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
        }
    }
}
