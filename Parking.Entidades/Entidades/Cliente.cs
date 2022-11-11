using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public int TipoVehiculoId { get; set; }
        public string Telefono { get; set; }

        public TipoVehiculo TipoVehiculo { get; set; }

    }
}
