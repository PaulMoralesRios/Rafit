namespace RafitNewFace
{
    partial class frmVisorCamara
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
            this.CBCamarasDisponibles = new System.Windows.Forms.ComboBox();
            this.PBCerrar = new System.Windows.Forms.PictureBox();
            this.PBConfiguracion = new System.Windows.Forms.PictureBox();
            this.BTIniciar = new System.Windows.Forms.PictureBox();
            this.PBVideoImage = new System.Windows.Forms.PictureBox();
            this.PNConfirmacion = new System.Windows.Forms.Panel();
            this.PBAceptar = new System.Windows.Forms.PictureBox();
            this.PBCancel = new System.Windows.Forms.PictureBox();
            this.LbMensajeConf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVideoImage)).BeginInit();
            this.PNConfirmacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // CBCamarasDisponibles
            // 
            this.CBCamarasDisponibles.BackColor = System.Drawing.Color.White;
            this.CBCamarasDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCamarasDisponibles.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CBCamarasDisponibles.FormattingEnabled = true;
            this.CBCamarasDisponibles.Location = new System.Drawing.Point(79, 478);
            this.CBCamarasDisponibles.Name = "CBCamarasDisponibles";
            this.CBCamarasDisponibles.Size = new System.Drawing.Size(440, 25);
            this.CBCamarasDisponibles.TabIndex = 3;
            this.CBCamarasDisponibles.Visible = false;
            // 
            // PBCerrar
            // 
            this.PBCerrar.BackColor = System.Drawing.Color.Transparent;
            this.PBCerrar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBCerrar.Image = global::Rafit.Face.Properties.Resources.error;
            this.PBCerrar.Location = new System.Drawing.Point(655, 12);
            this.PBCerrar.Name = "PBCerrar";
            this.PBCerrar.Size = new System.Drawing.Size(48, 38);
            this.PBCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCerrar.TabIndex = 4;
            this.PBCerrar.TabStop = false;
            this.PBCerrar.Click += new System.EventHandler(this.PBCerrar_Click);
            // 
            // PBConfiguracion
            // 
            this.PBConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.PBConfiguracion.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBConfiguracion.Image = global::Rafit.Face.Properties.Resources.icons8_Settings_96px;
            this.PBConfiguracion.Location = new System.Drawing.Point(25, 465);
            this.PBConfiguracion.Name = "PBConfiguracion";
            this.PBConfiguracion.Size = new System.Drawing.Size(48, 38);
            this.PBConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBConfiguracion.TabIndex = 2;
            this.PBConfiguracion.TabStop = false;
            this.PBConfiguracion.Click += new System.EventHandler(this.PBConfiguracion_Click);
            // 
            // BTIniciar
            // 
            this.BTIniciar.BackColor = System.Drawing.Color.Transparent;
            this.BTIniciar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.BTIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTIniciar.Image = global::Rafit.Face.Properties.Resources.icons8_Unsplash_104px;
            this.BTIniciar.Location = new System.Drawing.Point(610, 440);
            this.BTIniciar.Name = "BTIniciar";
            this.BTIniciar.Size = new System.Drawing.Size(75, 63);
            this.BTIniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTIniciar.TabIndex = 1;
            this.BTIniciar.TabStop = false;
            this.BTIniciar.Click += new System.EventHandler(this.BTIniciar_Click);
            // 
            // PBVideoImage
            // 
            this.PBVideoImage.BackColor = System.Drawing.Color.Transparent;
            this.PBVideoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBVideoImage.Location = new System.Drawing.Point(0, 0);
            this.PBVideoImage.Name = "PBVideoImage";
            this.PBVideoImage.Size = new System.Drawing.Size(715, 526);
            this.PBVideoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBVideoImage.TabIndex = 0;
            this.PBVideoImage.TabStop = false;
            // 
            // PNConfirmacion
            // 
            this.PNConfirmacion.BackColor = System.Drawing.Color.Transparent;
            this.PNConfirmacion.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PNConfirmacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNConfirmacion.Controls.Add(this.PBAceptar);
            this.PNConfirmacion.Controls.Add(this.PBCancel);
            this.PNConfirmacion.Controls.Add(this.LbMensajeConf);
            this.PNConfirmacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PNConfirmacion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PNConfirmacion.Location = new System.Drawing.Point(120, 360);
            this.PNConfirmacion.Name = "PNConfirmacion";
            this.PNConfirmacion.Size = new System.Drawing.Size(432, 100);
            this.PNConfirmacion.TabIndex = 5;
            this.PNConfirmacion.Visible = false;
            // 
            // PBAceptar
            // 
            this.PBAceptar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBAceptar.Image = global::Rafit.Face.Properties.Resources.success;
            this.PBAceptar.Location = new System.Drawing.Point(306, 48);
            this.PBAceptar.Name = "PBAceptar";
            this.PBAceptar.Size = new System.Drawing.Size(58, 41);
            this.PBAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAceptar.TabIndex = 5;
            this.PBAceptar.TabStop = false;
            this.PBAceptar.Click += new System.EventHandler(this.PBAceptar_Click);
            // 
            // PBCancel
            // 
            this.PBCancel.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBCancel.Image = global::Rafit.Face.Properties.Resources.icons8_Delete_48px;
            this.PBCancel.Location = new System.Drawing.Point(83, 48);
            this.PBCancel.Name = "PBCancel";
            this.PBCancel.Size = new System.Drawing.Size(58, 41);
            this.PBCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCancel.TabIndex = 4;
            this.PBCancel.TabStop = false;
            this.PBCancel.Click += new System.EventHandler(this.PBCancel_Click);
            // 
            // LbMensajeConf
            // 
            this.LbMensajeConf.AutoSize = true;
            this.LbMensajeConf.Location = new System.Drawing.Point(125, 12);
            this.LbMensajeConf.Name = "LbMensajeConf";
            this.LbMensajeConf.Size = new System.Drawing.Size(200, 21);
            this.LbMensajeConf.TabIndex = 3;
            this.LbMensajeConf.Text = "¿Quedo Bien en la Foto?";
            // 
            // VisorCamara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 526);
            this.Controls.Add(this.PNConfirmacion);
            this.Controls.Add(this.PBCerrar);
            this.Controls.Add(this.CBCamarasDisponibles);
            this.Controls.Add(this.PBConfiguracion);
            this.Controls.Add(this.BTIniciar);
            this.Controls.Add(this.PBVideoImage);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VisorCamara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisorCamara";
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVideoImage)).EndInit();
            this.PNConfirmacion.ResumeLayout(false);
            this.PNConfirmacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox BTIniciar;
        private System.Windows.Forms.PictureBox PBConfiguracion;
        private System.Windows.Forms.ComboBox CBCamarasDisponibles;
        private System.Windows.Forms.PictureBox PBCerrar;
        private System.Windows.Forms.Panel PNConfirmacion;
        private System.Windows.Forms.PictureBox PBAceptar;
        private System.Windows.Forms.PictureBox PBCancel;
        private System.Windows.Forms.Label LbMensajeConf;
        public System.Windows.Forms.PictureBox PBVideoImage;
    }
}