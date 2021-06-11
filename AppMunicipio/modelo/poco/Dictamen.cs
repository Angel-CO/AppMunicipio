using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMunicipio.modelo.poco
{
    public class Dictamen
    {
        private int folio;
        private String descripcion;
        private DateTime fechaHora;
        private int idReporte;
        private int idUsuario;
        private String nombrePerito;

        public int Folio { get => folio; set => folio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public int IdReporte { get => idReporte; set => idReporte = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombrePerito { get => nombrePerito; set => nombrePerito = value; }
    }
}
