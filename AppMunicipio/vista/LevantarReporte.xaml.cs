using AppMunicipio.modelo.dao;
using AppMunicipio.modelo.poco;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for LevantarReporte.xaml
    /// </summary>
    public partial class LevantarReporte : Window
    {
        List<Delegacion> delegaciones;
        ObservableCollection<Conductor> conductores;
        ObservableCollection<Conductor> conductoresSeleccionados;
        ObservableCollection<Vehiculo> vehiculos;
        ObservableCollection<Vehiculo> vehiculosSeleccionados;

        public LevantarReporte()
        {
            InitializeComponent();
            cargarDelegaciones();
            cargarCondutores();
            cargarVehiculos();
        }

        private void cargarDelegaciones()
        {
            delegaciones = DelegacionDAO.getAllDelegaciones();
            cbDelegacion.DisplayMemberPath = "Nombre";
            cbDelegacion.ItemsSource = delegaciones;
        }

        private void cargarCondutores()
        {
            conductores = new ObservableCollection<Conductor>(ConductorDAO.getAllConductores());
            lvCondcutores.ItemsSource = conductores;

            conductoresSeleccionados = new ObservableCollection<Conductor>();
            lvCondcutoresSeleccionados.ItemsSource = conductoresSeleccionados;
        }

        private void cargarVehiculos()
        {
            vehiculos = new ObservableCollection<Vehiculo>(VehiculoDAO.getAllVehiculos());
            lvVehiculos.ItemsSource = vehiculos;

            vehiculosSeleccionados = new ObservableCollection<Vehiculo>();
            lvVehiculosSeleccionados.ItemsSource = vehiculosSeleccionados;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (validarDatos())
            {
                Reporte reporte = crearReporte();
                ReporteDAO.registrarReporte(reporte);

                Reporte ultimoReporte = ReporteDAO.getUltimoReporte();

                guardarConductorReporte(ultimoReporte);
                guardarVehiculoReporte(ultimoReporte);
                MessageBox.Show("Reporte guardado");
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }


        private bool validarDatos()
        {
            bool datosValidos = true;

            if (!tbDireccion.Text.Equals(""))
            {
                tbDireccion.BorderBrush = Brushes.Green;
            }
            else
            {
                tbDireccion.BorderBrush = Brushes.Red;
                datosValidos = false;
            }
            if(cbDelegacion.SelectedIndex < 0)
            {
                tbDireccion.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if(conductoresSeleccionados.Count > 0)
            {
                lbConductoresSeleccionados.Foreground = Brushes.Black;
            }
            else
            {
                lbConductoresSeleccionados.Foreground = Brushes.Red;
                datosValidos = false;
            }

            if(vehiculosSeleccionados.Count > 0)
            {
                lbVehiculosSeleccionados.Foreground = Brushes.Black;
            }
            else
            {
                lbVehiculosSeleccionados.Foreground = Brushes.Red;
                datosValidos = false;
            }

            return datosValidos;
        }

        private void lvCondcutores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lvCondcutores.SelectedItem != null)
            {
                Conductor conductorSeleccionado = (Conductor)lvCondcutores.SelectedItem;
                conductoresSeleccionados.Add(conductorSeleccionado);
                conductores.Remove(conductorSeleccionado);
            }
        }

        private void lvCondcutoresSeleccionados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lvCondcutoresSeleccionados.SelectedItem != null)
            {
                Conductor conductorSeleccionado = (Conductor)lvCondcutoresSeleccionados.SelectedItem;
                conductores.Add(conductorSeleccionado);
                conductoresSeleccionados.Remove(conductorSeleccionado);

            }
        }

        private void lvVehiculos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lvVehiculos.SelectedItem != null)
            {
                Vehiculo vehiculoSeleccionado = (Vehiculo)lvVehiculos.SelectedItem;
                vehiculosSeleccionados.Add(vehiculoSeleccionado);
                vehiculos.Remove(vehiculoSeleccionado);
            }
        }

        private void lvVehiculosSeleccionados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvCondcutoresSeleccionados.SelectedItem != null)
            {
                Vehiculo vehiculoSeleccionado = (Vehiculo)lvVehiculosSeleccionados.SelectedItem;
                vehiculos.Add(vehiculoSeleccionado);
                vehiculosSeleccionados.Remove(vehiculoSeleccionado);
            }
        }


        private Reporte crearReporte()
        {
            Reporte reporte = new Reporte();

            reporte.DireccionSiniestro = tbDireccion.Text;
            reporte.Estatus = "Pendiente";
            reporte.FechaHora = DateTime.Now;
            reporte.IdDelegacion = ((Delegacion)cbDelegacion.SelectedItem).IdDelegacion;
            return reporte;
        }

        private void guardarConductorReporte(Reporte ultimoReporte)
        {
            foreach(Conductor conductor in conductoresSeleccionados)
            {
                ConductorReporte conductorReporte = new ConductorReporte();
                conductorReporte.IdConductor = conductor.IdConductor;
                conductorReporte.IdReporte = ultimoReporte.IdReporte;

                ConductorReporteDAO.registrarConductorReporte(conductorReporte);

            }
        }

        private void guardarVehiculoReporte(Reporte ultimoReporte)
        {
            foreach(Vehiculo vehiculo in vehiculosSeleccionados)
            {
                VehiculoReporte vehiculoReporte = new VehiculoReporte();
                vehiculoReporte.IdVehiculo = vehiculo.IdVehiculo;
                vehiculoReporte.IdReporte = ultimoReporte.IdReporte;

                VehiculoReporteDAO.registrarVehiculoReporte(vehiculoReporte);
            }
        }
    }
}
