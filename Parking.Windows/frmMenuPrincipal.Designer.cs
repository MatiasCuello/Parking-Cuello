
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
            this.ClientesButton = new System.Windows.Forms.Button();
            this.VehiculoButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.TituloMenuStrip.Size = new System.Drawing.Size(1084, 72);
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
            // ClientesButton
            // 
            this.ClientesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesButton.Image = global::Parking.Windows.Properties.Resources.icons8_clients_40;
            this.ClientesButton.Location = new System.Drawing.Point(145, 75);
            this.ClientesButton.Name = "ClientesButton";
            this.ClientesButton.Size = new System.Drawing.Size(114, 57);
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
            this.VehiculoButton.Location = new System.Drawing.Point(25, 75);
            this.VehiculoButton.Name = "VehiculoButton";
            this.VehiculoButton.Size = new System.Drawing.Size(114, 57);
            this.VehiculoButton.TabIndex = 0;
            this.VehiculoButton.Text = "TIPOS VEHICULOS";
            this.VehiculoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VehiculoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VehiculoButton.UseVisualStyleBackColor = true;
            this.VehiculoButton.Click += new System.EventHandler(this.VehiculoButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 60);
            this.menuStrip1.Location = new System.Drawing.Point(0, 72);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 60);
            this.menuStrip1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 597);
            this.panel1.TabIndex = 5;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClientesButton);
            this.Controls.Add(this.VehiculoButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TituloMenuStrip);
            this.MainMenuStrip = this.TituloMenuStrip;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARKINGCUELLO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}

