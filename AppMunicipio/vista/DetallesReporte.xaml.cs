using AppMunicipio.modelo.dao;
using AppMunicipio.modelo.poco;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for DetallesReporte.xaml
    /// </summary>
    public partial class DetallesReporte : Window
    {
        private Reporte reporte;
        private List<Conductor> conductores;
        private List<Vehiculo> vehiculos;
        private List<Fotografia> fotografias;
        public DetallesReporte()
        {
            InitializeComponent();
        }

        public DetallesReporte(Reporte reporte) : this()
        {
            this.reporte = reporte;
            cargarReporte();
            cargarDatosDictamen();
            cargarConductores();
            cargarVehiculos();
            cargarImagenes();
        }

        private void cargarReporte()
        {
            tbEstatus.Text = reporte.Estatus;
            dpFecha.SelectedDate = reporte.FechaHora;
            tbDelegacion.Text = reporte.NombreDelegacion;
            tbDireccion.Text = reporte.DireccionSiniestro;
        }
        private void cargarDatosDictamen()
        {
            Dictamen dictamen = DictamenDAO.getDictamen(reporte);
            if (dictamen.Folio > 0)
            {
                tbFolio.Text = dictamen.Folio.ToString();
                tbFecha.Text = dictamen.FechaHora.ToString("dd/MM/yyyy");
                tbHora.Text = dictamen.FechaHora.ToString("hh:mm tt");
                tbPerito.Text = dictamen.NombrePerito;
                tbDescripcion.Text = dictamen.Descripcion;
            }

        }

        private void cargarConductores()
        {
            conductores = ConductorDAO.getConductores(reporte);
            lvCondcutores.ItemsSource = conductores;
        }

        private void cargarVehiculos()
        {
            vehiculos = VehiculoDAO.getVehiculos(reporte);
            lvVehiculos.ItemsSource = vehiculos;
        }

        private void cargarImagenes()
        {
            fotografias = FotografiaDAO.getFotografias(reporte);
            int contador = 0;
            foreach (Fotografia fotografia in fotografias)
            {
                switch (contador)
                {
                    case 0:
                        imgImagen01.Source = bytesABitmapImage(fotografia.Foto);
                        break;
                    case 1:
                        imgImagen02.Source = bytesABitmapImage(fotografia.Foto);
                        break;
                    case 2:
                        imgImagen03.Source = bytesABitmapImage(fotografia.Foto);
                        break;
                    case 3:
                        imgImagen04.Source = bytesABitmapImage(fotografia.Foto);
                        break;
                    case 4:
                        imgImagen05.Source = bytesABitmapImage(fotografia.Foto);
                        break;
                    case 5:
                        imgImagen06.Source = bytesABitmapImage(fotografia.Foto);
                        break;
                    case 6:
                        imgImagen07.Source = bytesABitmapImage(fotografia.Foto);
                        break;
                    case 7:
                        imgImagen08.Source = bytesABitmapImage(fotografia.Foto);
                        break;
                }
                contador++;
            }
        }

        private BitmapImage bytesABitmapImage(byte[] imageData)
        {
            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream memoryStream = new MemoryStream(imageData))
            {
                memoryStream.Position = 0;
                bitmapImage.BeginInit();
                bitmapImage.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.UriSource = null;
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.EndInit();
            }
            bitmapImage.Freeze();
            return bitmapImage;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            HistorialReportes historialReportes = new HistorialReportes();
            historialReportes.Show();
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, RoutedEventArgs e)
        {
            HistorialReportes historialReportes = new HistorialReportes();
            historialReportes.Show();
            this.Close();
        }
    }
}
