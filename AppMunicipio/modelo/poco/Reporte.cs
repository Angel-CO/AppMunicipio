using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMunicipio.modelo.poco
{
    public class Reporte
    {
        private int idReporte;
        private String direccionSiniestro;
        private String estatus;
        private DateTime fechaHora;
        private int idDelegacion;
        private String nombreDelegacion;

        public int IdReporte { get => idReporte; set => idReporte = value; }
        public string DireccionSiniestro { get => direccionSiniestro; set => direccionSiniestro = value; }
        public string Estatus { get => estatus; set => estatus = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public int IdDelegacion { get => idDelegacion; set => idDelegacion = value; }
        public String NombreDelegacion { get => nombreDelegacion; set => nombreDelegacion = value; }
    }

}
