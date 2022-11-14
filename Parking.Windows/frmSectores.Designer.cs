
namespace Parking.Windows
{
    partial class frmSectores
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
            this.ControlesToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLugaresDisponbles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLugaresDisponiblesMotos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlesToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlesToolStrip
            // 
            this.ControlesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrar});
            this.ControlesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ControlesToolStrip.Name = "ControlesToolStrip";
            this.ControlesToolStrip.Size = new System.Drawing.Size(1008, 52);
            this.ControlesToolStrip.TabIndex = 9;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.DatosDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 677);
            this.panel1.TabIndex = 11;
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
            this.colSector,
            this.ColLugaresDisponbles,
            this.ColLugaresDisponiblesMotos});
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
            // colSector
            // 
            this.colSector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSector.HeaderText = "Sector";
            this.colSector.Name = "colSector";
            this.colSector.ReadOnly = true;
            // 
            // ColLugaresDisponbles
            // 
            this.ColLugaresDisponbles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColLugaresDisponbles.HeaderText = "Lugares Disp.";
            this.ColLugaresDisponbles.Name = "ColLugaresDisponbles";
            this.ColLugaresDisponbles.ReadOnly = true;
            // 
            // ColLugaresDisponiblesMotos
            // 
            this.ColLugaresDisponiblesMotos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColLugaresDisponiblesMotos.HeaderText = "Lugares Disp. Motos";
            this.ColLugaresDisponiblesMotos.Name = "ColLugaresDisponiblesMotos";
            this.ColLugaresDisponiblesMotos.ReadOnly = true;
            // 
            // frmSectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ControlesToolStrip);
            this.Name = "frmSectores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSectores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSectores_Load);
            this.ControlesToolStrip.ResumeLayout(false);
            this.ControlesToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ControlesToolStrip;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLugaresDisponbles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLugaresDisponiblesMotos;
    }
}