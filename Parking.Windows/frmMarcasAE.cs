using Parking.Entidades.Entidades;
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
    public partial class frmMarcasAE : Form
    {
        public frmMarcasAE()
        {
            InitializeComponent();
        }
        private Marca marca;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Marca GetMarca()
        {
            return marca;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (marca == null)
                {
                    marca = new Marca();
                }

                marca.Descripcion = DescripcionTextBox.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(DescripcionTextBox, "La descripcion es requerida");
            }


            return valido;
        }

        public void SetMarca(Marca marca)
        {
            this.marca = marca;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (marca != null)
            {
                DescripcionTextBox.Text = marca.Descripcion;

            }
        }
        private void frmMarcasAE_Load(object sender, EventArgs e)
        {

        }
    }
}

