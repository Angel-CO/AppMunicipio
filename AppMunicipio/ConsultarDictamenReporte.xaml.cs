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
    /// Interaction logic for ConsultarDictamenReporte.xaml
    /// </summary>
    public partial class ConsultarDictamenReporte : Window
    {
        public ConsultarDictamenReporte()
        {
            InitializeComponent();
        }
        private void btn_regresar_click(object sender, RoutedEventArgs e)
        {
            MenuMunicipio menu = new MenuMunicipio();
            menu.Show();
            this.Close();
        }
    }
}
