using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades.Entidades
{
    public class VehiculoRegistrado
    {
        public int VehiculoRegistradoId { get; set; }
        public int ClienteId { get; set; }
        public int TipoVehiculoId { get; set; }
        public int MarcaId { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public int TarifaId { get; set; }
        public int SectorId { get; set; }
        public bool Estado { get; set; }
        public byte[] RowVersion { get; set; }

        public Cliente Cliente { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }
        public Marca Marca { get; set; }
        public Tarifa Tarifa { get; set; }
        public Sector Sector { get; set; }
    }
}
