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
    public partial class frmTarifasAE : Form
    {
        public frmTarifasAE()
        {
            InitializeComponent();
        }
        private Tarifa tarifa;
        public Tarifa GetTarifa()
        {
            return tarifa;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            HelperCombos.CargarDatosComboTiposVehiculos(ref TipoVehiculosComboBox);
            HelperCombos.CargarDatosComboTiempos(ref TiempoComboBox);
            if (tarifa != null)
            {
                TipoVehiculosComboBox.SelectedValue = tarifa.TipoVehiculoId;
                TiempoComboBox.SelectedValue = tarifa.TiempoId;
                ImporteTextBox.Text = tarifa.Importe.ToString();
            }
        }
        private void frmTarifasAE_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tarifa == null)
                {
                    tarifa = new Tarifa();
                }

                tarifa.TipoVehiculoId = (int)TipoVehiculosComboBox.SelectedValue;
                tarifa.TipoVehiculo = (TipoVehiculo)TipoVehiculosComboBox.SelectedItem;
                tarifa.TiempoId = (int)TiempoComboBox.SelectedValue;
                tarifa.Tiempo = (Tiempo)TiempoComboBox.SelectedItem;
                tarifa.Importe = decimal.Parse(ImporteTextBox.Text);
                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (TipoVehiculosComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TipoVehiculosComboBox, "Debe seleccionar un tipo de vehiculo");
            }
            if (TiempoComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TiempoComboBox, "Debe seleccionar una cantidad de tiempo");
            }
            if (string.IsNullOrEmpty(ImporteTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(ImporteTextBox, "El importe de la tarifa es requerido");
            }


            return valido;
        }

        internal void SetTarifa(Tarifa tarifa)
        {
            this.tarifa = tarifa;
        }
    }
}
