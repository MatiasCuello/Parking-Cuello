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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int VehiculoId { get; set; }
        public string Telefono { get; set; }

        public Vehiculo Vehiculo { get; set; }

    }
}
