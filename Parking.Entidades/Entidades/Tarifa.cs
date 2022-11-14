using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades.Entidades
{
    public class Tarifa:ICloneable
    {
        public int TarifaId { get; set; }
        public int TipoVehiculoId { get; set; }
        public int TiempoId { get; set; }
        public decimal Importe { get; set; }
        public byte[] RowVersion { get; set; }

        public TipoVehiculo TipoVehiculo { get; set; }
        public Tiempo Tiempo { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
