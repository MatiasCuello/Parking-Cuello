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
    public partial class frmTarifas : Form
    {
        public frmTarifas()
        {
            InitializeComponent();
        }
        private ServicioTarifas servicio;
        private List<Tarifa> lista;
        private void frmTarifas_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    servicio = new ServicioTarifas();
            //    lista = servicio.GetLista();
            //    HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            //}
            //catch (Exception ex)
            //{

            //    throw new Exception(ex.Message);
            //}
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            try
            {
                servicio = new ServicioTarifas();
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            frmTarifasAE frm = new frmTarifasAE() { Text = "Nueva Tarifa" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Tarifa tarifa = frm.GetTarifa();
                if (!servicio.Existe(tarifa))
                {
                    int registrosAfectados = servicio.Agregar(tarifa);
                    if (registrosAfectados == 0)
                    {
                        HelperMensaje.Mensaje(TipoMensaje.WARNING, "No se agregaron registros", "Advertencia");
                        var r = HelperGrilla.ConstruirFila(DatosDataGridView);
                        HelperGrilla.SetearFila(r, tarifa);
                        HelperGrilla.AgregarFila(DatosDataGridView, r);

                    }
                    else
                    {

                        HelperMensaje.Mensaje(TipoMensaje.OK, "Tarifa agregada", "Mensaje");
                        var r = HelperGrilla.ConstruirFila(DatosDataGridView);
                        HelperGrilla.SetearFila(r, tarifa);
                        HelperGrilla.AgregarFila(DatosDataGridView, r);

                    }


                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Tarifa repetida..", "Error");
                }

            }
            catch (Exception ex)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, ex.Message, "Error");
            }
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                var r = DatosDataGridView.SelectedRows[0];
                Tarifa t = (Tarifa)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea eliminar la tarifa seleccionada?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (!servicio.EstaRelacionado(t))
                {
                    servicio.Borrar(t.TarifaId);
                    HelperGrilla.BorrarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Tarifa eliminada...", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Tarifa relacionada... Eliminacion denegada", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");

            }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            int registrosAfectados = 0;
            var r = DatosDataGridView.SelectedRows[0];
            Tarifa tarifa = (Tarifa)r.Tag;
            Tarifa TarifaAux = (Tarifa)tarifa.Clone();
            frmTarifasAE frm = new frmTarifasAE() { Text = "Editar Tarifa" };
            frm.SetTarifa(tarifa);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {

                tarifa = frm.GetTarifa();
                if (servicio.Existe(tarifa))
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Tarifa repetida...", "ERROR");
                }
                else
                {
                    registrosAfectados = servicio.Editar(tarifa);
                    if (registrosAfectados == 0)
                    {

                        HelperMensaje.Mensaje(TipoMensaje.WARNING, "No se pudo modificar la tarifa", "Mensaje");

                    }
                    else
                    {
                        HelperGrilla.SetearFila(r, tarifa);
                        HelperMensaje.Mensaje(TipoMensaje.OK, "Tarifa editada", "Mensaje");


                    }
                }
               
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");
            }
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }
    }
}



