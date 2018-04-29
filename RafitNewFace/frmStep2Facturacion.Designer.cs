namespace RafitNewFace
{
    partial class frmStep2Facturacion
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
            this.LBMembSelec = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.LBDMemb = new System.Windows.Forms.Label();
            this.LBDPromo = new System.Windows.Forms.Label();
            this.TBPromo = new System.Windows.Forms.TextBox();
            this.PNInferior = new System.Windows.Forms.Panel();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ToolTipName = new System.Windows.Forms.ToolTip(this.components);
            this.PNFlowMemb = new System.Windows.Forms.FlowLayoutPanel();
            this.PNSuperio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTContinuar = new System.Windows.Forms.Button();
            this.PBBuscarpromo = new System.Windows.Forms.PictureBox();
            this.PNInferior.SuspendLayout();
            this.PNSuperio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBuscarpromo)).BeginInit();
            this.SuspendLayout();
            // 
            // LBMembSelec
            // 
            this.LBMembSelec.AutoSize = true;
            this.LBMembSelec.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.LBMembSelec.Location = new System.Drawing.Point(296, 116);
            this.LBMembSelec.Name = "LBMembSelec";
            this.LBMembSelec.Size = new System.Drawing.Size(0, 17);
            this.LBMembSelec.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(282, 454);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 24);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Esta es la fecha  aproximada de vencimiento:";
            // 
            // LBDMemb
            // 
            this.LBDMemb.AutoSize = true;
            this.LBDMemb.Location = new System.Drawing.Point(37, 82);
            this.LBDMemb.Name = "LBDMemb";
            this.LBDMemb.Size = new System.Drawing.Size(237, 16);
            this.LBDMemb.TabIndex = 36;
            this.LBDMemb.Text = "Para Cuanto Tiempo le alcanza el Dinero?";
            // 
            // LBDPromo
            // 
            this.LBDPromo.AutoSize = true;
            this.LBDPromo.Location = new System.Drawing.Point(315, 323);
            this.LBDPromo.Name = "LBDPromo";
            this.LBDPromo.Size = new System.Drawing.Size(180, 16);
            this.LBDPromo.TabIndex = 34;
            this.LBDPromo.Text = "Quieres Aplicar una Promocion?";
            // 
            // TBPromo
            // 
            this.TBPromo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBPromo.Location = new System.Drawing.Point(260, 355);
            this.TBPromo.Name = "TBPromo";
            this.TBPromo.Size = new System.Drawing.Size(294, 21);
            this.TBPromo.TabIndex = 33;
            // 
            // PNInferior
            // 
            this.PNInferior.Controls.Add(this.TBTotal);
            this.PNInferior.Controls.Add(this.label2);
            this.PNInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNInferior.Location = new System.Drawing.Point(0, 531);
            this.PNInferior.Name = "PNInferior";
            this.PNInferior.Size = new System.Drawing.Size(817, 50);
            this.PNInferior.TabIndex = 45;
            // 
            // TBTotal
            // 
            this.TBTotal.BackColor = System.Drawing.Color.White;
            this.TBTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.TBTotal.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.TBTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBTotal.Location = new System.Drawing.Point(283, 15);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(287, 25);
            this.TBTotal.TabIndex = 45;
            this.TBTotal.Text = "0";
            this.TBTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(256, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "$";
            // 
            // PNFlowMemb
            // 
            this.PNFlowMemb.AutoScroll = true;
            this.PNFlowMemb.BackColor = System.Drawing.Color.White;
            this.PNFlowMemb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PNFlowMemb.Location = new System.Drawing.Point(40, 116);
            this.PNFlowMemb.Name = "PNFlowMemb";
            this.PNFlowMemb.Size = new System.Drawing.Size(741, 178);
            this.PNFlowMemb.TabIndex = 35;
            // 
            // PNSuperio
            // 
            this.PNSuperio.BackgroundImage = global::Rafit.Face.Properties.Resources.wp08356e36_061;
            this.PNSuperio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNSuperio.Controls.Add(this.label1);
            this.PNSuperio.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNSuperio.Location = new System.Drawing.Point(0, 0);
            this.PNSuperio.Name = "PNSuperio";
            this.PNSuperio.Size = new System.Drawing.Size(817, 61);
            this.PNSuperio.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(295, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Informacion de Facturacion";
            // 
            // BTContinuar
            // 
            this.BTContinuar.BackColor = System.Drawing.Color.LightGreen;
            this.BTContinuar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.BTContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTContinuar.FlatAppearance.BorderSize = 0;
            this.BTContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.BTContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTContinuar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.BTContinuar.ForeColor = System.Drawing.Color.White;
            this.BTContinuar.Location = new System.Drawing.Point(710, 499);
            this.BTContinuar.Name = "BTContinuar";
            this.BTContinuar.Size = new System.Drawing.Size(95, 26);
            this.BTContinuar.TabIndex = 31;
            this.BTContinuar.Text = "Continuar";
            this.BTContinuar.UseVisualStyleBackColor = false;
            this.BTContinuar.Click += new System.EventHandler(this.BTContinuar_Click);
            // 
            // PBBuscarpromo
            // 
            this.PBBuscarpromo.BackColor = System.Drawing.Color.Transparent;
            this.PBBuscarpromo.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBBuscarpromo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBBuscarpromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBBuscarpromo.Image = global::Rafit.Face.Properties.Resources.icons8_Search_100px;
            this.PBBuscarpromo.Location = new System.Drawing.Point(396, 382);
            this.PBBuscarpromo.Name = "PBBuscarpromo";
            this.PBBuscarpromo.Size = new System.Drawing.Size(47, 24);
            this.PBBuscarpromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBBuscarpromo.TabIndex = 37;
            this.PBBuscarpromo.TabStop = false;
            this.PBBuscarpromo.Click += new System.EventHandler(this.PBBuscarpromo_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 581);
            this.Controls.Add(this.PNSuperio);
            this.Controls.Add(this.PNInferior);
            this.Controls.Add(this.BTContinuar);
            this.Controls.Add(this.LBMembSelec);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PBBuscarpromo);
            this.Controls.Add(this.LBDMemb);
            this.Controls.Add(this.PNFlowMemb);
            this.Controls.Add(this.LBDPromo);
            this.Controls.Add(this.TBPromo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.PNInferior.ResumeLayout(false);
            this.PNInferior.PerformLayout();
            this.PNSuperio.ResumeLayout(false);
            this.PNSuperio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBuscarpromo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTContinuar;
        private System.Windows.Forms.Label LBMembSelec;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PBBuscarpromo;
        private System.Windows.Forms.Label LBDMemb;
        private System.Windows.Forms.FlowLayoutPanel PNFlowMemb;
        private System.Windows.Forms.Label LBDPromo;
        private System.Windows.Forms.TextBox TBPromo;
        private System.Windows.Forms.Panel PNInferior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ToolTipName;
        private System.Windows.Forms.Panel PNSuperio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBTotal;
    }
}