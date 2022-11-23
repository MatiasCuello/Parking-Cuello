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
    public partial class frmLugares : Form
    {
        public frmLugares()
        {
            InitializeComponent();
        }
        private ServicioLugares servicio;
        private List<Lugar> lista;
        private void frmLugares_Load(object sender, EventArgs e)
        {

            try
            {
                servicio = new ServicioLugares();
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
    }
    }

