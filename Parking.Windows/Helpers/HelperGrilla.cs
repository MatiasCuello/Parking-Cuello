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
                case TipoVehiculo tv:
                    r.Cells[0].Value = tv.Descripcion;

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


                    break;
                case Lugar l:
                    r.Cells[0].Value = l.Descripcion;
                    r.Cells[1].Value = l.Sector.Descripcion;
                    r.Cells[2].Value = l.Disponible.ToString();

                    break;

                case Vehiculo v:
                    r.Cells[0].Value = v.FechaHoraIngreso;
                    r.Cells[1].Value = v.Patente;
                    r.Cells[2].Value = v.TipoVehiculo.Descripcion;
                    r.Cells[3].Value = v.Sector.Descripcion;
                    r.Cells[4].Value = v.Lugar.Descripcion;
                    r.Cells[5].Value = v.Estacionado;


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
