using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Windows.Helpers
{
    public class HelperForm
    {
        public static void MostrarDatosEnGrilla<T>(DataGridView dataGrid, List<T> lista)
        {
            HelperGrilla.LimpiarGrilla(dataGrid);
            foreach (var obj in lista)
            {
                DataGridViewRow r = HelperGrilla.ConstruirFila(dataGrid);
                HelperGrilla.SetearFila(r, obj);
                HelperGrilla.AgregarFila(dataGrid, r);
            }
        }
    }
}
