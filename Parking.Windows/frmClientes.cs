﻿using Parking.Entidades.Entidades;
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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private ServicioClientes servicio;
        private List<Cliente> lista;
        private void frmClientes_Load(object sender, EventArgs e)
        {

            try
            {
                servicio = new ServicioClientes();
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            frmClientesAE frm = new frmClientesAE() { Text = "Nuevo Cliente" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;

            }

            try
            {
                Cliente cliente = frm.GetCliente();
                if (servicio.Existe(cliente))
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Cliente repetido", "ERROR");
                }
                else
                {
                    servicio.Guardar(cliente);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Cliente agregado", "Mensaje");
                    var r = HelperGrilla.ConstruirFila(DatosDataGridView);
                    HelperGrilla.SetearFila(r, cliente);
                    HelperGrilla.AgregarFila(DatosDataGridView, r);
                }

            }
            catch (Exception ex)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, ex.Message, "Error");
            }
        }





    }
}

