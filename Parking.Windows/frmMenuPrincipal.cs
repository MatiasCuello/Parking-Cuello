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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void VehiculoButton_Click(object sender, EventArgs e)
        {
            frmTiposVehiculos frm = new frmTiposVehiculos() { Text = "Tipos de Vehiculos" };
            frm.ShowDialog(this);


        }

        private void ClientesButton_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes() { Text = "Clientes" };
            frm.ShowDialog(this);


        }

        private void TarifasButton_Click(object sender, EventArgs e)
        {
            frmTarifas frm = new frmTarifas() { Text = "Tabla Tarifaria" };
            frm.ShowDialog(this);

        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenuPrincipal_Click(object sender, EventArgs e)
        {

        }


    }

}
