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
    public partial class frmSectores : Form
    {
        public frmSectores()
        {
            InitializeComponent();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private ServicioSectores servicio;
        private List<Sector> lista;
        private void frmSectores_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioSectores();
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        }
    }
