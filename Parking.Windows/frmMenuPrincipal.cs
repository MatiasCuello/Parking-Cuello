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
            frmVehiculos frm = new frmVehiculos() { Text = "Vehiculos" };
            frm.ShowDialog(this);
        }

        private void ClientesButton_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes() { Text = "Clientes" };
            frm.ShowDialog(this);
        }
    }
}
