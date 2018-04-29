namespace RafitNewFace
{
    partial class frrmMasterStepFan
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
            this.FlowPasos = new System.Windows.Forms.FlowLayoutPanel();
            this.Paso1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PBConfirm1 = new System.Windows.Forms.PictureBox();
            this.Paso2 = new System.Windows.Forms.Panel();
            this.PBConfirm2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Paso3 = new System.Windows.Forms.Panel();
            this.PBConfirm3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Paso4 = new System.Windows.Forms.Panel();
            this.PBConfimr4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PNContenedor = new System.Windows.Forms.Panel();
            this.TiempoAnimacion = new System.Windows.Forms.Timer(this.components);
            this.FlowPasos.SuspendLayout();
            this.Paso1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfirm1)).BeginInit();
            this.Paso2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfirm2)).BeginInit();
            this.Paso3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfirm3)).BeginInit();
            this.Paso4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfimr4)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPasos
            // 
            this.FlowPasos.Controls.Add(this.Paso1);
            this.FlowPasos.Controls.Add(this.Paso2);
            this.FlowPasos.Controls.Add(this.Paso3);
            this.FlowPasos.Controls.Add(this.Paso4);
            this.FlowPasos.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowPasos.Location = new System.Drawing.Point(0, 0);
            this.FlowPasos.Name = "FlowPasos";
            this.FlowPasos.Size = new System.Drawing.Size(220, 581);
            this.FlowPasos.TabIndex = 0;
            // 
            // Paso1
            // 
            this.Paso1.BackColor = System.Drawing.Color.White;
            this.Paso1.Controls.Add(this.label1);
            this.Paso1.Controls.Add(this.PBConfirm1);
            this.Paso1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paso1.Location = new System.Drawing.Point(3, 3);
            this.Paso1.Name = "Paso1";
            this.Paso1.Size = new System.Drawing.Size(214, 138);
            this.Paso1.TabIndex = 0;
            this.Paso1.Click += new System.EventHandler(this.Paso1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion Fan";
            // 
            // PBConfirm1
            // 
            this.PBConfirm1.BackColor = System.Drawing.Color.Transparent;
            this.PBConfirm1.Enabled = false;
            this.PBConfirm1.Image = global::Rafit.Face.Properties.Resources.success;
            this.PBConfirm1.Location = new System.Drawing.Point(49, 47);
            this.PBConfirm1.Name = "PBConfirm1";
            this.PBConfirm1.Size = new System.Drawing.Size(124, 74);
            this.PBConfirm1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBConfirm1.TabIndex = 1;
            this.PBConfirm1.TabStop = false;
            this.PBConfirm1.Visible = false;
            // 
            // Paso2
            // 
            this.Paso2.Controls.Add(this.PBConfirm2);
            this.Paso2.Controls.Add(this.label2);
            this.Paso2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paso2.Location = new System.Drawing.Point(3, 147);
            this.Paso2.Name = "Paso2";
            this.Paso2.Size = new System.Drawing.Size(214, 138);
            this.Paso2.TabIndex = 1;
            this.Paso2.Click += new System.EventHandler(this.Paso2_Click);
            // 
            // PBConfirm2
            // 
            this.PBConfirm2.BackColor = System.Drawing.Color.Transparent;
            this.PBConfirm2.Enabled = false;
            this.PBConfirm2.Image = global::Rafit.Face.Properties.Resources.success;
            this.PBConfirm2.Location = new System.Drawing.Point(49, 43);
            this.PBConfirm2.Name = "PBConfirm2";
            this.PBConfirm2.Size = new System.Drawing.Size(124, 74);
            this.PBConfirm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBConfirm2.TabIndex = 2;
            this.PBConfirm2.TabStop = false;
            this.PBConfirm2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione Los Servicios";
            // 
            // Paso3
            // 
            this.Paso3.Controls.Add(this.PBConfirm3);
            this.Paso3.Controls.Add(this.label3);
            this.Paso3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paso3.Location = new System.Drawing.Point(3, 291);
            this.Paso3.Name = "Paso3";
            this.Paso3.Size = new System.Drawing.Size(214, 138);
            this.Paso3.TabIndex = 2;
            this.Paso3.Click += new System.EventHandler(this.Paso3_Click);
            // 
            // PBConfirm3
            // 
            this.PBConfirm3.BackColor = System.Drawing.Color.Transparent;
            this.PBConfirm3.Enabled = false;
            this.PBConfirm3.Image = global::Rafit.Face.Properties.Resources.success;
            this.PBConfirm3.Location = new System.Drawing.Point(49, 44);
            this.PBConfirm3.Name = "PBConfirm3";
            this.PBConfirm3.Size = new System.Drawing.Size(124, 74);
            this.PBConfirm3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBConfirm3.TabIndex = 3;
            this.PBConfirm3.TabStop = false;
            this.PBConfirm3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(37, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resumen de Factura";
            // 
            // Paso4
            // 
            this.Paso4.Controls.Add(this.PBConfimr4);
            this.Paso4.Controls.Add(this.label4);
            this.Paso4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paso4.Location = new System.Drawing.Point(3, 435);
            this.Paso4.Name = "Paso4";
            this.Paso4.Size = new System.Drawing.Size(214, 138);
            this.Paso4.TabIndex = 3;
            this.Paso4.Click += new System.EventHandler(this.Paso4_Click);
            // 
            // PBConfimr4
            // 
            this.PBConfimr4.BackColor = System.Drawing.Color.Transparent;
            this.PBConfimr4.Enabled = false;
            this.PBConfimr4.Image = global::Rafit.Face.Properties.Resources.success;
            this.PBConfimr4.Location = new System.Drawing.Point(49, 44);
            this.PBConfimr4.Name = "PBConfimr4";
            this.PBConfimr4.Size = new System.Drawing.Size(124, 74);
            this.PBConfimr4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBConfimr4.TabIndex = 3;
            this.PBConfimr4.TabStop = false;
            this.PBConfimr4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(50, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Confirmar Pago";
            // 
            // PNContenedor
            // 
            this.PNContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNContenedor.Location = new System.Drawing.Point(220, 0);
            this.PNContenedor.Name = "PNContenedor";
            this.PNContenedor.Size = new System.Drawing.Size(820, 581);
            this.PNContenedor.TabIndex = 1;
            // 
            // FormNuevoFan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 581);
            this.Controls.Add(this.PNContenedor);
            this.Controls.Add(this.FlowPasos);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNuevoFan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNuevoFan";
            this.FlowPasos.ResumeLayout(false);
            this.Paso1.ResumeLayout(false);
            this.Paso1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfirm1)).EndInit();
            this.Paso2.ResumeLayout(false);
            this.Paso2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfirm2)).EndInit();
            this.Paso3.ResumeLayout(false);
            this.Paso3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfirm3)).EndInit();
            this.Paso4.ResumeLayout(false);
            this.Paso4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfimr4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPasos;
        private System.Windows.Forms.Panel Paso1;
        private System.Windows.Forms.Panel Paso2;
        private System.Windows.Forms.Panel Paso3;
        private System.Windows.Forms.Panel Paso4;
        private System.Windows.Forms.PictureBox PBConfirm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PNContenedor;
        public System.Windows.Forms.Timer TiempoAnimacion;
        private System.Windows.Forms.PictureBox PBConfirm2;
        private System.Windows.Forms.PictureBox PBConfirm3;
        private System.Windows.Forms.PictureBox PBConfimr4;
    }
}