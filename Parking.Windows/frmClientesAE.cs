using Parking.Entidades.Entidades;
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
    public partial class frmClientesAE : Form
    {
        public frmClientesAE()
        {
            InitializeComponent();
        }
        private Cliente cliente;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombos.CargarDatosComboTiposVehiculos(ref TipoVehiculoComboBox);
            if (cliente != null)
            {
                NombreCompletoTextBox.Text = cliente.NombreCompleto;
                TelefonoTextBox.Text = cliente.Telefono;
                HelperCombos.CargarDatosComboTiposVehiculos(ref TipoVehiculoComboBox);

            }
        }
        private void frmClientesAE_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Cliente GetCliente()
        {
            return cliente;
        }

        private void TipoVehiculoLabel_Click(object sender, EventArgs e)
        {

        }

        private void TipoVehiculoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NombreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
