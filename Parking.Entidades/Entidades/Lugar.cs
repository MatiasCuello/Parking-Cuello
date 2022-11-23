using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades.Entidades
{
    public class Lugar
    {
        public int LugarId { get; set; }
        public string Descripcion { get; set; }
        public int SectorId { get; set; }
        public bool Disponible { get; set; }
        public byte[] RowVersion { get; set; }

        public Sector Sector { get; set; }
    }
}
