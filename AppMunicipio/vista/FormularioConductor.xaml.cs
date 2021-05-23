using AppMunicipio.modelo.dao;
using AppMunicipio.modelo.poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for FormularioConductor.xaml
    /// </summary>
    public partial class FormularioConductor : Window
    {

        private Conductor conductorEdicion;
        private Boolean isNuevo = true;

        public FormularioConductor()
        {
            conductorEdicion = new Conductor();
            InitializeComponent();
            this.lbTitulo.Content = "Registrar conductor";
        }

        public FormularioConductor(Conductor conductor): this()
        {
            this.conductorEdicion = conductor;
            isNuevo = false;
            this.lbTitulo.Content = "Modificar conductor";
            llenarCampos();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            CrudConductor crudConductor = new CrudConductor();
            crudConductor.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (validarDatos())
            {
                if (isNuevo)
                {
                    ConductorDAO.agregarConductor(conductorEdicion);
                    MessageBox.Show("Conductor registrado");
                }
                else
                {
                    ConductorDAO.modificarConductor(conductorEdicion);
                    MessageBox.Show("Conductor modificado");
                }
                CrudConductor crudConductor = new CrudConductor();
                crudConductor.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private bool validarDatos()
        {
            string erNombre = @"[a-zA-Z]$";
            string erApellidos = @"[a-zA-Z]$";
            string erNumLicencia = @"[a-zA-Z0-9]";
            string erTelefono = @"[0-9]{10}$";
            bool datosValidos = true;

            if (Regex.IsMatch(tbNombre.Text, erNombre))
            {
                conductorEdicion.Nombre = tbNombre.Text;
                tbNombre.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                tbNombre.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (Regex.IsMatch(tbApellidoPaterno.Text, erApellidos))
            {
                conductorEdicion.ApellidoPaterno = tbApellidoPaterno.Text;
                tbApellidoPaterno.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                tbApellidoPaterno.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (Regex.IsMatch(tbApellidoMaterno.Text, erApellidos))
            {
                conductorEdicion.ApellidoMaterno = tbApellidoMaterno.Text;
                tbApellidoMaterno.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                tbApellidoMaterno.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (dpFecha.SelectedDate < new DateTime(2003, 1, 2) && dpFecha.SelectedDate > new DateTime(1920, 1, 1))
            {
                conductorEdicion.FechaNacimiento = (DateTime)dpFecha.SelectedDate;
                dpFecha.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                dpFecha.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (Regex.IsMatch(tbNumLicencia.Text, erNumLicencia))
            {
                conductorEdicion.NumLicencia = tbNumLicencia.Text;
                tbNumLicencia.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                tbNumLicencia.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (Regex.IsMatch(tbTelefono.Text, erTelefono))
            {
                conductorEdicion.Telefono = tbTelefono.Text;
                tbTelefono.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                tbTelefono.BorderBrush = Brushes.Red;
                datosValidos = false;
            }
            return datosValidos;
        }

        private void llenarCampos()
        {
            tbNombre.Text = conductorEdicion.Nombre;
            tbApellidoPaterno.Text = conductorEdicion.ApellidoPaterno;
            tbApellidoMaterno.Text = conductorEdicion.ApellidoMaterno;
            dpFecha.SelectedDate = conductorEdicion.FechaNacimiento;
            tbNumLicencia.Text = conductorEdicion.NumLicencia;
            tbTelefono.Text = conductorEdicion.Telefono;
        }
    }
}
