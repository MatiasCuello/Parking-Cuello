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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }
        private ServicioMarcas servicio;
        private List<Marca> lista;
        private void frmMarcas_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {

            frmMarcasAE frm = new frmMarcasAE() { Text = "Nueva Marca" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;

            }

            try
            {
                Marca marca = frm.GetMarca();
                if (servicio.Existe(marca))
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Marca repetida", "ERROR");
                }
                else
                {
                    servicio.Guardar(marca);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Marca agregada", "Mensaje");
                    var r = HelperGrilla.ConstruirFila(DatosDataGridView);
                    HelperGrilla.SetearFila(r, marca);
                    HelperGrilla.AgregarFila(DatosDataGridView, r);

                }

            }
            catch (Exception ex)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, ex.Message, "Error");
            }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Marca marca = (Marca)r.Tag;
            frmMarcasAE frm = new frmMarcasAE() { Text = "Editar Marca" };
            frm.SetMarca(marca);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;

            }

            try
            {
                marca = frm.GetMarca();
                if (servicio.Existe(marca))
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Marca repetida...", "ERROR");
                }
                else
                {
                    servicio.Guardar(marca);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Marca modificada...", "Mensaje");
                    r = HelperGrilla.ConstruirFila(DatosDataGridView);
                    HelperGrilla.SetearFila(r, marca);
                    ActualizarGrilla();

                }

            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");
            }
        }

        private void ActualizarGrilla()
        {
            try
            {
                servicio = new ServicioMarcas();
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
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                var r = DatosDataGridView.SelectedRows[0];
                Marca m = (Marca)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea eliminar la marca seleccionada?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (!servicio.EstaRelacionado(m))
                {
                    servicio.Borrar(m.MarcaId);
                    HelperGrilla.BorrarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Marca eliminada...", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Marca relacionada... Eliminacion denegada", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");

            }
        }
    }
}
