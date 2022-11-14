using Parking.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Windows.Helpers
{
    public class HelperGrilla
    {
        public static void LimpiarGrilla(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

        }
        public static DataGridViewRow ConstruirFila(DataGridView dataGrid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGrid);
            return r;
        }

        public static void AgregarFila(DataGridView dataGrid, DataGridViewRow r)
        {
            dataGrid.Rows.Add(r);
        }

        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            switch (obj)
            {
                case TipoVehiculo v:
                    r.Cells[0].Value = v.Descripcion;

                    break;

                case Cliente c:
                    r.Cells[0].Value = c.NombreCompleto;
                    r.Cells[1].Value = c.Direccion;
                    r.Cells[2].Value = c.Telefono;

                    break;
                case Tarifa t:
                    r.Cells[0].Value = t.TipoVehiculo.Descripcion;
                    r.Cells[1].Value = t.Tiempo.Descripcion;
                    r.Cells[2].Value = t.Importe;

                    break;
                case Marca m:
                    r.Cells[0].Value = m.Descripcion;

                    break;
                case Sector s:
                    r.Cells[0].Value = s.Descripcion;
                    r.Cells[1].Value = s.LugaresDisponibles;
                    r.Cells[2].Value = s.LugaresDisponiblesMotos;


                    break;

            }

            r.Tag = obj;

        }

        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }
    }
}
