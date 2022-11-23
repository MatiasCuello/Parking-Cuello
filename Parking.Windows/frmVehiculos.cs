using Parking.Entidades.Entidades;
using Parking.Servicios.Servicios;
using Parking.Windows.Helpers;
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
    public partial class frmVehiculosRegistrados : Form
    {
        public frmVehiculosRegistrados()
        {
            InitializeComponent();
        }
        private ServicioVehiculos servicio;
        private List<Vehiculo> lista;
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {

            frmVehiculosAE frm = new frmVehiculosAE() { Text = "Nueva Vehiculo Ingresante" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Vehiculo vehiculo = frm.GetVehiculo();
                if (!servicio.Existe(vehiculo))
                {
                    int registrosAfectados = servicio.Agregar(vehiculo);
                    //RecargarGrilla();
                    if (registrosAfectados == 0)
                    {
                        HelperMensaje.Mensaje(TipoMensaje.WARNING, "No se agregaron registros", "Advertencia");
                        var r = HelperGrilla.ConstruirFila(DatosDataGridView);
                        HelperGrilla.SetearFila(r, vehiculo);
                        HelperGrilla.AgregarFila(DatosDataGridView, r);

                    }
                    else
                    {

                        HelperMensaje.Mensaje(TipoMensaje.OK, "Registro Agregado", "Mensaje");
                        var r = HelperGrilla.ConstruirFila(DatosDataGridView);
                        HelperGrilla.SetearFila(r, vehiculo);
                        HelperGrilla.AgregarFila(DatosDataGridView, r);

                    }


                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Registro repetido..", "Error");
                }

            }
            catch (Exception ex)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, ex.Message, "Error");
            }
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {

            try
            {
                servicio = new ServicioVehiculos();
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        Vehiculo vehiculo;
        private void DatosDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var r = DatosDataGridView.SelectedRows[0];
            vehiculo = r.Tag as Vehiculo;
            if (vehiculo.Estacionado == true)
            {
                TarifaToolStripButton.Enabled = true;
            }
            else
            {
                TarifaToolStripButton.Enabled = false;
            }
        }
    }
}
