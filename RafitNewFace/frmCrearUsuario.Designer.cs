namespace RafitNewFace
{
    partial class frmCrearUsuario
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
            this.LBIntroduccion = new System.Windows.Forms.Label();
            this.LBDNombre = new System.Windows.Forms.Label();
            this.LBDApellido = new System.Windows.Forms.Label();
            this.LBDUsuario = new System.Windows.Forms.Label();
            this.LBDContra = new System.Windows.Forms.Label();
            this.LBDConfirmContra = new System.Windows.Forms.Label();
            this.LBDRoles = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBuSUARIO = new System.Windows.Forms.TextBox();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.TBConfirmContra = new System.Windows.Forms.TextBox();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.MenuPerfil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seleccionarNuevaImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrediseñadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarImagenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LBDFoto = new System.Windows.Forms.Label();
            this.PBImgPerf = new System.Windows.Forms.PictureBox();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.BTGuardar = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.MenuPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgPerf)).BeginInit();
            this.SuspendLayout();
            // 
            // LBIntroduccion
            // 
            this.LBIntroduccion.AutoSize = true;
            this.LBIntroduccion.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.LBIntroduccion.Location = new System.Drawing.Point(327, 35);
            this.LBIntroduccion.Name = "LBIntroduccion";
            this.LBIntroduccion.Size = new System.Drawing.Size(362, 23);
            this.LBIntroduccion.TabIndex = 0;
            this.LBIntroduccion.Text = "¿Un Nuevo Usuario? Esto sera Breve!";
            // 
            // LBDNombre
            // 
            this.LBDNombre.AutoSize = true;
            this.LBDNombre.Location = new System.Drawing.Point(394, 180);
            this.LBDNombre.Name = "LBDNombre";
            this.LBDNombre.Size = new System.Drawing.Size(57, 16);
            this.LBDNombre.TabIndex = 2;
            this.LBDNombre.Text = "Nombre: ";
            // 
            // LBDApellido
            // 
            this.LBDApellido.AutoSize = true;
            this.LBDApellido.Location = new System.Drawing.Point(394, 223);
            this.LBDApellido.Name = "LBDApellido";
            this.LBDApellido.Size = new System.Drawing.Size(57, 16);
            this.LBDApellido.TabIndex = 3;
            this.LBDApellido.Text = "Apellido: ";
            // 
            // LBDUsuario
            // 
            this.LBDUsuario.AutoSize = true;
            this.LBDUsuario.Location = new System.Drawing.Point(394, 264);
            this.LBDUsuario.Name = "LBDUsuario";
            this.LBDUsuario.Size = new System.Drawing.Size(117, 16);
            this.LBDUsuario.TabIndex = 4;
            this.LBDUsuario.Text = "Nombre de Usuario: ";
            // 
            // LBDContra
            // 
            this.LBDContra.AutoSize = true;
            this.LBDContra.Location = new System.Drawing.Point(394, 307);
            this.LBDContra.Name = "LBDContra";
            this.LBDContra.Size = new System.Drawing.Size(75, 16);
            this.LBDContra.TabIndex = 5;
            this.LBDContra.Text = "Contraseña:";
            // 
            // LBDConfirmContra
            // 
            this.LBDConfirmContra.AutoSize = true;
            this.LBDConfirmContra.Location = new System.Drawing.Point(394, 348);
            this.LBDConfirmContra.Name = "LBDConfirmContra";
            this.LBDConfirmContra.Size = new System.Drawing.Size(145, 16);
            this.LBDConfirmContra.TabIndex = 6;
            this.LBDConfirmContra.Text = "Confirma Tu Contraseña: ";
            // 
            // LBDRoles
            // 
            this.LBDRoles.AutoSize = true;
            this.LBDRoles.Location = new System.Drawing.Point(397, 396);
            this.LBDRoles.Name = "LBDRoles";
            this.LBDRoles.Size = new System.Drawing.Size(179, 16);
            this.LBDRoles.TabIndex = 7;
            this.LBDRoles.Text = "Que Nivel de Permisos Tendras?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(346, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(315, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Por favor, Cuentanos quien es el Nuevo";
            // 
            // TBNombre
            // 
            this.TBNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBNombre.Location = new System.Drawing.Point(592, 175);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(325, 21);
            this.TBNombre.TabIndex = 9;
            // 
            // TBApellido
            // 
            this.TBApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBApellido.Location = new System.Drawing.Point(592, 220);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(325, 21);
            this.TBApellido.TabIndex = 10;
            // 
            // TBuSUARIO
            // 
            this.TBuSUARIO.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBuSUARIO.Location = new System.Drawing.Point(592, 261);
            this.TBuSUARIO.Name = "TBuSUARIO";
            this.TBuSUARIO.Size = new System.Drawing.Size(325, 21);
            this.TBuSUARIO.TabIndex = 11;
            // 
            // TBContraseña
            // 
            this.TBContraseña.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBContraseña.Location = new System.Drawing.Point(592, 304);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(325, 21);
            this.TBContraseña.TabIndex = 12;
            // 
            // TBConfirmContra
            // 
            this.TBConfirmContra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBConfirmContra.Location = new System.Drawing.Point(592, 345);
            this.TBConfirmContra.Name = "TBConfirmContra";
            this.TBConfirmContra.Size = new System.Drawing.Size(325, 21);
            this.TBConfirmContra.TabIndex = 13;
            // 
            // CBRol
            // 
            this.CBRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(592, 390);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(325, 24);
            this.CBRol.TabIndex = 14;
            // 
            // MenuPerfil
            // 
            this.MenuPerfil.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.MenuPerfil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarNuevaImagenToolStripMenuItem,
            this.verImagenToolStripMenuItem,
            this.PrediseñadaToolStripMenuItem,
            this.eliminarImagenToolStripMenuItem1});
            this.MenuPerfil.Name = "MenuPerfil";
            this.MenuPerfil.Size = new System.Drawing.Size(226, 92);
            // 
            // seleccionarNuevaImagenToolStripMenuItem
            // 
            this.seleccionarNuevaImagenToolStripMenuItem.Name = "seleccionarNuevaImagenToolStripMenuItem";
            this.seleccionarNuevaImagenToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.seleccionarNuevaImagenToolStripMenuItem.Text = "Seleccionar Nueva Imagen";
            this.seleccionarNuevaImagenToolStripMenuItem.Click += new System.EventHandler(this.seleccionarNuevaImagenToolStripMenuItem_Click);
            // 
            // verImagenToolStripMenuItem
            // 
            this.verImagenToolStripMenuItem.Name = "verImagenToolStripMenuItem";
            this.verImagenToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.verImagenToolStripMenuItem.Text = "Ver Imagen";
            this.verImagenToolStripMenuItem.Click += new System.EventHandler(this.verImagenToolStripMenuItem_Click);
            // 
            // PrediseñadaToolStripMenuItem
            // 
            this.PrediseñadaToolStripMenuItem.Name = "PrediseñadaToolStripMenuItem";
            this.PrediseñadaToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.PrediseñadaToolStripMenuItem.Text = "Imagen Prediseñada";
            this.PrediseñadaToolStripMenuItem.Click += new System.EventHandler(this.PrediseñadaToolStripMenuItem_Click);
            // 
            // eliminarImagenToolStripMenuItem1
            // 
            this.eliminarImagenToolStripMenuItem1.Name = "eliminarImagenToolStripMenuItem1";
            this.eliminarImagenToolStripMenuItem1.Size = new System.Drawing.Size(225, 22);
            this.eliminarImagenToolStripMenuItem1.Text = "Eliminar Imagen";
            this.eliminarImagenToolStripMenuItem1.Click += new System.EventHandler(this.eliminarImagenToolStripMenuItem1_Click);
            // 
            // LBDFoto
            // 
            this.LBDFoto.AutoSize = true;
            this.LBDFoto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.LBDFoto.Location = new System.Drawing.Point(76, 141);
            this.LBDFoto.Name = "LBDFoto";
            this.LBDFoto.Size = new System.Drawing.Size(189, 17);
            this.LBDFoto.TabIndex = 20;
            this.LBDFoto.Text = "¿Quieres Cargar Una Foto?";
            // 
            // PBImgPerf
            // 
            this.PBImgPerf.BackColor = System.Drawing.Color.Transparent;
            this.PBImgPerf.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBImgPerf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImgPerf.ContextMenuStrip = this.MenuPerfil;
            this.PBImgPerf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBImgPerf.Image = global::Rafit.Face.Properties.Resources.icons8_Vintage_Camera_96px;
            this.PBImgPerf.Location = new System.Drawing.Point(63, 175);
            this.PBImgPerf.Name = "PBImgPerf";
            this.PBImgPerf.Size = new System.Drawing.Size(207, 221);
            this.PBImgPerf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBImgPerf.TabIndex = 18;
            this.PBImgPerf.TabStop = false;
            this.PBImgPerf.Tag = "0";
            this.PBImgPerf.Click += new System.EventHandler(this.PBImgPerf_Click);
            // 
            // BTGuardar
            // 
            this.BTGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.BTGuardar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.BTGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTGuardar.FlatAppearance.BorderSize = 0;
            this.BTGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGuardar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.BTGuardar.ForeColor = System.Drawing.Color.White;
            this.BTGuardar.Location = new System.Drawing.Point(633, 474);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(140, 73);
            this.BTGuardar.TabIndex = 21;
            this.BTGuardar.Text = "Guardar";
            this.BTGuardar.UseVisualStyleBackColor = false;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // BTCancelar
            // 
            this.BTCancelar.BackColor = System.Drawing.Color.Crimson;
            this.BTCancelar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCancelar.FlatAppearance.BorderSize = 0;
            this.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCancelar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.BTCancelar.ForeColor = System.Drawing.Color.White;
            this.BTCancelar.Location = new System.Drawing.Point(229, 474);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(140, 73);
            this.BTCancelar.TabIndex = 22;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = false;
            this.BTCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 581);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.BTGuardar);
            this.Controls.Add(this.LBDFoto);
            this.Controls.Add(this.PBImgPerf);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.TBConfirmContra);
            this.Controls.Add(this.TBContraseña);
            this.Controls.Add(this.TBuSUARIO);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LBDRoles);
            this.Controls.Add(this.LBDConfirmContra);
            this.Controls.Add(this.LBDContra);
            this.Controls.Add(this.LBDUsuario);
            this.Controls.Add(this.LBDApellido);
            this.Controls.Add(this.LBDNombre);
            this.Controls.Add(this.LBIntroduccion);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioUsuario";
            this.MenuPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBImgPerf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBIntroduccion;
        private System.Windows.Forms.Label LBDNombre;
        private System.Windows.Forms.Label LBDApellido;
        private System.Windows.Forms.Label LBDUsuario;
        private System.Windows.Forms.Label LBDContra;
        private System.Windows.Forms.Label LBDConfirmContra;
        private System.Windows.Forms.Label LBDRoles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBuSUARIO;
        private System.Windows.Forms.TextBox TBContraseña;
        private System.Windows.Forms.TextBox TBConfirmContra;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.ContextMenuStrip MenuPerfil;
        private System.Windows.Forms.ToolStripMenuItem seleccionarNuevaImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrediseñadaToolStripMenuItem;
        private System.Windows.Forms.Label LBDFoto;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.ToolStripMenuItem eliminarImagenToolStripMenuItem1;
        public System.Windows.Forms.PictureBox PBImgPerf;
    }
}