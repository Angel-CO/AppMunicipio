using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMunicipio.modelo.poco
{
    class VehiculoReporte
    {
        private int idVehiculo;
        private int idReporte;

        public int IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public int IdReporte { get => idReporte; set => idReporte = value; }
    }
}
