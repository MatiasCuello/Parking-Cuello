
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.TituloMenuStrip = new System.Windows.Forms.MenuStrip();
            this.TituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirButton = new System.Windows.Forms.Button();
            this.TarifasButton = new System.Windows.Forms.Button();
            this.ClientesButton = new System.Windows.Forms.Button();
            this.VehiculoButton = new System.Windows.Forms.Button();
            this.TituloMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 175);
            // 
            // TituloMenuStrip
            // 
            this.TituloMenuStrip.AutoSize = false;
            this.TituloMenuStrip.BackColor = System.Drawing.Color.DarkCyan;
            this.TituloMenuStrip.ImageScalingSize = new System.Drawing.Size(16, 60);
            this.TituloMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TituloToolStripMenuItem});
            this.TituloMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TituloMenuStrip.Name = "TituloMenuStrip";
            this.TituloMenuStrip.Size = new System.Drawing.Size(784, 72);
            this.TituloMenuStrip.TabIndex = 3;
            // 
            // TituloToolStripMenuItem
            // 
            this.TituloToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TituloToolStripMenuItem.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Bold);
            this.TituloToolStripMenuItem.Image = global::Parking.Windows.Properties.Resources.icons8_parking_60;
            this.TituloToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TituloToolStripMenuItem.Name = "TituloToolStripMenuItem";
            this.TituloToolStripMenuItem.Size = new System.Drawing.Size(361, 68);
            this.TituloToolStripMenuItem.Text = "PARKING - CUELLO";
            // 
            // SalirButton
            // 
            this.SalirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.Image = global::Parking.Windows.Properties.Resources.Salir;
            this.SalirButton.Location = new System.Drawing.Point(658, 278);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(114, 71);
            this.SalirButton.TabIndex = 0;
            this.SalirButton.Text = "SALIR";
            this.SalirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // TarifasButton
            // 
            this.TarifasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarifasButton.Image = global::Parking.Windows.Properties.Resources.abono40px;
            this.TarifasButton.Location = new System.Drawing.Point(145, 126);
            this.TarifasButton.Name = "TarifasButton";
            this.TarifasButton.Size = new System.Drawing.Size(114, 71);
            this.TarifasButton.TabIndex = 0;
            this.TarifasButton.Text = "TARIFAS";
            this.TarifasButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TarifasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TarifasButton.UseVisualStyleBackColor = true;
            this.TarifasButton.Click += new System.EventHandler(this.TarifasButton_Click);
            // 
            // ClientesButton
            // 
            this.ClientesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesButton.Image = global::Parking.Windows.Properties.Resources.icons8_clients_40;
            this.ClientesButton.Location = new System.Drawing.Point(658, 126);
            this.ClientesButton.Name = "ClientesButton";
            this.ClientesButton.Size = new System.Drawing.Size(114, 71);
            this.ClientesButton.TabIndex = 0;
            this.ClientesButton.Text = "CLIENTES";
            this.ClientesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClientesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ClientesButton.UseVisualStyleBackColor = true;
            this.ClientesButton.Click += new System.EventHandler(this.ClientesButton_Click);
            // 
            // VehiculoButton
            // 
            this.VehiculoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiculoButton.Image = global::Parking.Windows.Properties.Resources.icons8_vehicles_40;
            this.VehiculoButton.Location = new System.Drawing.Point(25, 126);
            this.VehiculoButton.Name = "VehiculoButton";
            this.VehiculoButton.Size = new System.Drawing.Size(114, 71);
            this.VehiculoButton.TabIndex = 0;
            this.VehiculoButton.Text = "VEHICULOS";
            this.VehiculoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VehiculoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VehiculoButton.UseVisualStyleBackColor = true;
            this.VehiculoButton.Click += new System.EventHandler(this.VehiculoButton_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.TarifasButton);
            this.Controls.Add(this.ClientesButton);
            this.Controls.Add(this.VehiculoButton);
            this.Controls.Add(this.TituloMenuStrip);
            this.MainMenuStrip = this.TituloMenuStrip;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARKINGCUELLO";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.Click += new System.EventHandler(this.frmMenuPrincipal_Click);
            this.TituloMenuStrip.ResumeLayout(false);
            this.TituloMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button VehiculoButton;
        private System.Windows.Forms.Button ClientesButton;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.MenuStrip TituloMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TituloToolStripMenuItem;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button TarifasButton;
    }
}

