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
    public partial class frmVehiculosAE : Form
    {
        public frmVehiculosAE()
        {
            InitializeComponent();
        }
        private Vehiculo vehiculo;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Vehiculo GetVehiculo()
        {
            return vehiculo;
        }

        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);

            HelperCombos.CargarDatosComboSectores(ref SectoresComboBox);
            HelperCombos.CargarDatosComboTiposVehiculos(ref TipoVehiculosComboBox);
            if (vehiculo != null)
            {
                FechaYHoraDateTimePicker.Value = vehiculo.FechaHoraIngreso;
                PatenteTextBox.Text = vehiculo.Patente;
                TipoVehiculosComboBox.SelectedValue = vehiculo.TipoVehiculoId;
                SectoresComboBox.SelectedValue = vehiculo.SectorId;
                LugaresComboBox.SelectedValue = vehiculo.LugarId;
                EstacionadoCheckBox.Checked = vehiculo.Estacionado;
               
            }
        }
        private void TipoVehiculosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoVehiculosComboBox.SelectedIndex == 0)
            {
                SectoresComboBox.Enabled = false;
                LugaresComboBox.Enabled = false;
            }
            else
            {
                SectoresComboBox.Enabled = true;
                if (TipoVehiculosComboBox.SelectedIndex > 3 && TipoVehiculosComboBox.SelectedIndex < 5)
                {
                    SectoresComboBox.SelectedIndex = 6;
                    SectoresComboBox.Enabled = false;
                }
                else  
                {
                    if (SectoresComboBox.SelectedIndex == 6)
                    {
                        LugaresComboBox.Enabled = false;
                    }

                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (vehiculo == null)
                {
                    vehiculo = new Vehiculo();
                }

                vehiculo.FechaHoraIngreso = FechaYHoraDateTimePicker.Value;
                vehiculo.Patente = PatenteTextBox.Text;
                vehiculo.TipoVehiculoId = (int)TipoVehiculosComboBox.SelectedValue;
                vehiculo.TipoVehiculo = (TipoVehiculo)TipoVehiculosComboBox.SelectedItem;
                vehiculo.SectorId = (int)SectoresComboBox.SelectedValue;
                vehiculo.Sector = (Sector)SectoresComboBox.SelectedItem;
                vehiculo.LugarId = (int)LugaresComboBox.SelectedValue;
                vehiculo.Lugar = (Lugar)LugaresComboBox.SelectedItem;
                vehiculo.Estacionado = EstacionadoCheckBox.Checked;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(PatenteTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(PatenteTextBox, "La patente del vehiculo es requerida");
            }

            if (TipoVehiculosComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TipoVehiculosComboBox, "Debe seleccionar un tipo de vehiculo");
            }
            if (SectoresComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(SectoresComboBox, "Debe seleccionar un sector");
            }
            if (LugaresComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(LugaresComboBox, "Debe seleccionar un lugar");
            }

            return valido;
        }

        internal void SetVehiculo(Vehiculo vehiculo)
        {
            this.vehiculo = vehiculo;
        }


        private void frmVehiculosAE_Load(object sender, EventArgs e)
        {

        }
        Sector sector;
        Lugar lugar;
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

       
    }
}
