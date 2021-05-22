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
    /// Interaction logic for MenuMunicipio.xaml
    /// </summary>
    public partial class MenuMunicipio : Window
    {
        public MenuMunicipio()
        {
            InitializeComponent();
        }
        private void btn_reporteVehicular_click(object sender, RoutedEventArgs e)
        {
            DecisionReporte reporteVehicular = new DecisionReporte();
            reporteVehicular.Show();
            this.Close();
        }

        private void btn_conductores_click(object sender, RoutedEventArgs e)
        {
            ListaConductores listaConductores = new ListaConductores();
            listaConductores.Show();
            this.Close();
        }

        private void btn_vehiculos_click(object sender, RoutedEventArgs e)
        {
            ListaVehiculos listaVehiculos = new ListaVehiculos();
            listaVehiculos.Show();
            this.Close();
        }

        private void btn_chat_click(object sender, RoutedEventArgs e)
        {
            Chat chat = new Chat();
            chat.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }
    }
}
