using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMunicipio.modelo.poco
{
    public class ConductorReporte
    {
        private int idConductor;
        private int idReporte;

        public int IdConductor { get => idConductor; set => idConductor = value; }
        public int IdReporte { get => idReporte; set => idReporte = value; }
    }
}
