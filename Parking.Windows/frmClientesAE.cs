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



        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cliente == null)
                {
                    cliente = new Cliente();
                }

                cliente.NombreCompleto = NombreCompletoTextBox.Text;
                cliente.Telefono = TelefonoTextBox.Text;
                cliente.Direccion = DireccionTextBox.Text;
                cliente.TipoVehiculoId = (int)TipoVehiculoComboBox.SelectedValue;
          
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(NombreCompletoTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(NombreCompletoTextBox, "El nombre del cliente es requerido");
            }

            if (string.IsNullOrEmpty(DireccionTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(DireccionTextBox, "La dirección del cliente es obligatoria");
            }

            if (string.IsNullOrEmpty(TelefonoTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(TelefonoTextBox, "El Telefono del cliente es requerido");
            }

            if (TipoVehiculoComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TipoVehiculoComboBox, "Debe seleccionar un tipo de vehiculo");
            }


            return valido;
        }

        private void NombreCompletoLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }

