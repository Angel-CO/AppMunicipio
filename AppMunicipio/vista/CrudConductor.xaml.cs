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
    /// Interaction logic for CrudConductor.xaml
    /// </summary>
    public partial class CrudConductor : Window
    {
        /*
         * Este
         * es un
         * comentario
         */
        List<Conductor> conductores;
        public CrudConductor()
        {
            InitializeComponent();
            conductores = new List<Conductor>();
            cargarDatosConductores();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MenuMunicipio menuMunicipio = new MenuMunicipio();
            menuMunicipio.Show();
            this.Close();
        }

        private void cargarDatosConductores()
        {
            conductores = ConductorDAO.getAllConductores();
            this.lvCondcutores.ItemsSource = conductores;

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            FormularioConductor formularioCondcutor = new FormularioConductor();
            formularioCondcutor.Show();
            this.Close();
        }

        private void lvCondcutores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            FormularioConductor formularioConductor = new FormularioConductor((Conductor)lvCondcutores.SelectedItem);
            formularioConductor.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Conductor conductor = (Conductor)lvCondcutores.SelectedItem;
            List<Vehiculo> vehiculos = VehiculoDAO.getVehiculosConductor(conductor);
            if (VehiculoDAO.getVehiculosConductor(conductor).Count == 0)
            {
                MessageBoxResult resultado = MessageBox.Show("¿Está seguro de eliminar el conductor(a) " +
                conductor.Nombre + " " + conductor.ApellidoPaterno + " " + conductor.ApellidoMaterno + "?"
                , "Confirmar acción", MessageBoxButton.OKCancel);
                if (resultado == MessageBoxResult.OK)
                {
                    ConductorDAO.eliminarConductor(conductor);
                    cargarDatosConductores();
                    MessageBox.Show("Conductor eliminado");
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar porque tiene vehículos asociados");
            }
            
        }
    }
}
