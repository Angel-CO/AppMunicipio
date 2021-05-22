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
    /// Interaction logic for ListaConductores.xaml
    /// </summary>
    public partial class ListaConductores : Window
    {
        public ListaConductores()
        {
            InitializeComponent();
        }

        

        private void btn_verDetalles_Click(object sender, RoutedEventArgs e)
        {
            DetallesConductor detallesConductor = new DetallesConductor();
            detallesConductor.Show();
            this.Close();
        }
    }
}
