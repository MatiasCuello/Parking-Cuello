using Microsoft.VisualBasic;
using Parking.Entidades.Enums;
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
    public partial class frmCobro : Form
    {
        public frmCobro()
        {
            InitializeComponent();
        }
        private decimal monto;
        private decimal importe;
        private FormaDePago formaPago = 0;

        private void frmCobro_Load(object sender, EventArgs e)
        {
            ImporteLabel.Text = monto.ToString("N2");
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RetirarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (formaPago == 0)
            {
                valido = false;
                errorProvider1.SetError(TarjetaButton, "Seleccione una forma de pago para continuar");
            }

            return valido;
        }

        internal void SetImporte(decimal monto)
        {
            this.monto = monto;
        }

        private void EfectivoButton_Click(object sender, EventArgs e)
        {
            formaPago = FormaDePago.Efectivo;
            var importeText = Interaction.InputBox("Ingrese el importe", "Pago en Efectivo", "0", 800, 400);
            decimal importeRecibido;
            if (!decimal.TryParse(importeText, out importeRecibido))
            {
                return;
            }
            else if (importeRecibido <= 0 || importeRecibido < monto)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, "Importe recibido no puede ser inferior al importe a pagar", "Error");
                return;
            }

            RecibidoLabel.Text = importeRecibido.ToString("N2");
            if (importeRecibido >= monto)
            {
                importe = monto;
                VueltoLabel.Text = (importeRecibido - monto).ToString("N2");
            }
            else
            {
                importe = importeRecibido;
            }
        }

        private void TarjetaButton_Click(object sender, EventArgs e)
        {
            formaPago = FormaDePago.Tarjeta;
            RecibidoLabel.Text = monto.ToString();
            importe = decimal.Parse(ImporteLabel.Text);
        }
    }
}
