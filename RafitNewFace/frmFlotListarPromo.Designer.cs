namespace RafitNewFace
{
    partial class frmFlotListarPromo
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
            this.FlowPromo = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBCode = new System.Windows.Forms.TextBox();
            this.PBCerrar = new System.Windows.Forms.PictureBox();
            this.LBInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPromo
            // 
            this.FlowPromo.AutoScroll = true;
            this.FlowPromo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlowPromo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowPromo.Location = new System.Drawing.Point(0, 44);
            this.FlowPromo.Name = "FlowPromo";
            this.FlowPromo.Size = new System.Drawing.Size(285, 372);
            this.FlowPromo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Rafit.Face.Properties.Resources.wp08356e36_06;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.TBCode);
            this.panel1.Controls.Add(this.PBCerrar);
            this.panel1.Controls.Add(this.LBInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 44);
            this.panel1.TabIndex = 1;
            // 
            // TBCode
            // 
            this.TBCode.BackColor = System.Drawing.Color.White;
            this.TBCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCode.Enabled = false;
            this.TBCode.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.TBCode.Location = new System.Drawing.Point(104, 6);
            this.TBCode.Name = "TBCode";
            this.TBCode.ReadOnly = true;
            this.TBCode.Size = new System.Drawing.Size(127, 25);
            this.TBCode.TabIndex = 7;
            this.TBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PBCerrar
            // 
            this.PBCerrar.BackColor = System.Drawing.Color.Transparent;
            this.PBCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBCerrar.Image = global::Rafit.Face.Properties.Resources.error;
            this.PBCerrar.Location = new System.Drawing.Point(237, 6);
            this.PBCerrar.Name = "PBCerrar";
            this.PBCerrar.Size = new System.Drawing.Size(33, 26);
            this.PBCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCerrar.TabIndex = 6;
            this.PBCerrar.TabStop = false;
            this.PBCerrar.Click += new System.EventHandler(this.PBCerrar_Click);
            // 
            // LBInfo
            // 
            this.LBInfo.AutoSize = true;
            this.LBInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LBInfo.Location = new System.Drawing.Point(23, 9);
            this.LBInfo.Name = "LBInfo";
            this.LBInfo.Size = new System.Drawing.Size(75, 19);
            this.LBInfo.TabIndex = 5;
            this.LBInfo.Text = "Codigo: ";
            // 
            // ListarPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(285, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FlowPromo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListarPromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarPromo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPromo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox TBCode;
        private System.Windows.Forms.PictureBox PBCerrar;
        private System.Windows.Forms.Label LBInfo;
    }
}