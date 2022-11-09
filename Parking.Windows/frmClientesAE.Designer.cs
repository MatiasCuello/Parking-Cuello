
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.TipoVehiculoComboBox = new System.Windows.Forms.ComboBox();
            this.NombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.TipoVehiculoLabel = new System.Windows.Forms.Label();
            this.NombreCompletoLabel = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DatosClientesLabel);
            this.panel1.Location = new System.Drawing.Point(518, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 165);
            this.panel1.TabIndex = 213;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(85, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            // 
            // DatosClientesLabel
            // 
            this.DatosClientesLabel.AutoSize = true;
            this.DatosClientesLabel.Font = new System.Drawing.Font("Elephant", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosClientesLabel.Location = new System.Drawing.Point(6, 23);
            this.DatosClientesLabel.Name = "DatosClientesLabel";
            this.DatosClientesLabel.Size = new System.Drawing.Size(242, 24);
            this.DatosClientesLabel.TabIndex = 183;
            this.DatosClientesLabel.Text = "DATOS DEL CLIENTE";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Image = global::Parking.Windows.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(449, 185);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 64);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TipoVehiculoComboBox
            // 
            this.TipoVehiculoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoVehiculoComboBox.FormattingEnabled = true;
            this.TipoVehiculoComboBox.Location = new System.Drawing.Point(188, 78);
            this.TipoVehiculoComboBox.Name = "TipoVehiculoComboBox";
            this.TipoVehiculoComboBox.Size = new System.Drawing.Size(298, 21);
            this.TipoVehiculoComboBox.TabIndex = 197;
            this.TipoVehiculoComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoVehiculoComboBox_SelectedIndexChanged);
            // 
            // NombreCompletoTextBox
            // 
            this.NombreCompletoTextBox.Location = new System.Drawing.Point(188, 37);
            this.NombreCompletoTextBox.MaxLength = 100;
            this.NombreCompletoTextBox.Name = "NombreCompletoTextBox";
            this.NombreCompletoTextBox.Size = new System.Drawing.Size(298, 20);
            this.NombreCompletoTextBox.TabIndex = 195;
            // 
            // TipoVehiculoLabel
            // 
            this.TipoVehiculoLabel.AutoSize = true;
            this.TipoVehiculoLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.TipoVehiculoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoVehiculoLabel.Location = new System.Drawing.Point(49, 77);
            this.TipoVehiculoLabel.Name = "TipoVehiculoLabel";
            this.TipoVehiculoLabel.Size = new System.Drawing.Size(108, 16);
            this.TipoVehiculoLabel.TabIndex = 202;
            this.TipoVehiculoLabel.Text = "Tipo Vehiculo:";
            this.TipoVehiculoLabel.Click += new System.EventHandler(this.TipoVehiculoLabel_Click);
            // 
            // NombreCompletoLabel
            // 
            this.NombreCompletoLabel.AutoSize = true;
            this.NombreCompletoLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.NombreCompletoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCompletoLabel.Location = new System.Drawing.Point(49, 38);
            this.NombreCompletoLabel.Name = "NombreCompletoLabel";
            this.NombreCompletoLabel.Size = new System.Drawing.Size(137, 16);
            this.NombreCompletoLabel.TabIndex = 205;
            this.NombreCompletoLabel.Text = "Nombre Completo:";
            this.NombreCompletoLabel.Click += new System.EventHandler(this.NombreLabel_Click);
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.TelefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.Location = new System.Drawing.Point(47, 112);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(74, 16);
            this.TelefonoLabel.TabIndex = 204;
            this.TelefonoLabel.Text = "Telefono:";
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(188, 111);
            this.TelefonoTextBox.MaxLength = 100;
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(298, 20);
            this.TelefonoTextBox.TabIndex = 198;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.NombreCompletoTextBox);
            this.panel2.Controls.Add(this.TipoVehiculoComboBox);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.TelefonoTextBox);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.NombreCompletoLabel);
            this.panel2.Controls.Add(this.TipoVehiculoLabel);
            this.panel2.Controls.Add(this.TelefonoLabel);
            this.panel2.Location = new System.Drawing.Point(10, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 165);
            this.panel2.TabIndex = 214;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox8.Location = new System.Drawing.Point(15, 99);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 29);
            this.pictureBox8.TabIndex = 209;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox6.Location = new System.Drawing.Point(15, 29);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 29);
            this.pictureBox6.TabIndex = 211;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox7.Location = new System.Drawing.Point(15, 64);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 29);
            this.pictureBox7.TabIndex = 210;
            this.pictureBox7.TabStop = false;
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
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.Name = "frmClientesAE";
            this.Text = "frmClientesAE";
            this.Load += new System.EventHandler(this.frmClientesAE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DatosClientesLabel;
        private System.Windows.Forms.ComboBox TipoVehiculoComboBox;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox NombreCompletoTextBox;
        private System.Windows.Forms.Label TipoVehiculoLabel;
        private System.Windows.Forms.Label NombreCompletoLabel;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}