namespace RafitNewFace
{
    partial class frmStep1CrearFan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStep1CrearFan));
            this.MenuFoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarImagenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.IndicadorError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToolTipName = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CBGenero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBTipoDoc = new System.Windows.Forms.ComboBox();
            this.TBDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBDir = new System.Windows.Forms.Label();
            this.LBCel = new System.Windows.Forms.Label();
            this.LBFech = new System.Windows.Forms.Label();
            this.Lbtel = new System.Windows.Forms.Label();
            this.LbApe = new System.Windows.Forms.Label();
            this.LBName = new System.Windows.Forms.Label();
            this.TBTelcel = new System.Windows.Forms.TextBox();
            this.TBTelfi = new System.Windows.Forms.TextBox();
            this.DTFechanAC = new System.Windows.Forms.DateTimePicker();
            this.TBDir = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNomb = new System.Windows.Forms.TextBox();
            this.BTContinuar = new System.Windows.Forms.Button();
            this.PBImgPerf = new System.Windows.Forms.PictureBox();
            this.MenuFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndicadorError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgPerf)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuFoto
            // 
            this.MenuFoto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.MenuFoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verImagenToolStripMenuItem,
            this.cambiarImagenToolStripMenuItem,
            this.eliminarImagenToolStripMenuItem,
            this.eliminarImagenToolStripMenuItem1});
            this.MenuFoto.Name = "MenuFoto";
            this.MenuFoto.Size = new System.Drawing.Size(279, 92);
            // 
            // verImagenToolStripMenuItem
            // 
            this.verImagenToolStripMenuItem.Name = "verImagenToolStripMenuItem";
            this.verImagenToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.verImagenToolStripMenuItem.Text = "Ver Imagen";
            this.verImagenToolStripMenuItem.Click += new System.EventHandler(this.verImagenToolStripMenuItem_Click);
            // 
            // cambiarImagenToolStripMenuItem
            // 
            this.cambiarImagenToolStripMenuItem.Name = "cambiarImagenToolStripMenuItem";
            this.cambiarImagenToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.cambiarImagenToolStripMenuItem.Text = "Tomar Imagen Con Camara";
            this.cambiarImagenToolStripMenuItem.Click += new System.EventHandler(this.cambiarImagenToolStripMenuItem_Click);
            // 
            // eliminarImagenToolStripMenuItem
            // 
            this.eliminarImagenToolStripMenuItem.Name = "eliminarImagenToolStripMenuItem";
            this.eliminarImagenToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.eliminarImagenToolStripMenuItem.Text = "Seleccionar Imagen de Directorio";
            this.eliminarImagenToolStripMenuItem.Click += new System.EventHandler(this.eliminarImagenToolStripMenuItem_Click);
            // 
            // eliminarImagenToolStripMenuItem1
            // 
            this.eliminarImagenToolStripMenuItem1.Name = "eliminarImagenToolStripMenuItem1";
            this.eliminarImagenToolStripMenuItem1.Size = new System.Drawing.Size(278, 22);
            this.eliminarImagenToolStripMenuItem1.Text = "Eliminar Imagen";
            this.eliminarImagenToolStripMenuItem1.Click += new System.EventHandler(this.eliminarImagenToolStripMenuItem1_Click);
            // 
            // IndicadorError
            // 
            this.IndicadorError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.IndicadorError.ContainerControl = this;
            this.IndicadorError.Icon = ((System.Drawing.Icon)(resources.GetObject("IndicadorError.Icon")));
            // 
            // ToolTipName
            // 
            this.ToolTipName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ToolTipName.OwnerDraw = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(26, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Correo Electronico";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(29, 493);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 21);
            this.textBox1.TabIndex = 32;
            // 
            // CBGenero
            // 
            this.CBGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBGenero.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CBGenero.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CBGenero.FormattingEnabled = true;
            this.CBGenero.Items.AddRange(new object[] {
            "Indefinido",
            "Masculino",
            "Femenino"});
            this.CBGenero.Location = new System.Drawing.Point(449, 434);
            this.CBGenero.Name = "CBGenero";
            this.CBGenero.Size = new System.Drawing.Size(209, 23);
            this.CBGenero.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(449, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Genero";
            // 
            // CBTipoDoc
            // 
            this.CBTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBTipoDoc.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CBTipoDoc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CBTipoDoc.FormattingEnabled = true;
            this.CBTipoDoc.Location = new System.Drawing.Point(29, 264);
            this.CBTipoDoc.Name = "CBTipoDoc";
            this.CBTipoDoc.Size = new System.Drawing.Size(275, 23);
            this.CBTipoDoc.TabIndex = 24;
            // 
            // TBDocumento
            // 
            this.TBDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDocumento.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBDocumento.Location = new System.Drawing.Point(449, 267);
            this.TBDocumento.Name = "TBDocumento";
            this.TBDocumento.Size = new System.Drawing.Size(275, 21);
            this.TBDocumento.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(449, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "No. Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(26, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tipo de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(270, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "¿Eres Nuevo? Cuentanos Algo de Ti";
            // 
            // LBDir
            // 
            this.LBDir.AutoSize = true;
            this.LBDir.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LBDir.Location = new System.Drawing.Point(449, 471);
            this.LBDir.Name = "LBDir";
            this.LBDir.Size = new System.Drawing.Size(74, 19);
            this.LBDir.TabIndex = 39;
            this.LBDir.Text = "Direccion";
            // 
            // LBCel
            // 
            this.LBCel.AutoSize = true;
            this.LBCel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LBCel.Location = new System.Drawing.Point(26, 412);
            this.LBCel.Name = "LBCel";
            this.LBCel.Size = new System.Drawing.Size(58, 19);
            this.LBCel.TabIndex = 38;
            this.LBCel.Text = "Celular";
            // 
            // LBFech
            // 
            this.LBFech.AutoSize = true;
            this.LBFech.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LBFech.Location = new System.Drawing.Point(445, 361);
            this.LBFech.Name = "LBFech";
            this.LBFech.Size = new System.Drawing.Size(160, 19);
            this.LBFech.TabIndex = 37;
            this.LBFech.Text = "Fecha de Nacimiento";
            // 
            // Lbtel
            // 
            this.Lbtel.AutoSize = true;
            this.Lbtel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbtel.Location = new System.Drawing.Point(26, 361);
            this.Lbtel.Name = "Lbtel";
            this.Lbtel.Size = new System.Drawing.Size(66, 19);
            this.Lbtel.TabIndex = 36;
            this.Lbtel.Text = "Telefono";
            // 
            // LbApe
            // 
            this.LbApe.AutoSize = true;
            this.LbApe.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LbApe.Location = new System.Drawing.Point(445, 307);
            this.LbApe.Name = "LbApe";
            this.LbApe.Size = new System.Drawing.Size(65, 19);
            this.LbApe.TabIndex = 34;
            this.LbApe.Text = "Apellido";
            // 
            // LBName
            // 
            this.LBName.AutoSize = true;
            this.LBName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LBName.Location = new System.Drawing.Point(26, 307);
            this.LBName.Name = "LBName";
            this.LBName.Size = new System.Drawing.Size(64, 19);
            this.LBName.TabIndex = 25;
            this.LBName.Text = "Nombre";
            // 
            // TBTelcel
            // 
            this.TBTelcel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBTelcel.Location = new System.Drawing.Point(29, 434);
            this.TBTelcel.Name = "TBTelcel";
            this.TBTelcel.Size = new System.Drawing.Size(275, 21);
            this.TBTelcel.TabIndex = 31;
            // 
            // TBTelfi
            // 
            this.TBTelfi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTelfi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBTelfi.Location = new System.Drawing.Point(29, 383);
            this.TBTelfi.Name = "TBTelfi";
            this.TBTelfi.Size = new System.Drawing.Size(275, 21);
            this.TBTelfi.TabIndex = 29;
            // 
            // DTFechanAC
            // 
            this.DTFechanAC.CalendarForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DTFechanAC.CalendarTitleForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.DTFechanAC.Checked = false;
            this.DTFechanAC.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTFechanAC.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.DTFechanAC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechanAC.Location = new System.Drawing.Point(449, 383);
            this.DTFechanAC.Name = "DTFechanAC";
            this.DTFechanAC.Size = new System.Drawing.Size(156, 24);
            this.DTFechanAC.TabIndex = 30;
            // 
            // TBDir
            // 
            this.TBDir.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBDir.Location = new System.Drawing.Point(449, 493);
            this.TBDir.Name = "TBDir";
            this.TBDir.Size = new System.Drawing.Size(275, 21);
            this.TBDir.TabIndex = 33;
            // 
            // TBApellido
            // 
            this.TBApellido.BackColor = System.Drawing.SystemColors.Window;
            this.TBApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBApellido.Location = new System.Drawing.Point(449, 329);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(275, 21);
            this.TBApellido.TabIndex = 28;
            // 
            // TBNomb
            // 
            this.TBNomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNomb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBNomb.Location = new System.Drawing.Point(29, 329);
            this.TBNomb.Name = "TBNomb";
            this.TBNomb.Size = new System.Drawing.Size(275, 21);
            this.TBNomb.TabIndex = 27;
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
            this.BTContinuar.Location = new System.Drawing.Point(679, 534);
            this.BTContinuar.Name = "BTContinuar";
            this.BTContinuar.Size = new System.Drawing.Size(104, 35);
            this.BTContinuar.TabIndex = 35;
            this.BTContinuar.Text = "Continuar";
            this.BTContinuar.UseVisualStyleBackColor = false;
            this.BTContinuar.Click += new System.EventHandler(this.BTContinuar_Click);
            // 
            // PBImgPerf
            // 
            this.PBImgPerf.BackColor = System.Drawing.Color.Transparent;
            this.PBImgPerf.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBImgPerf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImgPerf.ContextMenuStrip = this.MenuFoto;
            this.PBImgPerf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBImgPerf.Image = global::Rafit.Face.Properties.Resources.icons8_Vintage_Camera_96px;
            this.PBImgPerf.Location = new System.Drawing.Point(341, 74);
            this.PBImgPerf.Name = "PBImgPerf";
            this.PBImgPerf.Size = new System.Drawing.Size(137, 137);
            this.PBImgPerf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBImgPerf.TabIndex = 23;
            this.PBImgPerf.TabStop = false;
            // 
            // FormularioAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 581);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CBGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTContinuar);
            this.Controls.Add(this.CBTipoDoc);
            this.Controls.Add(this.TBDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBDir);
            this.Controls.Add(this.LBCel);
            this.Controls.Add(this.LBFech);
            this.Controls.Add(this.Lbtel);
            this.Controls.Add(this.LbApe);
            this.Controls.Add(this.LBName);
            this.Controls.Add(this.TBTelcel);
            this.Controls.Add(this.TBTelfi);
            this.Controls.Add(this.DTFechanAC);
            this.Controls.Add(this.TBDir);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBNomb);
            this.Controls.Add(this.PBImgPerf);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioAfiliado";
            this.MenuFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IndicadorError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgPerf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip MenuFoto;
        private System.Windows.Forms.ToolStripMenuItem verImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarImagenToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider IndicadorError;
        private System.Windows.Forms.ToolTip ToolTipName;
        private System.Windows.Forms.ToolStripMenuItem eliminarImagenToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CBGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTContinuar;
        private System.Windows.Forms.ComboBox CBTipoDoc;
        private System.Windows.Forms.TextBox TBDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBDir;
        private System.Windows.Forms.Label LBCel;
        private System.Windows.Forms.Label LBFech;
        private System.Windows.Forms.Label Lbtel;
        private System.Windows.Forms.Label LbApe;
        private System.Windows.Forms.Label LBName;
        private System.Windows.Forms.TextBox TBTelcel;
        private System.Windows.Forms.TextBox TBTelfi;
        private System.Windows.Forms.DateTimePicker DTFechanAC;
        private System.Windows.Forms.TextBox TBDir;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNomb;
        public System.Windows.Forms.PictureBox PBImgPerf;
    }
}