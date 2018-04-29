namespace RafitNewFace
{
    partial class frmCrearMembresia
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBNombMemb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBDuracion = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CBTipoDuracion = new System.Windows.Forms.ComboBox();
            this.RTDescripcionMemb = new System.Windows.Forms.RichTextBox();
            this.LBMoneda = new System.Windows.Forms.Label();
            this.LBSignoMon = new System.Windows.Forms.Label();
            this.PBImagenMemb = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MenuFoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarImagenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenMemb)).BeginInit();
            this.MenuFoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(218, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Membresia";
            // 
            // TBNombMemb
            // 
            this.TBNombMemb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNombMemb.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TBNombMemb.Location = new System.Drawing.Point(81, 143);
            this.TBNombMemb.Name = "TBNombMemb";
            this.TBNombMemb.Size = new System.Drawing.Size(451, 24);
            this.TBNombMemb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(250, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(163, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duracion";
            // 
            // TBDuracion
            // 
            this.TBDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDuracion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TBDuracion.Location = new System.Drawing.Point(81, 357);
            this.TBDuracion.Name = "TBDuracion";
            this.TBDuracion.Size = new System.Drawing.Size(269, 24);
            this.TBDuracion.TabIndex = 6;
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Precio.Location = new System.Drawing.Point(250, 399);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(55, 19);
            this.Precio.TabIndex = 9;
            this.Precio.Text = "Precio ";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBox4.Location = new System.Drawing.Point(121, 421);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(317, 24);
            this.textBox4.TabIndex = 8;
            // 
            // CBTipoDuracion
            // 
            this.CBTipoDuracion.BackColor = System.Drawing.Color.White;
            this.CBTipoDuracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoDuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBTipoDuracion.FormattingEnabled = true;
            this.CBTipoDuracion.Items.AddRange(new object[] {
            "Dias",
            "Meses",
            "Años"});
            this.CBTipoDuracion.Location = new System.Drawing.Point(396, 354);
            this.CBTipoDuracion.Name = "CBTipoDuracion";
            this.CBTipoDuracion.Size = new System.Drawing.Size(136, 24);
            this.CBTipoDuracion.TabIndex = 10;
            // 
            // RTDescripcionMemb
            // 
            this.RTDescripcionMemb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTDescripcionMemb.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.RTDescripcionMemb.Location = new System.Drawing.Point(81, 219);
            this.RTDescripcionMemb.Name = "RTDescripcionMemb";
            this.RTDescripcionMemb.Size = new System.Drawing.Size(451, 96);
            this.RTDescripcionMemb.TabIndex = 11;
            this.RTDescripcionMemb.Text = "";
            // 
            // LBMoneda
            // 
            this.LBMoneda.AutoSize = true;
            this.LBMoneda.Location = new System.Drawing.Point(473, 428);
            this.LBMoneda.Name = "LBMoneda";
            this.LBMoneda.Size = new System.Drawing.Size(69, 16);
            this.LBMoneda.TabIndex = 12;
            this.LBMoneda.Text = "COL/M.cte";
            // 
            // LBSignoMon
            // 
            this.LBSignoMon.AutoSize = true;
            this.LBSignoMon.Location = new System.Drawing.Point(78, 421);
            this.LBSignoMon.Name = "LBSignoMon";
            this.LBSignoMon.Size = new System.Drawing.Size(14, 16);
            this.LBSignoMon.TabIndex = 13;
            this.LBSignoMon.Text = "$";
            // 
            // PBImagenMemb
            // 
            this.PBImagenMemb.BackColor = System.Drawing.Color.Transparent;
            this.PBImagenMemb.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBImagenMemb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImagenMemb.ContextMenuStrip = this.MenuFoto;
            this.PBImagenMemb.Image = global::Rafit.Face.Properties.Resources.icons8_Gold_Medal_96px;
            this.PBImagenMemb.Location = new System.Drawing.Point(575, 113);
            this.PBImagenMemb.Name = "PBImagenMemb";
            this.PBImagenMemb.Size = new System.Drawing.Size(199, 202);
            this.PBImagenMemb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBImagenMemb.TabIndex = 14;
            this.PBImagenMemb.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(615, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(49, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(570, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Es Hora de crear una Membresia para Aplicar los Cobros:";
            // 
            // MenuFoto
            // 
            this.MenuFoto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.MenuFoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verImagenToolStripMenuItem,
            this.eliminarImagenToolStripMenuItem,
            this.eliminarImagenToolStripMenuItem1});
            this.MenuFoto.Name = "MenuFoto";
            this.MenuFoto.Size = new System.Drawing.Size(279, 70);
            // 
            // verImagenToolStripMenuItem
            // 
            this.verImagenToolStripMenuItem.Name = "verImagenToolStripMenuItem";
            this.verImagenToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.verImagenToolStripMenuItem.Text = "Ver Imagen";
            this.verImagenToolStripMenuItem.Click += new System.EventHandler(this.verImagenToolStripMenuItem_Click);
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
            // FormMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 525);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PBImagenMemb);
            this.Controls.Add(this.LBSignoMon);
            this.Controls.Add(this.LBMoneda);
            this.Controls.Add(this.RTDescripcionMemb);
            this.Controls.Add(this.CBTipoDuracion);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBDuracion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBNombMemb);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMembresia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMembresia";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenMemb)).EndInit();
            this.MenuFoto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNombMemb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBDuracion;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox CBTipoDuracion;
        private System.Windows.Forms.RichTextBox RTDescripcionMemb;
        private System.Windows.Forms.Label LBMoneda;
        private System.Windows.Forms.Label LBSignoMon;
        private System.Windows.Forms.PictureBox PBImagenMemb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip MenuFoto;
        private System.Windows.Forms.ToolStripMenuItem verImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarImagenToolStripMenuItem1;
    }
}