
namespace Parking.Windows
{
    partial class frmCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobro));
            this.ImporteLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VueltoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TarjetaButton = new System.Windows.Forms.Button();
            this.EfectivoButton = new System.Windows.Forms.Button();
            this.RetirarButton = new System.Windows.Forms.Button();
            this.VolverButton = new System.Windows.Forms.Button();
            this.RecibidoLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImporteLabel
            // 
            this.ImporteLabel.AutoSize = true;
            this.ImporteLabel.BackColor = System.Drawing.Color.White;
            this.ImporteLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteLabel.Location = new System.Drawing.Point(44, 130);
            this.ImporteLabel.Name = "ImporteLabel";
            this.ImporteLabel.Size = new System.Drawing.Size(74, 39);
            this.ImporteLabel.TabIndex = 1;
            this.ImporteLabel.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL A PAGAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recibido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vuelto:";
            // 
            // VueltoLabel
            // 
            this.VueltoLabel.AutoSize = true;
            this.VueltoLabel.BackColor = System.Drawing.Color.White;
            this.VueltoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VueltoLabel.Location = new System.Drawing.Point(149, 169);
            this.VueltoLabel.Name = "VueltoLabel";
            this.VueltoLabel.Size = new System.Drawing.Size(54, 25);
            this.VueltoLabel.TabIndex = 1;
            this.VueltoLabel.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ImporteLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(41, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 248);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.TarjetaButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.EfectivoButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.RecibidoLabel);
            this.panel2.Controls.Add(this.VueltoLabel);
            this.panel2.Location = new System.Drawing.Point(248, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 247);
            this.panel2.TabIndex = 224;
            // 
            // TarjetaButton
            // 
            this.TarjetaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TarjetaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarjetaButton.Image = global::Parking.Windows.Properties.Resources.tarjeta;
            this.TarjetaButton.Location = new System.Drawing.Point(150, 28);
            this.TarjetaButton.Name = "TarjetaButton";
            this.TarjetaButton.Size = new System.Drawing.Size(107, 51);
            this.TarjetaButton.TabIndex = 3;
            this.TarjetaButton.Text = "TARJETA";
            this.TarjetaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TarjetaButton.UseVisualStyleBackColor = false;
            this.TarjetaButton.Click += new System.EventHandler(this.TarjetaButton_Click);
            // 
            // EfectivoButton
            // 
            this.EfectivoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EfectivoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EfectivoButton.Image = global::Parking.Windows.Properties.Resources.billete;
            this.EfectivoButton.Location = new System.Drawing.Point(33, 28);
            this.EfectivoButton.Name = "EfectivoButton";
            this.EfectivoButton.Size = new System.Drawing.Size(112, 51);
            this.EfectivoButton.TabIndex = 3;
            this.EfectivoButton.Text = "EFECTIVO";
            this.EfectivoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EfectivoButton.UseVisualStyleBackColor = false;
            this.EfectivoButton.Click += new System.EventHandler(this.EfectivoButton_Click);
            // 
            // RetirarButton
            // 
            this.RetirarButton.BackColor = System.Drawing.Color.White;
            this.RetirarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetirarButton.Image = ((System.Drawing.Image)(resources.GetObject("RetirarButton.Image")));
            this.RetirarButton.Location = new System.Drawing.Point(63, 285);
            this.RetirarButton.Name = "RetirarButton";
            this.RetirarButton.Size = new System.Drawing.Size(127, 64);
            this.RetirarButton.TabIndex = 222;
            this.RetirarButton.Text = "Retirar";
            this.RetirarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RetirarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RetirarButton.UseVisualStyleBackColor = false;
            this.RetirarButton.Click += new System.EventHandler(this.RetirarButton_Click);
            // 
            // VolverButton
            // 
            this.VolverButton.BackColor = System.Drawing.Color.White;
            this.VolverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverButton.Image = ((System.Drawing.Image)(resources.GetObject("VolverButton.Image")));
            this.VolverButton.Location = new System.Drawing.Point(379, 285);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(126, 64);
            this.VolverButton.TabIndex = 223;
            this.VolverButton.Text = "Cancelar";
            this.VolverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VolverButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VolverButton.UseVisualStyleBackColor = false;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // RecibidoLabel
            // 
            this.RecibidoLabel.AutoSize = true;
            this.RecibidoLabel.BackColor = System.Drawing.Color.White;
            this.RecibidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecibidoLabel.Location = new System.Drawing.Point(149, 119);
            this.RecibidoLabel.Name = "RecibidoLabel";
            this.RecibidoLabel.Size = new System.Drawing.Size(54, 25);
            this.RecibidoLabel.TabIndex = 1;
            this.RecibidoLabel.Text = "0.00";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RetirarButton);
            this.Controls.Add(this.VolverButton);
            this.Name = "frmCobro";
            this.Text = "frmCobro";
            this.Load += new System.EventHandler(this.frmCobro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RetirarButton;
        private System.Windows.Forms.Button VolverButton;
        private System.Windows.Forms.Label ImporteLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VueltoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TarjetaButton;
        private System.Windows.Forms.Button EfectivoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RecibidoLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}