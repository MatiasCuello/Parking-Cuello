
namespace Parking.Windows
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TituloLabel = new System.Windows.Forms.Label();
            this.ClientesButton = new System.Windows.Forms.Button();
            this.VehiculoButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(365, 98);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(369, 41);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "PARKING - CUELLO";
            // 
            // ClientesButton
            // 
            this.ClientesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesButton.Image = global::Parking.Windows.Properties.Resources.cars1;
            this.ClientesButton.Location = new System.Drawing.Point(291, 181);
            this.ClientesButton.Name = "ClientesButton";
            this.ClientesButton.Size = new System.Drawing.Size(114, 72);
            this.ClientesButton.TabIndex = 0;
            this.ClientesButton.Text = "CLIENTES";
            this.ClientesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClientesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ClientesButton.UseVisualStyleBackColor = true;
            this.ClientesButton.Click += new System.EventHandler(this.ClientesButton_Click);
            // 
            // VehiculoButton
            // 
            this.VehiculoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiculoButton.Image = global::Parking.Windows.Properties.Resources.cars1;
            this.VehiculoButton.Location = new System.Drawing.Point(129, 181);
            this.VehiculoButton.Name = "VehiculoButton";
            this.VehiculoButton.Size = new System.Drawing.Size(114, 72);
            this.VehiculoButton.TabIndex = 0;
            this.VehiculoButton.Text = "VEHICULOS";
            this.VehiculoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VehiculoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VehiculoButton.UseVisualStyleBackColor = true;
            this.VehiculoButton.Click += new System.EventHandler(this.VehiculoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parking.Windows.Properties.Resources.garage_100pxp;
            this.pictureBox1.Location = new System.Drawing.Point(259, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ClientesButton);
            this.Controls.Add(this.VehiculoButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TituloLabel);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button VehiculoButton;
        private System.Windows.Forms.Button ClientesButton;
    }
}

