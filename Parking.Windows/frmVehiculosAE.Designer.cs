
namespace Parking.Windows
{
    partial class frmVehiculosAE
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
            this.FechaLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FechaYHoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LugaresComboBox = new System.Windows.Forms.ComboBox();
            this.SectoresComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SectorLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TipoVehiculoLabel = new System.Windows.Forms.Label();
            this.TipoVehiculosComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.DatosVehIngresanteLabel = new System.Windows.Forms.Label();
            this.PatenteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PatenteLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EstacionadoCheckBox = new System.Windows.Forms.CheckBox();
            this.EstacionadoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.FechaLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(520, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 267);
            this.panel1.TabIndex = 217;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.FechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(80, 22);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(0, 16);
            this.FechaLabel.TabIndex = 217;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parking.Windows.Properties.Resources.icons8_car_badge_100;
            this.pictureBox1.Location = new System.Drawing.Point(83, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            // 
            // FechaYHoraDateTimePicker
            // 
            this.FechaYHoraDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.FechaYHoraDateTimePicker.Enabled = false;
            this.FechaYHoraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaYHoraDateTimePicker.Location = new System.Drawing.Point(170, 50);
            this.FechaYHoraDateTimePicker.Name = "FechaYHoraDateTimePicker";
            this.FechaYHoraDateTimePicker.Size = new System.Drawing.Size(298, 20);
            this.FechaYHoraDateTimePicker.TabIndex = 216;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.EstacionadoLabel);
            this.panel2.Controls.Add(this.EstacionadoCheckBox);
            this.panel2.Controls.Add(this.LugaresComboBox);
            this.panel2.Controls.Add(this.SectoresComboBox);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.SectorLabel);
            this.panel2.Controls.Add(this.FechaYHoraDateTimePicker);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.TipoVehiculoLabel);
            this.panel2.Controls.Add(this.TipoVehiculosComboBox);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.DatosVehIngresanteLabel);
            this.panel2.Controls.Add(this.PatenteTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.PatenteLabel);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 267);
            this.panel2.TabIndex = 218;
            // 
            // LugaresComboBox
            // 
            this.LugaresComboBox.Enabled = false;
            this.LugaresComboBox.FormattingEnabled = true;
            this.LugaresComboBox.Location = new System.Drawing.Point(170, 183);
            this.LugaresComboBox.Name = "LugaresComboBox";
            this.LugaresComboBox.Size = new System.Drawing.Size(298, 21);
            this.LugaresComboBox.TabIndex = 221;
            // 
            // SectoresComboBox
            // 
            this.SectoresComboBox.Enabled = false;
            this.SectoresComboBox.FormattingEnabled = true;
            this.SectoresComboBox.Location = new System.Drawing.Point(170, 145);
            this.SectoresComboBox.Name = "SectoresComboBox";
            this.SectoresComboBox.Size = new System.Drawing.Size(298, 21);
            this.SectoresComboBox.TabIndex = 222;
            this.SectoresComboBox.SelectedIndexChanged += new System.EventHandler(this.SectoresComboBox_SelectedIndexChanged);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox9.Image = global::Parking.Windows.Properties.Resources.place_marker_30px;
            this.pictureBox9.Location = new System.Drawing.Point(15, 176);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 29);
            this.pictureBox9.TabIndex = 219;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox5.Image = global::Parking.Windows.Properties.Resources.parking_and_4th_floor_30px;
            this.pictureBox5.Location = new System.Drawing.Point(15, 140);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 29);
            this.pictureBox5.TabIndex = 220;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 217;
            this.label3.Text = "Lugar:";
            // 
            // SectorLabel
            // 
            this.SectorLabel.AutoSize = true;
            this.SectorLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.SectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectorLabel.Location = new System.Drawing.Point(52, 150);
            this.SectorLabel.Name = "SectorLabel";
            this.SectorLabel.Size = new System.Drawing.Size(57, 16);
            this.SectorLabel.TabIndex = 218;
            this.SectorLabel.Text = "Sector:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = global::Parking.Windows.Properties.Resources.tipoveh1;
            this.pictureBox2.Location = new System.Drawing.Point(15, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 211;
            this.pictureBox2.TabStop = false;
            // 
            // TipoVehiculoLabel
            // 
            this.TipoVehiculoLabel.AutoSize = true;
            this.TipoVehiculoLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.TipoVehiculoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoVehiculoLabel.Location = new System.Drawing.Point(49, 118);
            this.TipoVehiculoLabel.Name = "TipoVehiculoLabel";
            this.TipoVehiculoLabel.Size = new System.Drawing.Size(108, 16);
            this.TipoVehiculoLabel.TabIndex = 205;
            this.TipoVehiculoLabel.Text = "Tipo Vehiculo:";
            // 
            // TipoVehiculosComboBox
            // 
            this.TipoVehiculosComboBox.FormattingEnabled = true;
            this.TipoVehiculosComboBox.Location = new System.Drawing.Point(170, 113);
            this.TipoVehiculosComboBox.Name = "TipoVehiculosComboBox";
            this.TipoVehiculosComboBox.Size = new System.Drawing.Size(298, 21);
            this.TipoVehiculosComboBox.TabIndex = 212;
            this.TipoVehiculosComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoVehiculosComboBox_SelectedIndexChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox7.Image = global::Parking.Windows.Properties.Resources.icons8_schedule_30;
            this.pictureBox7.Location = new System.Drawing.Point(15, 37);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 29);
            this.pictureBox7.TabIndex = 209;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox6.Image = global::Parking.Windows.Properties.Resources.icons8_licence_plate_30;
            this.pictureBox6.Location = new System.Drawing.Point(15, 72);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 29);
            this.pictureBox6.TabIndex = 209;
            this.pictureBox6.TabStop = false;
            // 
            // DatosVehIngresanteLabel
            // 
            this.DatosVehIngresanteLabel.AutoSize = true;
            this.DatosVehIngresanteLabel.Font = new System.Drawing.Font("Elephant", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosVehIngresanteLabel.Location = new System.Drawing.Point(48, 3);
            this.DatosVehIngresanteLabel.Name = "DatosVehIngresanteLabel";
            this.DatosVehIngresanteLabel.Size = new System.Drawing.Size(409, 24);
            this.DatosVehIngresanteLabel.TabIndex = 183;
            this.DatosVehIngresanteLabel.Text = "DATOS DEL VEHICULO INGRESANTE";
            // 
            // PatenteTextBox
            // 
            this.PatenteTextBox.Location = new System.Drawing.Point(170, 81);
            this.PatenteTextBox.MaxLength = 100;
            this.PatenteTextBox.Name = "PatenteTextBox";
            this.PatenteTextBox.Size = new System.Drawing.Size(298, 20);
            this.PatenteTextBox.TabIndex = 195;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 204;
            this.label2.Text = "Entrada:";
            // 
            // PatenteLabel
            // 
            this.PatenteLabel.AutoSize = true;
            this.PatenteLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.PatenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatenteLabel.Location = new System.Drawing.Point(52, 81);
            this.PatenteLabel.Name = "PatenteLabel";
            this.PatenteLabel.Size = new System.Drawing.Size(65, 16);
            this.PatenteLabel.TabIndex = 204;
            this.PatenteLabel.Text = "Patente:";
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.White;
            this.OkButton.Image = global::Parking.Windows.Properties.Resources.OK;
            this.OkButton.Location = new System.Drawing.Point(169, 285);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 64);
            this.OkButton.TabIndex = 215;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Image = global::Parking.Windows.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(530, 285);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 64);
            this.CancelButton.TabIndex = 216;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EstacionadoCheckBox
            // 
            this.EstacionadoCheckBox.AutoSize = true;
            this.EstacionadoCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EstacionadoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstacionadoCheckBox.Location = new System.Drawing.Point(170, 227);
            this.EstacionadoCheckBox.Name = "EstacionadoCheckBox";
            this.EstacionadoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstacionadoCheckBox.TabIndex = 223;
            this.EstacionadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // EstacionadoLabel
            // 
            this.EstacionadoLabel.AutoSize = true;
            this.EstacionadoLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.EstacionadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstacionadoLabel.Location = new System.Drawing.Point(52, 225);
            this.EstacionadoLabel.Name = "EstacionadoLabel";
            this.EstacionadoLabel.Size = new System.Drawing.Size(61, 16);
            this.EstacionadoLabel.TabIndex = 224;
            this.EstacionadoLabel.Text = "Estado:";
            // 
            // frmVehiculosAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmVehiculosAE";
            this.Text = "frmVehiculoIngresante";
            this.Load += new System.EventHandler(this.frmVehiculosAE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DatosVehIngresanteLabel;
        private System.Windows.Forms.Label TipoVehiculoLabel;
        private System.Windows.Forms.ComboBox TipoVehiculosComboBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.DateTimePicker FechaYHoraDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox PatenteTextBox;
        private System.Windows.Forms.Label PatenteLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ComboBox LugaresComboBox;
        private System.Windows.Forms.ComboBox SectoresComboBox;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SectorLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label EstacionadoLabel;
        private System.Windows.Forms.CheckBox EstacionadoCheckBox;
    }
}