namespace RafitNewFace
{
    partial class Visor_de_Imagenes
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
            this.PBVisorImagen = new System.Windows.Forms.PictureBox();
            this.PBCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBVisorImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PBVisorImagen
            // 
            this.PBVisorImagen.BackColor = System.Drawing.Color.Transparent;
            this.PBVisorImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBVisorImagen.Location = new System.Drawing.Point(0, 0);
            this.PBVisorImagen.Name = "PBVisorImagen";
            this.PBVisorImagen.Size = new System.Drawing.Size(420, 441);
            this.PBVisorImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBVisorImagen.TabIndex = 0;
            this.PBVisorImagen.TabStop = false;
            // 
            // PBCerrar
            // 
            this.PBCerrar.BackColor = System.Drawing.Color.Transparent;
            this.PBCerrar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBCerrar.Image = global::Rafit.Face.Properties.Resources.error;
            this.PBCerrar.Location = new System.Drawing.Point(367, 13);
            this.PBCerrar.Name = "PBCerrar";
            this.PBCerrar.Size = new System.Drawing.Size(41, 34);
            this.PBCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCerrar.TabIndex = 1;
            this.PBCerrar.TabStop = false;
            this.PBCerrar.Click += new System.EventHandler(this.PBCerrar_Click);
            // 
            // Visor_de_Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 441);
            this.Controls.Add(this.PBCerrar);
            this.Controls.Add(this.PBVisorImagen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visor_de_Imagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor_de_Imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.PBVisorImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PBVisorImagen;
        private System.Windows.Forms.PictureBox PBCerrar;
    }
}