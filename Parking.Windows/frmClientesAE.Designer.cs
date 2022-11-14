
namespace Parking.Windows
{
    partial class frmClientesAE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DatosClientesLabel = new System.Windows.Forms.Label();
            this.NombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.NombreCompletoLabel = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.DireccionLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(518, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 165);
            this.panel1.TabIndex = 213;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parking.Windows.Properties.Resources.cliente100px;
            this.pictureBox1.Location = new System.Drawing.Point(73, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DatosClientesLabel
            // 
            this.DatosClientesLabel.AutoSize = true;
            this.DatosClientesLabel.Font = new System.Drawing.Font("Elephant", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosClientesLabel.Location = new System.Drawing.Point(134, 14);
            this.DatosClientesLabel.Name = "DatosClientesLabel";
            this.DatosClientesLabel.Size = new System.Drawing.Size(242, 24);
            this.DatosClientesLabel.TabIndex = 183;
            this.DatosClientesLabel.Text = "DATOS DEL CLIENTE";
            this.DatosClientesLabel.Click += new System.EventHandler(this.DatosClientesLabel_Click);
            // 
            // NombreCompletoTextBox
            // 
            this.NombreCompletoTextBox.Location = new System.Drawing.Point(188, 52);
            this.NombreCompletoTextBox.MaxLength = 100;
            this.NombreCompletoTextBox.Name = "NombreCompletoTextBox";
            this.NombreCompletoTextBox.Size = new System.Drawing.Size(298, 20);
            this.NombreCompletoTextBox.TabIndex = 195;
            // 
            // NombreCompletoLabel
            // 
            this.NombreCompletoLabel.AutoSize = true;
            this.NombreCompletoLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.NombreCompletoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCompletoLabel.Location = new System.Drawing.Point(47, 56);
            this.NombreCompletoLabel.Name = "NombreCompletoLabel";
            this.NombreCompletoLabel.Size = new System.Drawing.Size(137, 16);
            this.NombreCompletoLabel.TabIndex = 205;
            this.NombreCompletoLabel.Text = "Nombre Completo:";
            this.NombreCompletoLabel.Click += new System.EventHandler(this.NombreCompletoLabel_Click);
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.TelefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.Location = new System.Drawing.Point(47, 129);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(74, 16);
            this.TelefonoLabel.TabIndex = 204;
            this.TelefonoLabel.Text = "Telefono:";
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(188, 128);
            this.TelefonoTextBox.MaxLength = 100;
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(298, 20);
            this.TelefonoTextBox.TabIndex = 198;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.DatosClientesLabel);
            this.panel2.Controls.Add(this.DireccionTextBox);
            this.panel2.Controls.Add(this.NombreCompletoTextBox);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.TelefonoTextBox);
            this.panel2.Controls.Add(this.DireccionLabel);
            this.panel2.Controls.Add(this.NombreCompletoLabel);
            this.panel2.Controls.Add(this.TelefonoLabel);
            this.panel2.Location = new System.Drawing.Point(10, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 165);
            this.panel2.TabIndex = 214;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox8.Image = global::Parking.Windows.Properties.Resources.telefono;
            this.pictureBox8.Location = new System.Drawing.Point(15, 116);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 29);
            this.pictureBox8.TabIndex = 209;
            this.pictureBox8.TabStop = false;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(188, 90);
            this.DireccionTextBox.MaxLength = 100;
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(298, 20);
            this.DireccionTextBox.TabIndex = 195;
            this.DireccionTextBox.TextChanged += new System.EventHandler(this.DireccionTextBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = global::Parking.Windows.Properties.Resources.ubicacion;
            this.pictureBox2.Location = new System.Drawing.Point(15, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.TabIndex = 211;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = global::Parking.Windows.Properties.Resources.nombre;
            this.pictureBox6.Location = new System.Drawing.Point(15, 43);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 29);
            this.pictureBox6.TabIndex = 211;
            this.pictureBox6.TabStop = false;
            // 
            // DireccionLabel
            // 
            this.DireccionLabel.AutoSize = true;
            this.DireccionLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.DireccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionLabel.Location = new System.Drawing.Point(49, 91);
            this.DireccionLabel.Name = "DireccionLabel";
            this.DireccionLabel.Size = new System.Drawing.Size(78, 16);
            this.DireccionLabel.TabIndex = 205;
            this.DireccionLabel.Text = "Direccion:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.White;
            this.OkButton.Image = global::Parking.Windows.Properties.Resources.OK;
            this.OkButton.Location = new System.Drawing.Point(148, 185);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 64);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Image = global::Parking.Windows.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(518, 185);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 64);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // frmClientesAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.ControlBox = false;
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(800, 300);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "frmClientesAE";
            this.Text = "frmClientesAE";
            this.Load += new System.EventHandler(this.frmClientesAE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DatosClientesLabel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox NombreCompletoTextBox;
        private System.Windows.Forms.Label NombreCompletoLabel;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DireccionLabel;
    }
}