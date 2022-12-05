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
    public partial class DetalleVehiculo : Form
    {
        public DetalleVehiculo()
        {
            InitializeComponent();
        }
        private Tarifa tarifa;
        private ServicioTarifas servicio;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioTarifas();
            HelperCombos.CargarDatosComboTarifas(ref TarifasComboBox,null);
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TarifasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (TarifasComboBox.SelectedIndex > 0)
            {
                tarifa = (Tarifa)TarifasComboBox.SelectedItem;

                ImporteTextBox.Text = tarifa.Importe.ToString("C");
                //ImporteTextBox.Enabled = true;
            }
            else
            {
                ImporteTextBox.Text = "";
            }

        }

    
        private void frmSeleccionarTarifa_Load(object sender, EventArgs e)
        {

        }

        private void ContinuarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            return true;
        }
    
    }
}
