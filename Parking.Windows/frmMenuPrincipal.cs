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
            frmTarifas frm = new frmTarifas() { Text = "Tarifas" };
            frm.ShowDialog(this);

        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void MarcasButton_Click(object sender, EventArgs e)
        {
            frmMarcas frm = new frmMarcas() { Text = "Marcas" };
            frm.ShowDialog(this);

        }

        private void SectoresButton_Click(object sender, EventArgs e)
        {
            frmSectores frm = new frmSectores() { Text = "Sectores" };
            frm.ShowDialog(this);
        }

        private void RegistradosButton_Click(object sender, EventArgs e)
        {
            frmVehiculosRegistrados frm = new frmVehiculosRegistrados() { Text = "Vehiculos Registrados" };
            frm.ShowDialog(this);
        }

        private void MENU_Click(object sender, EventArgs e)
        {

        }

        private void LugaresButton_Click(object sender, EventArgs e)
        {
            frmLugares frm = new frmLugares() { Text = "Lugares" };
            frm.ShowDialog(this);
        }
    }

}
