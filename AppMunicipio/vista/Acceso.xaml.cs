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
    /// Interaction logic for Acceso.xaml
    /// </summary>
    public partial class Acceso : Window
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (validarUsuario())
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta");
            }
        }

        private bool validarUsuario()
        {
            Usuario usuario = UsuarioDAO.getUsuario(tbNombreUsuario.Text);
            if(usuario.IdUsuario > 0)
            {
                if (usuario.NombreUsuario.Equals(tbNombreUsuario.Text) &&
                    usuario.Contrasenia.Equals(pbContrasenia.Password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
