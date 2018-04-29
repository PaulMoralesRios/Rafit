namespace RafitNewFace
{
    partial class Inicio_Sesion
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
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.ErrorUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.LBUsuario = new System.Windows.Forms.Label();
            this.LBContraseña = new System.Windows.Forms.Label();
            this.LBMensajealerta = new System.Windows.Forms.Label();
            this.LBMensajeError = new System.Windows.Forms.Label();
            this.PBiconerror = new System.Windows.Forms.PictureBox();
            this.PBIconoAlerta = new System.Windows.Forms.PictureBox();
            this.PBCerrar = new System.Windows.Forms.PictureBox();
            this.BTInicioSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBiconerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIconoAlerta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // TBusuario
            // 
            this.TBusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBusuario.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.TBusuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBusuario.Location = new System.Drawing.Point(366, 187);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(276, 21);
            this.TBusuario.TabIndex = 0;
            this.TBusuario.Text = "Usuario";
            this.TBusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBContraseña
            // 
            this.TBContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBContraseña.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.TBContraseña.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBContraseña.Location = new System.Drawing.Point(366, 253);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(276, 21);
            this.TBContraseña.TabIndex = 1;
            this.TBContraseña.Text = "Contraseña";
            this.TBContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrorUsuario
            // 
            this.ErrorUsuario.ContainerControl = this;
            // 
            // ErrorContraseña
            // 
            this.ErrorContraseña.ContainerControl = this;
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LBUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.LBUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LBUsuario.Location = new System.Drawing.Point(476, 165);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(57, 17);
            this.LBUsuario.TabIndex = 4;
            this.LBUsuario.Text = "Usuario";
            this.LBUsuario.Visible = false;
            // 
            // LBContraseña
            // 
            this.LBContraseña.AutoSize = true;
            this.LBContraseña.BackColor = System.Drawing.Color.Transparent;
            this.LBContraseña.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.LBContraseña.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LBContraseña.Location = new System.Drawing.Point(459, 231);
            this.LBContraseña.Name = "LBContraseña";
            this.LBContraseña.Size = new System.Drawing.Size(85, 17);
            this.LBContraseña.TabIndex = 5;
            this.LBContraseña.Text = "Contraseña";
            this.LBContraseña.Visible = false;
            // 
            // LBMensajealerta
            // 
            this.LBMensajealerta.AutoSize = true;
            this.LBMensajealerta.BackColor = System.Drawing.Color.Transparent;
            this.LBMensajealerta.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.LBMensajealerta.ForeColor = System.Drawing.Color.Gold;
            this.LBMensajealerta.Location = new System.Drawing.Point(399, 297);
            this.LBMensajealerta.Name = "LBMensajealerta";
            this.LBMensajealerta.Size = new System.Drawing.Size(193, 15);
            this.LBMensajealerta.TabIndex = 7;
            this.LBMensajealerta.Text = "Por Favor Ingrese las Credenciales";
            this.LBMensajealerta.Visible = false;
            // 
            // LBMensajeError
            // 
            this.LBMensajeError.AutoSize = true;
            this.LBMensajeError.BackColor = System.Drawing.Color.Transparent;
            this.LBMensajeError.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.LBMensajeError.ForeColor = System.Drawing.Color.Crimson;
            this.LBMensajeError.Location = new System.Drawing.Point(399, 313);
            this.LBMensajeError.Name = "LBMensajeError";
            this.LBMensajeError.Size = new System.Drawing.Size(267, 15);
            this.LBMensajeError.TabIndex = 9;
            this.LBMensajeError.Text = "Informacion de Usuario y Contraseña Incorrectas";
            this.LBMensajeError.Visible = false;
            // 
            // PBiconerror
            // 
            this.PBiconerror.BackColor = System.Drawing.Color.Transparent;
            this.PBiconerror.BackgroundImage = global::Rafit.Face.Properties.Resources.error;
            this.PBiconerror.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBiconerror.Location = new System.Drawing.Point(366, 304);
            this.PBiconerror.Name = "PBiconerror";
            this.PBiconerror.Size = new System.Drawing.Size(27, 25);
            this.PBiconerror.TabIndex = 10;
            this.PBiconerror.TabStop = false;
            this.PBiconerror.Visible = false;
            // 
            // PBIconoAlerta
            // 
            this.PBIconoAlerta.BackColor = System.Drawing.Color.Transparent;
            this.PBIconoAlerta.BackgroundImage = global::Rafit.Face.Properties.Resources.warning;
            this.PBIconoAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBIconoAlerta.Location = new System.Drawing.Point(366, 288);
            this.PBIconoAlerta.Name = "PBIconoAlerta";
            this.PBIconoAlerta.Size = new System.Drawing.Size(27, 25);
            this.PBIconoAlerta.TabIndex = 8;
            this.PBIconoAlerta.TabStop = false;
            this.PBIconoAlerta.Visible = false;
            // 
            // PBCerrar
            // 
            this.PBCerrar.BackColor = System.Drawing.Color.Transparent;
            this.PBCerrar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBCerrar.Image = global::Rafit.Face.Properties.Resources.red_x;
            this.PBCerrar.Location = new System.Drawing.Point(995, 12);
            this.PBCerrar.Name = "PBCerrar";
            this.PBCerrar.Size = new System.Drawing.Size(33, 33);
            this.PBCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCerrar.TabIndex = 6;
            this.PBCerrar.TabStop = false;
            this.PBCerrar.Click += new System.EventHandler(this.PBCerrar_Click);
            // 
            // BTInicioSesion
            // 
            this.BTInicioSesion.BackColor = System.Drawing.Color.LightGreen;
            this.BTInicioSesion.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.BTInicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTInicioSesion.FlatAppearance.BorderSize = 0;
            this.BTInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.BTInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTInicioSesion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BTInicioSesion.ForeColor = System.Drawing.Color.White;
            this.BTInicioSesion.Location = new System.Drawing.Point(436, 384);
            this.BTInicioSesion.Name = "BTInicioSesion";
            this.BTInicioSesion.Size = new System.Drawing.Size(154, 43);
            this.BTInicioSesion.TabIndex = 2;
            this.BTInicioSesion.Text = "Iniciar Sesion";
            this.BTInicioSesion.UseVisualStyleBackColor = false;
            this.BTInicioSesion.Click += new System.EventHandler(this.BTInicioSesion_Click);
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 581);
            this.Controls.Add(this.PBiconerror);
            this.Controls.Add(this.LBMensajeError);
            this.Controls.Add(this.PBIconoAlerta);
            this.Controls.Add(this.LBMensajealerta);
            this.Controls.Add(this.PBCerrar);
            this.Controls.Add(this.LBContraseña);
            this.Controls.Add(this.LBUsuario);
            this.Controls.Add(this.BTInicioSesion);
            this.Controls.Add(this.TBContraseña);
            this.Controls.Add(this.TBusuario);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio_Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBiconerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIconoAlerta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTInicioSesion;
        private System.Windows.Forms.TextBox TBContraseña;
        private System.Windows.Forms.TextBox TBusuario;
        private System.Windows.Forms.ErrorProvider ErrorUsuario;
        private System.Windows.Forms.ErrorProvider ErrorContraseña;
        private System.Windows.Forms.Label LBContraseña;
        private System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.PictureBox PBCerrar;
        private System.Windows.Forms.PictureBox PBIconoAlerta;
        private System.Windows.Forms.Label LBMensajealerta;
        private System.Windows.Forms.PictureBox PBiconerror;
        private System.Windows.Forms.Label LBMensajeError;
    }
}