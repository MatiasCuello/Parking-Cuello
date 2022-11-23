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
        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
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
                    RecargarGrilla();
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

        private void RecargarGrilla()
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


        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                var r = DatosDataGridView.SelectedRows[0];
                Vehiculo v = (Vehiculo)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea eliminar el vehiculo seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (!servicio.EstaRelacionado(v))
                {
                    servicio.Borrar(v.VehiculoId);
                    HelperGrilla.BorrarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Vehiculo eliminado...", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Vehiculo relacionado... Eliminacion denegada", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");

            }
        }

        private void RetiroToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            int registrosAfectados = 0;
            var r = DatosDataGridView.SelectedRows[0];
            Vehiculo vehiculo = (Vehiculo)r.Tag;
            frmVehiculosAE frm = new frmVehiculosAE() { Text = "Editar Vehiculo" };
            frm.SetVehiculo(vehiculo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {

                vehiculo = frm.GetVehiculo();
                if (servicio.Existe(vehiculo))
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Vehiculo repetido...", "ERROR");
                }
                else
                {
                    registrosAfectados = servicio.Editar(vehiculo);
                    if (registrosAfectados == 0)
                    {

                        HelperMensaje.Mensaje(TipoMensaje.WARNING, "No se pudo modificar el vehiculo", "Mensaje");

                    }
                    else
                    {
                        HelperGrilla.SetearFila(r, vehiculo);
                        HelperMensaje.Mensaje(TipoMensaje.OK, "Vehiculo editado", "Mensaje");


                    }
                }

            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");
            }
        }
    }
}
