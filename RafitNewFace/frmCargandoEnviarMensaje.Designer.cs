namespace RafitNewFace
{
    partial class frmCargandoEnviarMensaje
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
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.LBEstado = new System.Windows.Forms.Label();
            this.PBGifs = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBOk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBGifs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOk)).BeginInit();
            this.SuspendLayout();
            // 
            // LBEstado
            // 
            this.LBEstado.AutoSize = true;
            this.LBEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBEstado.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.LBEstado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LBEstado.Location = new System.Drawing.Point(0, 0);
            this.LBEstado.Name = "LBEstado";
            this.LBEstado.Size = new System.Drawing.Size(188, 23);
            this.LBEstado.TabIndex = 1;
            this.LBEstado.Text = "Enviando Mensaje";
            this.LBEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBEstado.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // PBGifs
            // 
            this.PBGifs.BackColor = System.Drawing.Color.Transparent;
            this.PBGifs.Image = global::Rafit.Face.Properties.Resources.Cargando;
            this.PBGifs.Location = new System.Drawing.Point(246, 188);
            this.PBGifs.Name = "PBGifs";
            this.PBGifs.Size = new System.Drawing.Size(212, 168);
            this.PBGifs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBGifs.TabIndex = 0;
            this.PBGifs.TabStop = false;
            this.PBGifs.Click += new System.EventHandler(this.PBGifs_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBEstado);
            this.panel1.Location = new System.Drawing.Point(257, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 25);
            this.panel1.TabIndex = 2;
            // 
            // PBOk
            // 
            this.PBOk.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBOk.Image = global::Rafit.Face.Properties.Resources.success;
            this.PBOk.Location = new System.Drawing.Point(314, 386);
            this.PBOk.Name = "PBOk";
            this.PBOk.Size = new System.Drawing.Size(88, 50);
            this.PBOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBOk.TabIndex = 13;
            this.PBOk.TabStop = false;
            this.PBOk.Visible = false;
            this.PBOk.Click += new System.EventHandler(this.PBOk_Click);
            // 
            // CargandoEnviarMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 587);
            this.Controls.Add(this.PBOk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBGifs);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CargandoEnviarMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargandoEnviarMensaje";
            ((System.ComponentModel.ISupportInitialize)(this.PBGifs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBGifs;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Label LBEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBOk;
    }
}