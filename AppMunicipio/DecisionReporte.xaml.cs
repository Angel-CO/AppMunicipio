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
    /// Interaction logic for DecisionReporte.xaml
    /// </summary>
    public partial class DecisionReporte : Window
    {
        public DecisionReporte()
        {
            InitializeComponent();
        }
        private void btn_levantarReporte_click(object sender, RoutedEventArgs e)
        {
            LevantarReporte levantarReporte = new LevantarReporte();
            levantarReporte.Show();
            this.Close();
        }

        private void btn_consultarReporte_click(object sender, RoutedEventArgs e)
        {
            ConsultarHistorialReportes HistorialReporte = new ConsultarHistorialReportes();
            HistorialReporte.Show();
            this.Close();
        }

        private void btn_consultarDictamen_click(object sender, RoutedEventArgs e)
        {
            ConsultarDictamenReporte DictamenReporte = new ConsultarDictamenReporte();
            DictamenReporte.Show();
            this.Close();
        }

        private void btn_regresar_click(object sender, RoutedEventArgs e)
        {
            MenuMunicipio menu = new MenuMunicipio();
            menu.Show();
            this.Close();
        }
    }
}
