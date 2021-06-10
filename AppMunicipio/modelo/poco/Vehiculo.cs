using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMunicipio.modelo.poco
{
    public class Vehiculo
    {
        private int idVehiculo;
        private String marca;
        private String modelo;
        private int anio;
        private String color;
        private String nombreAseguradora;
        private String numPolizaSeguro;
        private String numPlaca;
        private int idConductor;
        private String nombreConductor;

        public int IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Color { get => color; set => color = value; }
        public string NombreAseguradora { get => nombreAseguradora; set => nombreAseguradora = value; }
        public string NumPolizaSeguro { get => numPolizaSeguro; set => numPolizaSeguro = value; }
        public string NumPlaca { get => numPlaca; set => numPlaca = value; }
        public int IdConductor { get => idConductor; set => idConductor = value; }
        public string NombreConductor { get => nombreConductor; set => nombreConductor = value; }
    }
}
