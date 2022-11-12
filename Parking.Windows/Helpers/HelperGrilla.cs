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
                case Tarifa tarifa:

                    r.Cells[0].Value = tarifa.TipoVehiculo.Descripcion;
                    r.Cells[1].Value = tarifa.TiempoId;
                    r.Cells[2].Value = tarifa.Importe;

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
