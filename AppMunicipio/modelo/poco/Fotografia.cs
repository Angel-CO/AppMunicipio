using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMunicipio.modelo.poco
{
    public class Fotografia
    {
        private int idFoto;
        private byte[] foto;
        private int idReporte;

        public int IdFoto { get => idFoto; set => idFoto = value; }
        public byte[] Foto { get => foto; set => foto = value; }
        public int IdReporte { get => idReporte; set => idReporte = value; }
    }
}
