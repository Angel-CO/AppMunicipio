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
    /// Interaction logic for FormularioVehiculo.xaml
    /// </summary>
    public partial class FormularioVehiculo : Window
    {
        private Conductor conductor;
        private Vehiculo vehiculoEditar;
        bool esNuevo;
        public FormularioVehiculo()
        {
            InitializeComponent();
        }

        public FormularioVehiculo(Conductor conductor): this()
        {
            InitializeComponent();
            this.conductor = conductor;
            this.lbTitulo.Content = "Registrar vehículo";
            this.lbConductor.Content = conductor.Nombre + " " + conductor.ApellidoPaterno + " " + conductor.ApellidoMaterno;
            esNuevo = true;
        }

        public FormularioVehiculo(Vehiculo vehiculo) : this()
        {
            InitializeComponent();
            vehiculoEditar = vehiculo;
            this.lbTitulo.Content = "Modificar vehículo";
            this.lbConductor.Content = vehiculo.NombreConductor;
            cargarDatosVehiculo();
            esNuevo = false;
        }
        private void cargarDatosVehiculo()
        {
            tbMarca.Text = vehiculoEditar.Marca;
            tbModelo.Text = vehiculoEditar.Modelo;
            tbAnio.Text = vehiculoEditar.Anio.ToString();
            tbColor.Text = vehiculoEditar.Color;
            tbNombreAseguradora.Text = vehiculoEditar.NombreAseguradora;
            tbNumPolizaSeguro.Text = vehiculoEditar.NumPolizaSeguro;
            tbNumPlaca.Text = vehiculoEditar.NumPlaca;
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            ListaConductores listaConductores = new ListaConductores();
            listaConductores.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (validarDatos())
            {
                Vehiculo vehiculoRepetido = VehiculoDAO.getVehiculo(tbNumPlaca.Text);
                if ((vehiculoRepetido.NumPlaca != tbNumPlaca.Text && esNuevo)
                    || (vehiculoRepetido.IdVehiculo == vehiculoEditar.IdVehiculo && !esNuevo)
                    || (vehiculoRepetido.IdVehiculo == 0 && !esNuevo))
                {
                    tbNumPlaca.BorderBrush = Brushes.Green;
                    if (esNuevo)
                    {
                        VehiculoDAO.registarVehiculo(crearVehiculo());
                        MessageBox.Show("Vehiculo registrado");
                    }
                    else
                    {
                        VehiculoDAO.modificarVehiculo(crearVehiculo());
                        MessageBox.Show("Vehiculo modificado");
                    }
                    CrudVehiculo crudVehiculo = new CrudVehiculo();
                    crudVehiculo.Show();
                    this.Close();
                }
                else
                {
                    tbNumPlaca.BorderBrush = Brushes.Red;
                    MessageBox.Show("El número de placa ya esta registrado");
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private bool validarDatos()
        {
            string erAnio = @"[0-9]{4}$";
            string erNumPlaca = @"[0-9A-Z]{7}$";
            bool datosValidos = true;
            if(tbMarca.Text.Length > 0)
            {
                tbMarca.BorderBrush = Brushes.Green;
            }
            else
            {
                tbMarca.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if(tbModelo.Text.Length > 0)
            {
                tbModelo.BorderBrush = Brushes.Green;
            }
            else
            {
                tbModelo.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if(Regex.IsMatch(tbAnio.Text, erAnio))
            {
                tbAnio.BorderBrush = Brushes.Green;
            }
            else
            {
                tbAnio.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if(tbColor.Text.Length > 0)
            {
                tbColor.BorderBrush = Brushes.Green;
            }
            else
            {
                tbColor.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if ((tbNombreAseguradora.Text.Length > 0 && tbNumPolizaSeguro.Text.Length > 0)
                || (tbNombreAseguradora.Text.Length == 0 && tbNumPolizaSeguro.Text.Length == 0))
            {
                tbNombreAseguradora.BorderBrush = Brushes.Green;
                tbNumPolizaSeguro.BorderBrush = Brushes.Green;
            }
            else
            {
                tbNombreAseguradora.BorderBrush = Brushes.Red;
                tbNumPolizaSeguro.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (Regex.IsMatch(tbNumPlaca.Text, erNumPlaca))
            {
                tbNumPlaca.BorderBrush = Brushes.Green;
            }
            else
            {
                tbNumPlaca.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            return datosValidos;
        }

        private Vehiculo crearVehiculo()
        {
            Vehiculo vehiculo = new Vehiculo();
            if (esNuevo)
            {
                vehiculo.IdConductor = this.conductor.IdConductor;
                vehiculo.NombreConductor = this.conductor.Nombre;
            }
            else
            {
                vehiculo.IdVehiculo = vehiculoEditar.IdVehiculo;
            }

            vehiculo.Marca = tbMarca.Text;
            vehiculo.Modelo = tbModelo.Text;
            vehiculo.Anio = Int32.Parse(tbAnio.Text);
            vehiculo.Color = tbColor.Text;
            vehiculo.NombreAseguradora = tbNombreAseguradora.Text;
            vehiculo.NumPolizaSeguro = tbNumPolizaSeguro.Text;
            vehiculo.NumPlaca = tbNumPlaca.Text;

            return vehiculo;
        }
    }
}
