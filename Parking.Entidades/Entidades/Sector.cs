using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades.Entidades
{
    public class Sector
    {
        public int SectorId { get; set; }
        public string Descripcion { get; set; }
        public int LugaresDisponibles { get; set; }
        public int LugaresDisponiblesMotos { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
