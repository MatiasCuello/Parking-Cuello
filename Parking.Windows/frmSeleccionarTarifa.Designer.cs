
namespace Parking.Windows
{
    partial class frmSeleccionarTarifa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ImporteTextBox = new System.Windows.Forms.TextBox();
            this.TarifasComboBox = new System.Windows.Forms.ComboBox();
            this.DatosUbicacionLabel = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TarifaLabel = new System.Windows.Forms.Label();
            this.ContinuarButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.FechaLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(519, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 167);
            this.panel1.TabIndex = 224;
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
            this.pictureBox1.Image = global::Parking.Windows.Properties.Resources.sell_property_100px;
            this.pictureBox1.Location = new System.Drawing.Point(70, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.ImporteTextBox);
            this.panel2.Controls.Add(this.TarifasComboBox);
            this.panel2.Controls.Add(this.DatosUbicacionLabel);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TarifaLabel);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 167);
            this.panel2.TabIndex = 225;
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.Enabled = false;
            this.ImporteTextBox.Location = new System.Drawing.Point(170, 124);
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.Size = new System.Drawing.Size(298, 20);
            this.ImporteTextBox.TabIndex = 213;
            // 
            // TarifasComboBox
            // 
            this.TarifasComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.TarifasComboBox.FormattingEnabled = true;
            this.TarifasComboBox.Location = new System.Drawing.Point(170, 65);
            this.TarifasComboBox.Name = "TarifasComboBox";
            this.TarifasComboBox.Size = new System.Drawing.Size(298, 21);
            this.TarifasComboBox.TabIndex = 212;
            this.TarifasComboBox.SelectedIndexChanged += new System.EventHandler(this.TarifasComboBox_SelectedIndexChanged);
            // 
            // DatosUbicacionLabel
            // 
            this.DatosUbicacionLabel.AutoSize = true;
            this.DatosUbicacionLabel.Font = new System.Drawing.Font("Elephant", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosUbicacionLabel.Location = new System.Drawing.Point(104, 14);
            this.DatosUbicacionLabel.Name = "DatosUbicacionLabel";
            this.DatosUbicacionLabel.Size = new System.Drawing.Size(265, 24);
            this.DatosUbicacionLabel.TabIndex = 183;
            this.DatosUbicacionLabel.Text = "TARIFA DEL VEHICULO";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox9.Image = global::Parking.Windows.Properties.Resources.icons8_dollar_coin_30;
            this.pictureBox9.Location = new System.Drawing.Point(15, 112);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 29);
            this.pictureBox9.TabIndex = 211;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox5.Image = global::Parking.Windows.Properties.Resources.purchase_order_30px;
            this.pictureBox5.Location = new System.Drawing.Point(15, 60);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 29);
            this.pictureBox5.TabIndex = 211;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 205;
            this.label3.Text = "Importe:";
            // 
            // TarifaLabel
            // 
            this.TarifaLabel.AutoSize = true;
            this.TarifaLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.TarifaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarifaLabel.Location = new System.Drawing.Point(52, 70);
            this.TarifaLabel.Name = "TarifaLabel";
            this.TarifaLabel.Size = new System.Drawing.Size(53, 16);
            this.TarifaLabel.TabIndex = 205;
            this.TarifaLabel.Text = "Tarifa:";
            // 
            // ContinuarButton
            // 
            this.ContinuarButton.BackColor = System.Drawing.Color.White;
            this.ContinuarButton.Image = global::Parking.Windows.Properties.Resources.OK;
            this.ContinuarButton.Location = new System.Drawing.Point(168, 185);
            this.ContinuarButton.Name = "ContinuarButton";
            this.ContinuarButton.Size = new System.Drawing.Size(94, 64);
            this.ContinuarButton.TabIndex = 222;
            this.ContinuarButton.Text = "Continuar";
            this.ContinuarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ContinuarButton.UseVisualStyleBackColor = false;
            this.ContinuarButton.Click += new System.EventHandler(this.ContinuarButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Image = global::Parking.Windows.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(538, 185);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 64);
            this.CancelButton.TabIndex = 223;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // frmSeleccionarTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.ControlBox = false;
            this.Controls.Add(this.ContinuarButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel2);
            this.Name = "frmSeleccionarTarifa";
            this.Text = "frmSeleccionarTarifa";
            this.Load += new System.EventHandler(this.frmSeleccionarTarifa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ContinuarButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox TarifasComboBox;
        private System.Windows.Forms.Label DatosUbicacionLabel;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TarifaLabel;
        private System.Windows.Forms.TextBox ImporteTextBox;
    }
}