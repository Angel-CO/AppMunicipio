using AppMunicipio.modelo.poco;
using AppMunicipio.modelo.dao;
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
    /// Interaction logic for ListaConductores.xaml
    /// </summary>
    public partial class ListaConductores : Window
    {
        List<Conductor> conductores = new List<Conductor>();

        public List<Conductor> CondcutorDAO { get; private set; }

        public ListaConductores()
        {
            InitializeComponent();
            cargarConductores();
        }
        private void cargarConductores()
        {
            conductores = ConductorDAO.getAllConductores();
            lvCondcutores.ItemsSource = conductores;
        }
        private void lvCondcutores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.btnAgregarAuto.IsEnabled = true;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            CrudVehiculo crudVehiculo = new CrudVehiculo();
            crudVehiculo.Show();
            this.Close();
        }

        private void btnAgregarAuto_Click(object sender, RoutedEventArgs e)
        {
            FormularioVehiculo formularioVehiculo = new FormularioVehiculo((Conductor)lvCondcutores.SelectedItem);
            formularioVehiculo.Show();
            this.Close();

        }
    }
}
