using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMunicipio.modelo.poco
{
    public class Usuario
    {
        private int idUsuario;
        private String nombreUsuario;
        private String contrasenia;
        private String nombre;
        private String apellidoPaterno;
        private String apellidoMaterno;
        private String cargo;
        private int idDelegacion;
        private String delegacion;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int IdDelegacion { get => idDelegacion; set => idDelegacion = value; }
        public string Delegacion { get => delegacion; set => delegacion = value; }

        public string NombreCompleto => apellidoPaterno + " " + apellidoMaterno + " " + nombre;
    }

}
