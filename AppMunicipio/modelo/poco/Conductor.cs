using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMunicipio.modelo.poco
{
    public class Conductor
    {
        private int idConductor;
        private String nombre;
        private String apellidoPaterno;
        private String apellidoMaterno;
        private DateTime fechaNacimiento;
        private String numLicencia;
        private String telefono;

        public int IdConductor { get => idConductor; set => idConductor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string NumLicencia { get => numLicencia; set => numLicencia = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
