
namespace Parking.Windows
{
    partial class frmVehiculosRegistrados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.ControlesToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.colFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstacionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.TarifaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.ControlesToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DatosDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 667);
            this.panel1.TabIndex = 13;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.AllowUserToResizeColumns = false;
            this.DatosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechaIngreso,
            this.ColPatente,
            this.colVehiculo,
            this.colSector,
            this.colLugar,
            this.colEstacionado});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersVisible = false;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(1008, 667);
            this.DatosDataGridView.TabIndex = 0;
            this.DatosDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DatosDataGridView_RowHeaderMouseClick);
            // 
            // ControlesToolStrip
            // 
            this.ControlesToolStrip.BackColor = System.Drawing.Color.White;
            this.ControlesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.toolStripSeparator2,
            this.EditarToolStripButton,
            this.toolStripSeparator1,
            this.BorrarToolStripButton,
            this.tsbCerrar,
            this.toolStripSeparator3,
            this.TarifaToolStripButton});
            this.ControlesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ControlesToolStrip.Name = "ControlesToolStrip";
            this.ControlesToolStrip.Size = new System.Drawing.Size(1008, 62);
            this.ControlesToolStrip.TabIndex = 12;
            this.ControlesToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 62);
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFechaIngreso.HeaderText = "Fecha/Hora Ingreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.ReadOnly = true;
            // 
            // ColPatente
            // 
            this.ColPatente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPatente.HeaderText = "Patente";
            this.ColPatente.Name = "ColPatente";
            this.ColPatente.ReadOnly = true;
            // 
            // colVehiculo
            // 
            this.colVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVehiculo.HeaderText = "Vehiculo";
            this.colVehiculo.Name = "colVehiculo";
            this.colVehiculo.ReadOnly = true;
            // 
            // colSector
            // 
            this.colSector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSector.HeaderText = "Sector";
            this.colSector.Name = "colSector";
            this.colSector.ReadOnly = true;
            // 
            // colLugar
            // 
            this.colLugar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLugar.HeaderText = "Lugar";
            this.colLugar.Name = "colLugar";
            this.colLugar.ReadOnly = true;
            // 
            // colEstacionado
            // 
            this.colEstacionado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEstacionado.HeaderText = "Estacionado";
            this.colEstacionado.Name = "colEstacionado";
            this.colEstacionado.ReadOnly = true;
            this.colEstacionado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEstacionado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::Parking.Windows.Properties.Resources.Plus_30px;
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 59);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = global::Parking.Windows.Properties.Resources.pencil_50px;
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 59);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = global::Parking.Windows.Properties.Resources.waste_50px;
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 59);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.Image = global::Parking.Windows.Properties.Resources.close_window_50px;
            this.tsbCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(43, 59);
            this.tsbCerrar.Text = "Cerrar";
            this.tsbCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // TarifaToolStripButton
            // 
            this.TarifaToolStripButton.Image = global::Parking.Windows.Properties.Resources.payment_history_40px;
            this.TarifaToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TarifaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TarifaToolStripButton.Name = "TarifaToolStripButton";
            this.TarifaToolStripButton.Size = new System.Drawing.Size(44, 59);
            this.TarifaToolStripButton.Text = "Tarifa";
            this.TarifaToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmVehiculosRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ControlesToolStrip);
            this.Name = "frmVehiculosRegistrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos Registrados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ControlesToolStrip.ResumeLayout(false);
            this.ControlesToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.ToolStrip ControlesToolStrip;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLugar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEstacionado;
        private System.Windows.Forms.ToolStripButton TarifaToolStripButton;
    }
}