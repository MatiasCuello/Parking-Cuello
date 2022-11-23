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
    public partial class frmSeleccionarUbicacion : Form
    {
        public frmSeleccionarUbicacion()
        {
            InitializeComponent();
        }
        private Sector sector;
        private ServicioSectores servicio;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioSectores();
            HelperCombos.CargarDatosComboSectores(ref SectoresComboBox);
            
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void SectoresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (SectoresComboBox.SelectedIndex > 0)
            {
                sector = (Sector)SectoresComboBox.SelectedItem;

                HelperCombos.CargarDatosComboLugares(ref LugaresComboBox, sector);
                LugaresComboBox.Enabled = true;
            }
            else
            {
                LugaresComboBox.DataSource = null;
                LugaresComboBox.Enabled = false;
            }
        }

        public Sector GetSector()
        {
            return sector;
        }

        private void frmSeleccionarUbicacion_Load(object sender, EventArgs e)
        {

        }

        private void ContinuarButton_Click(object sender, EventArgs e)
        {
            frmSeleccionarTarifa frm = new frmSeleccionarTarifa();
            frm.ShowDialog(this);
        }
    }
    
}
