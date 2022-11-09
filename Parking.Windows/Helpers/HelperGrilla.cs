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
                case Vehiculo v:
                    r.Cells[0].Value = v.TipoVehiculo;

                    break;

                case Cliente cliente:
                    r.Cells[0].Value = cliente.Nombre;
                    r.Cells[1].Value = cliente.Apellido;
                    r.Cells[2].Value = cliente.Vehiculo.TipoVehiculo;
                    r.Cells[3].Value = cliente.Telefono;

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
