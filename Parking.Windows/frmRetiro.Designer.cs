
namespace Parking.Windows
{
    partial class frmRetiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRetiro));
            this.HoraEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaEntradaLabel = new System.Windows.Forms.Label();
            this.HoraSalidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaSalidaLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TarifaLabel = new System.Windows.Forms.Label();
            this.TarifasComboBox = new System.Windows.Forms.ComboBox();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.CantidadHorasTextBox = new System.Windows.Forms.TextBox();
            this.ImporteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaHoraGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoVehiculosComboBox = new System.Windows.Forms.ComboBox();
            this.VehiculoGroupBox = new System.Windows.Forms.GroupBox();
            this.PatenteLabel = new System.Windows.Forms.Label();
            this.PatenteTextBox = new System.Windows.Forms.TextBox();
            this.TarifaGroupBox = new System.Windows.Forms.GroupBox();
            this.PagarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.FechaHoraGroupBox.SuspendLayout();
            this.VehiculoGroupBox.SuspendLayout();
            this.TarifaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HoraEntradaDateTimePicker
            // 
            this.HoraEntradaDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.HoraEntradaDateTimePicker.Enabled = false;
            this.HoraEntradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HoraEntradaDateTimePicker.Location = new System.Drawing.Point(98, 37);
            this.HoraEntradaDateTimePicker.Name = "HoraEntradaDateTimePicker";
            this.HoraEntradaDateTimePicker.Size = new System.Drawing.Size(172, 23);
            this.HoraEntradaDateTimePicker.TabIndex = 219;
            // 
            // FechaEntradaLabel
            // 
            this.FechaEntradaLabel.AutoSize = true;
            this.FechaEntradaLabel.BackColor = System.Drawing.SystemColors.Control;
            this.FechaEntradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaEntradaLabel.Location = new System.Drawing.Point(21, 41);
            this.FechaEntradaLabel.Name = "FechaEntradaLabel";
            this.FechaEntradaLabel.Size = new System.Drawing.Size(66, 16);
            this.FechaEntradaLabel.TabIndex = 217;
            this.FechaEntradaLabel.Text = "Entrada:";
            // 
            // HoraSalidaDateTimePicker
            // 
            this.HoraSalidaDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.HoraSalidaDateTimePicker.Enabled = false;
            this.HoraSalidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HoraSalidaDateTimePicker.Location = new System.Drawing.Point(411, 37);
            this.HoraSalidaDateTimePicker.Name = "HoraSalidaDateTimePicker";
            this.HoraSalidaDateTimePicker.Size = new System.Drawing.Size(178, 23);
            this.HoraSalidaDateTimePicker.TabIndex = 223;
            // 
            // FechaSalidaLabel
            // 
            this.FechaSalidaLabel.AutoSize = true;
            this.FechaSalidaLabel.BackColor = System.Drawing.SystemColors.Control;
            this.FechaSalidaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaSalidaLabel.Location = new System.Drawing.Point(348, 41);
            this.FechaSalidaLabel.Name = "FechaSalidaLabel";
            this.FechaSalidaLabel.Size = new System.Drawing.Size(57, 16);
            this.FechaSalidaLabel.TabIndex = 222;
            this.FechaSalidaLabel.Text = "Salida:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TarifaLabel
            // 
            this.TarifaLabel.AutoSize = true;
            this.TarifaLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TarifaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarifaLabel.Location = new System.Drawing.Point(21, 24);
            this.TarifaLabel.Name = "TarifaLabel";
            this.TarifaLabel.Size = new System.Drawing.Size(53, 16);
            this.TarifaLabel.TabIndex = 222;
            this.TarifaLabel.Text = "Tarifa:";
            // 
            // TarifasComboBox
            // 
            this.TarifasComboBox.FormattingEnabled = true;
            this.TarifasComboBox.Location = new System.Drawing.Point(179, 21);
            this.TarifasComboBox.Name = "TarifasComboBox";
            this.TarifasComboBox.Size = new System.Drawing.Size(410, 24);
            this.TarifasComboBox.TabIndex = 224;
            this.TarifasComboBox.SelectedIndexChanged += new System.EventHandler(this.TarifasComboBox_SelectedIndexChanged);
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(21, 81);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(120, 16);
            this.CantidadLabel.TabIndex = 222;
            this.CantidadLabel.Text = "Cantidad Horas:";
            // 
            // CantidadHorasTextBox
            // 
            this.CantidadHorasTextBox.Enabled = false;
            this.CantidadHorasTextBox.Location = new System.Drawing.Point(179, 77);
            this.CantidadHorasTextBox.Name = "CantidadHorasTextBox";
            this.CantidadHorasTextBox.Size = new System.Drawing.Size(145, 23);
            this.CantidadHorasTextBox.TabIndex = 225;
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.Enabled = false;
            this.ImporteTextBox.Location = new System.Drawing.Point(179, 60);
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.Size = new System.Drawing.Size(145, 23);
            this.ImporteTextBox.TabIndex = 227;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 226;
            this.label2.Text = "Importe:";
            // 
            // FechaHoraGroupBox
            // 
            this.FechaHoraGroupBox.Controls.Add(this.HoraEntradaDateTimePicker);
            this.FechaHoraGroupBox.Controls.Add(this.FechaEntradaLabel);
            this.FechaHoraGroupBox.Controls.Add(this.FechaSalidaLabel);
            this.FechaHoraGroupBox.Controls.Add(this.CantidadHorasTextBox);
            this.FechaHoraGroupBox.Controls.Add(this.HoraSalidaDateTimePicker);
            this.FechaHoraGroupBox.Controls.Add(this.CantidadLabel);
            this.FechaHoraGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaHoraGroupBox.Location = new System.Drawing.Point(13, 130);
            this.FechaHoraGroupBox.Name = "FechaHoraGroupBox";
            this.FechaHoraGroupBox.Size = new System.Drawing.Size(609, 118);
            this.FechaHoraGroupBox.TabIndex = 228;
            this.FechaHoraGroupBox.TabStop = false;
            this.FechaHoraGroupBox.Text = "Fecha y Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 222;
            this.label1.Text = "Tipo Vehiculo:";
            // 
            // TipoVehiculosComboBox
            // 
            this.TipoVehiculosComboBox.Enabled = false;
            this.TipoVehiculosComboBox.FormattingEnabled = true;
            this.TipoVehiculosComboBox.Location = new System.Drawing.Point(179, 20);
            this.TipoVehiculosComboBox.Name = "TipoVehiculosComboBox";
            this.TipoVehiculosComboBox.Size = new System.Drawing.Size(410, 24);
            this.TipoVehiculosComboBox.TabIndex = 224;
            this.TipoVehiculosComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoVehiculosComboBox_SelectedIndexChanged);
            // 
            // VehiculoGroupBox
            // 
            this.VehiculoGroupBox.Controls.Add(this.PatenteLabel);
            this.VehiculoGroupBox.Controls.Add(this.PatenteTextBox);
            this.VehiculoGroupBox.Controls.Add(this.label1);
            this.VehiculoGroupBox.Controls.Add(this.TipoVehiculosComboBox);
            this.VehiculoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiculoGroupBox.Location = new System.Drawing.Point(13, 12);
            this.VehiculoGroupBox.Name = "VehiculoGroupBox";
            this.VehiculoGroupBox.Size = new System.Drawing.Size(609, 100);
            this.VehiculoGroupBox.TabIndex = 229;
            this.VehiculoGroupBox.TabStop = false;
            this.VehiculoGroupBox.Text = "Vehiculo";
            // 
            // PatenteLabel
            // 
            this.PatenteLabel.AutoSize = true;
            this.PatenteLabel.Location = new System.Drawing.Point(23, 64);
            this.PatenteLabel.Name = "PatenteLabel";
            this.PatenteLabel.Size = new System.Drawing.Size(64, 17);
            this.PatenteLabel.TabIndex = 226;
            this.PatenteLabel.Text = "Patente";
            // 
            // PatenteTextBox
            // 
            this.PatenteTextBox.Enabled = false;
            this.PatenteTextBox.Location = new System.Drawing.Point(179, 61);
            this.PatenteTextBox.Name = "PatenteTextBox";
            this.PatenteTextBox.Size = new System.Drawing.Size(100, 23);
            this.PatenteTextBox.TabIndex = 225;
            // 
            // TarifaGroupBox
            // 
            this.TarifaGroupBox.Controls.Add(this.TarifasComboBox);
            this.TarifaGroupBox.Controls.Add(this.TarifaLabel);
            this.TarifaGroupBox.Controls.Add(this.label2);
            this.TarifaGroupBox.Controls.Add(this.ImporteTextBox);
            this.TarifaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarifaGroupBox.Location = new System.Drawing.Point(13, 265);
            this.TarifaGroupBox.Name = "TarifaGroupBox";
            this.TarifaGroupBox.Size = new System.Drawing.Size(609, 106);
            this.TarifaGroupBox.TabIndex = 230;
            this.TarifaGroupBox.TabStop = false;
            this.TarifaGroupBox.Text = "Tarifa";
            // 
            // PagarButton
            // 
            this.PagarButton.BackColor = System.Drawing.Color.White;
            this.PagarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagarButton.Image = ((System.Drawing.Image)(resources.GetObject("PagarButton.Image")));
            this.PagarButton.Location = new System.Drawing.Point(93, 385);
            this.PagarButton.Name = "PagarButton";
            this.PagarButton.Size = new System.Drawing.Size(122, 64);
            this.PagarButton.TabIndex = 220;
            this.PagarButton.Text = "Pagar";
            this.PagarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PagarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PagarButton.UseVisualStyleBackColor = false;
            this.PagarButton.Click += new System.EventHandler(this.PagarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.White;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButton.Image")));
            this.CancelarButton.Location = new System.Drawing.Point(433, 385);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(122, 64);
            this.CancelarButton.TabIndex = 221;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // frmRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.ControlBox = false;
            this.Controls.Add(this.TarifaGroupBox);
            this.Controls.Add(this.VehiculoGroupBox);
            this.Controls.Add(this.FechaHoraGroupBox);
            this.Controls.Add(this.PagarButton);
            this.Controls.Add(this.CancelarButton);
            this.Name = "frmRetiro";
            this.Text = "frmRetiro";
            this.Load += new System.EventHandler(this.frmRetiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.FechaHoraGroupBox.ResumeLayout(false);
            this.FechaHoraGroupBox.PerformLayout();
            this.VehiculoGroupBox.ResumeLayout(false);
            this.VehiculoGroupBox.PerformLayout();
            this.TarifaGroupBox.ResumeLayout(false);
            this.TarifaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker HoraEntradaDateTimePicker;
        private System.Windows.Forms.Label FechaEntradaLabel;
        private System.Windows.Forms.Button PagarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.DateTimePicker HoraSalidaDateTimePicker;
        private System.Windows.Forms.Label FechaSalidaLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox TarifasComboBox;
        private System.Windows.Forms.Label TarifaLabel;
        private System.Windows.Forms.TextBox CantidadHorasTextBox;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.TextBox ImporteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox VehiculoGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TipoVehiculosComboBox;
        private System.Windows.Forms.GroupBox FechaHoraGroupBox;
        private System.Windows.Forms.Label PatenteLabel;
        private System.Windows.Forms.TextBox PatenteTextBox;
        private System.Windows.Forms.GroupBox TarifaGroupBox;
    }
}