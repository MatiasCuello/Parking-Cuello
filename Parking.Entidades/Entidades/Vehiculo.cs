
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades.Entidades
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }
        public string Patente { get; set; }
        public DateTime FechaHoraIngreso { get; set; }
        public int TipoVehiculoId { get; set; }
        public int LugarId { get; set; }
        public int SectorId { get; set; }
        public bool Estacionado { get; set; }
        public byte[] RowVersion { get; set; }

        public Sector Sector { get; set; }
        public Lugar Lugar { get; set; }
        public List<DetalleVehiculo> Detalles { get; set; }
        public Vehiculo()
        {
            Detalles = new List<DetalleVehiculo>();
        }
        public TipoVehiculo TipoVehiculo { get; set; }

    }
}
