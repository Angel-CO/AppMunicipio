using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMunicipio.modelo.poco
{
    public class Delegacion
    {
        private int idDelegacion;
        private String nombre;
        private String calle;
        private String numero;
        private String colonia;
        private String codigoPostal;
        private String telefono;
        private String correo;
        private String tipoDelegacion;
        private int idMunicipio;
        private String nombreMunicipio;

        public int IdDelegacion { get => idDelegacion; set => idDelegacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string TipoDelegacion { get => tipoDelegacion; set => tipoDelegacion = value; }
        public int IdMunicipio { get => idMunicipio; set => idMunicipio = value; }
        public string NombreMunicipio { get => nombreMunicipio; set => nombreMunicipio = value; }
    }

}
