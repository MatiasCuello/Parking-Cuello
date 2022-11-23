using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades.Entidades
{
    public class DetalleVehiculo
    {
        public int DetalleVehiculoId { get; set; }
        public int VehiculoId { get; set; }
        public int TiempoId { get; set; }
        public int TarifaId { get; set; }
        public DateTime FechaHoraEgreso { get; set; }
        public decimal ImporteAbonado { get; set; }

        
        public Tarifa Tarifa { get; set; }
        public Tiempo Tiempo { get; set; }
      
    }
}
