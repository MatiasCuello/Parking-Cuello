
namespace Parking.Windows
{
    partial class frmMarcasAE
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.DatosClientesLabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(522, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 165);
            this.panel1.TabIndex = 217;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parking.Windows.Properties.Resources.icons8_volkswagen_100;
            this.pictureBox1.Location = new System.Drawing.Point(73, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.DatosClientesLabel);
            this.panel2.Controls.Add(this.DescripcionTextBox);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.DescripcionLabel);
            this.panel2.Location = new System.Drawing.Point(14, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 165);
            this.panel2.TabIndex = 218;
            // 
            // DatosClientesLabel
            // 
            this.DatosClientesLabel.AutoSize = true;
            this.DatosClientesLabel.Font = new System.Drawing.Font("Elephant", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosClientesLabel.Location = new System.Drawing.Point(134, 14);
            this.DatosClientesLabel.Name = "DatosClientesLabel";
            this.DatosClientesLabel.Size = new System.Drawing.Size(234, 24);
            this.DatosClientesLabel.TabIndex = 183;
            this.DatosClientesLabel.Text = "DATOS DE LA MARCA";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(157, 80);
            this.DescripcionTextBox.MaxLength = 100;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(329, 20);
            this.DescripcionTextBox.TabIndex = 195;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = global::Parking.Windows.Properties.Resources.icons8_volkswagen_30;
            this.pictureBox6.Location = new System.Drawing.Point(15, 71);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 29);
            this.pictureBox6.TabIndex = 211;
            this.pictureBox6.TabStop = false;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.DescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.Location = new System.Drawing.Point(56, 80);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(95, 16);
            this.DescripcionLabel.TabIndex = 205;
            this.DescripcionLabel.Text = "Descripcion:";
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.White;
            this.OkButton.Image = global::Parking.Windows.Properties.Resources.OK;
            this.OkButton.Location = new System.Drawing.Point(152, 185);
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
            this.CancelButton.Location = new System.Drawing.Point(522, 185);
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
            // frmMarcasAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmMarcasAE";
            this.Text = "frmMarcasAE";
            this.Load += new System.EventHandler(this.frmMarcasAE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label DatosClientesLabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}