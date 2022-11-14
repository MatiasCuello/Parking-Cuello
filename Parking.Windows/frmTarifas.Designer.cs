
namespace Parking.Windows
{
    partial class frmTarifas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlesToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.ControlesToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DatosDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 677);
            this.panel1.TabIndex = 13;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.AllowUserToResizeColumns = false;
            this.DatosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipoVehiculo,
            this.colTiempo,
            this.colImporte});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersVisible = false;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(1008, 677);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colTipoVehiculo
            // 
            this.colTipoVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoVehiculo.HeaderText = "Tipo de Vehiculo";
            this.colTipoVehiculo.Name = "colTipoVehiculo";
            this.colTipoVehiculo.ReadOnly = true;
            // 
            // colTiempo
            // 
            this.colTiempo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTiempo.HeaderText = "Tiempo";
            this.colTiempo.Name = "colTiempo";
            this.colTiempo.ReadOnly = true;
            // 
            // colImporte
            // 
            this.colImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            // 
            // ControlesToolStrip
            // 
            this.ControlesToolStrip.BackColor = System.Drawing.Color.White;
            this.ControlesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrar,
            this.NuevoToolStripButton,
            this.toolStripSeparator2,
            this.EditarToolStripButton,
            this.toolStripSeparator3,
            this.BorrarToolStripButton,
            this.toolStripSeparator1});
            this.ControlesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ControlesToolStrip.Name = "ControlesToolStrip";
            this.ControlesToolStrip.Size = new System.Drawing.Size(1008, 52);
            this.ControlesToolStrip.TabIndex = 12;
            this.ControlesToolStrip.Text = "toolStrip1";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.Image = global::Parking.Windows.Properties.Resources.close_window_50px;
            this.tsbCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(43, 49);
            this.tsbCerrar.Text = "Cerrar";
            this.tsbCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::Parking.Windows.Properties.Resources.Plus_30px;
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 49);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = global::Parking.Windows.Properties.Resources.pencil_50px;
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 49);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = global::Parking.Windows.Properties.Resources.waste_50px;
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 49);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // frmTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ControlesToolStrip);
            this.Name = "frmTarifas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTarifas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTarifas_Load);
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
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}