using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades.Entidades
{
    public class Marca:ICloneable
    {
        public int MarcaId { get; set; }
        public string Descripcion { get; set; }
        public byte[] RowVersion { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
