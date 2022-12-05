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
    public partial class frmRetiro : Form
    {
        public frmRetiro()
        {
            InitializeComponent();
        }
        private Vehiculo vehiculo;
        TipoVehiculo tipoVehiculo;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombos.CargarDatosComboTiposVehiculos(ref TipoVehiculosComboBox);
            if (vehiculo != null)
            {
                HoraEntradaDateTimePicker.Value = vehiculo.FechaHoraIngreso;
                TipoVehiculosComboBox.SelectedValue = vehiculo.TipoVehiculoId;
                HelperCombos.CargarDatosComboTarifas(ref TarifasComboBox, vehiculo.TipoVehiculo);
                DateTime entrada = HoraEntradaDateTimePicker.Value;
                var horas = ((ushort)(DateTime.Now - entrada).TotalHours).ToString();
                CantidadHorasTextBox.Text = horas.ToString();

            }
        }


        private void VolverButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void SetVehiculo(Vehiculo v)
        {
            vehiculo = v;
        }

        private void frmRetiro_Load(object sender, EventArgs e)
        {

        }

        private void TipoVehiculosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoVehiculosComboBox.SelectedIndex > 0)
            {
                tipoVehiculo = (TipoVehiculo)TipoVehiculosComboBox.SelectedItem;
                HelperCombos.CargarDatosComboTarifas(ref TarifasComboBox, tipoVehiculo);
                PatenteTextBox.Text = vehiculo.Patente;
            }
            else
            {
                TarifasComboBox.DataSource = null;

            }
        }
        private void PagarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
                frmCobro frm = new frmCobro() { Text = "Cobro de Tarifa" };
                frm.SetImporte(tarifa.Importe);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (TarifasComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TarifasComboBox, "Debe seleccionar una tarifa");
            }

            return valido;
        }
        Tarifa tarifa;
        private void TarifasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (TarifasComboBox.SelectedIndex > 0)
            {
                tarifa = (Tarifa)TarifasComboBox.SelectedItem;
                ImporteTextBox.Text = tarifa.Importe.ToString("N2");
            }
            else
            {
                TarifasComboBox.DataSource = null;

            }
        }

       
    }
}
