using Parking.Entidades.Entidades;
using Parking.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Windows
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
        }
        private ServicioVehiculos servicio;
        private List<Vehiculo> lista;
        private void frmVehiculos_Load(object sender, EventArgs e)
        {

            servicio = new ServicioVehiculos();
            try
            {
                lista = servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var vehiculo in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, vehiculo);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Vehiculo vehiculo)
        {
            r.Cells[cmnVehiculo.Index].Value = vehiculo.TipoVehiculo;
            r.Cells[cmnPatente.Index].Value = vehiculo.Patente;

            r.Tag = vehiculo;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }
    }
}

