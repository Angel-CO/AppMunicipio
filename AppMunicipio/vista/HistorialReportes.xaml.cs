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
    /// Interaction logic for HistorialReportes.xaml
    /// </summary>
    public partial class HistorialReportes : Window
    {
        private List<Reporte> reportes = new List<Reporte>();
        private List<Delegacion> delegaciones = new List<Delegacion>();

        public HistorialReportes()
        {
            InitializeComponent();
            CargarTodosLosReportes();
            CargarDelegaciones();
        }

        private void CargarTodosLosReportes()
        {
            reportes = ReporteDAO.getAllReportes();
            this.lvReportes.ItemsSource = reportes;
        }

        private void CargarDelegaciones()
        {
            delegaciones = DelegacionDAO.getAllDelegaciones();
            this.cbDelegacion.DisplayMemberPath = "Nombre";
            this.cbDelegacion.ItemsSource = delegaciones;

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.btnVerDetalles.IsEnabled = true;
        }

        private void btnMostrarTodo_Click(object sender, RoutedEventArgs e)
        {
            this.cbEstatus.SelectedIndex = -1;
            this.cbDelegacion.SelectedIndex = -1;
            this.dpFecha.SelectedDate = null;
            CargarTodosLosReportes();
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            String estatus;
            DateTime fecha;
            Delegacion delegacion;

            if (cbEstatus.SelectedIndex < 0 && dpFecha.SelectedDate == null && cbDelegacion.SelectedIndex < 0)
            {
                MessageBox.Show("Ingrese por lo menos un filtro");
            }
            // Estatus
            else if (cbEstatus.SelectedIndex >= 0 && dpFecha.SelectedDate == null && cbDelegacion.SelectedIndex < 0)
            {
                estatus = ((ComboBoxItem)cbEstatus.SelectedItem).Content.ToString();

                reportes = ReporteDAO.getReportesPorEstatus(estatus);
            }
            // Fecha
            else if (dpFecha.SelectedDate != null && cbEstatus.SelectedIndex < 0 && cbDelegacion.SelectedIndex < 0)
            {
                fecha = (DateTime)dpFecha.SelectedDate;

                reportes = ReporteDAO.getReportesPorFecha(fecha);
            }
            // Delegación
            else if (cbDelegacion.SelectedIndex >= 0 && cbEstatus.SelectedIndex < 0 && dpFecha.SelectedDate == null)
            {
                delegacion = (Delegacion)cbDelegacion.SelectedItem;

                reportes = ReporteDAO.getReportesPorDelegacion(delegacion);
            }
            // Estatus && Fecha
            else if (cbEstatus.SelectedIndex >= 0 && dpFecha.SelectedDate != null && cbDelegacion.SelectedIndex < 0)
            {
                estatus = ((ComboBoxItem)cbEstatus.SelectedItem).Content.ToString();
                fecha = (DateTime)dpFecha.SelectedDate;

                reportes = ReporteDAO.getReportesPorEstatusYFecha(estatus, fecha);
            }
            //Fecha && Delegacion
            else if (dpFecha.SelectedDate != null && cbDelegacion.SelectedIndex >= 0 && cbEstatus.SelectedIndex < 0)
            {
                fecha = (DateTime)dpFecha.SelectedDate;
                delegacion = (Delegacion)cbDelegacion.SelectedItem;

                reportes = ReporteDAO.getReportesPorFechaYDelegacion(fecha, delegacion);
            }
            //Estatus && Fecha && Delegacion
            else if (cbEstatus.SelectedIndex >= 0 && dpFecha.SelectedDate != null && cbDelegacion.SelectedIndex >= 0)
            {
                estatus = ((ComboBoxItem)cbEstatus.SelectedItem).Content.ToString();
                fecha = (DateTime)dpFecha.SelectedDate;
                delegacion = (Delegacion)cbDelegacion.SelectedItem;

                reportes = ReporteDAO.getReportesPorEstatusFechaYDelegacion(estatus, fecha, delegacion);
            }

            this.lvReportes.ItemsSource = reportes;

            if (reportes.Count == 0)
            {
                MessageBox.Show("No se encontrarón coincidencias con la busqueda");
            }
        }


        private void btnVerDetalles_Click(object sender, RoutedEventArgs e)
        {
            DetallesReporte detallesReporte = new DetallesReporte((Reporte)lvReportes.SelectedItem);
            detallesReporte.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void btnLevantarReporte_Click(object sender, RoutedEventArgs e)
        {
            LevantarReporte levantarReporte = new LevantarReporte();
            levantarReporte.Show();
            this.Close();
        }
    }
}
