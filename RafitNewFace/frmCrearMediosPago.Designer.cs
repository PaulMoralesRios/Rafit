namespace RafitNewFace
{
    partial class frmCrearMediosPago
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PBImagenMP = new System.Windows.Forms.PictureBox();
            this.MenuImagen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seleccionarNuevaImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarImagenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.TBNombreMedio = new System.Windows.Forms.TextBox();
            this.RTDescMedio = new System.Windows.Forms.RichTextBox();
            this.CBComportamiento = new System.Windows.Forms.ComboBox();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenMP)).BeginInit();
            this.MenuImagen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(73, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Medio de Pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(73, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "____________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(74, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Medio de Pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(74, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion:";
            // 
            // PBImagenMP
            // 
            this.PBImagenMP.BackColor = System.Drawing.Color.Transparent;
            this.PBImagenMP.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBImagenMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImagenMP.ContextMenuStrip = this.MenuImagen;
            this.PBImagenMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBImagenMP.Image = global::Rafit.Face.Properties.Resources.icons8_Vintage_Camera_96px;
            this.PBImagenMP.Location = new System.Drawing.Point(428, 174);
            this.PBImagenMP.Name = "PBImagenMP";
            this.PBImagenMP.Size = new System.Drawing.Size(178, 163);
            this.PBImagenMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBImagenMP.TabIndex = 19;
            this.PBImagenMP.TabStop = false;
            this.PBImagenMP.Tag = "0";
            // 
            // MenuImagen
            // 
            this.MenuImagen.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.MenuImagen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarNuevaImagenToolStripMenuItem,
            this.verImagenToolStripMenuItem,
            this.eliminarImagenToolStripMenuItem1});
            this.MenuImagen.Name = "MenuPerfil";
            this.MenuImagen.Size = new System.Drawing.Size(226, 70);
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
            // eliminarImagenToolStripMenuItem1
            // 
            this.eliminarImagenToolStripMenuItem1.Name = "eliminarImagenToolStripMenuItem1";
            this.eliminarImagenToolStripMenuItem1.Size = new System.Drawing.Size(225, 22);
            this.eliminarImagenToolStripMenuItem1.Text = "Eliminar Imagen";
            this.eliminarImagenToolStripMenuItem1.Click += new System.EventHandler(this.eliminarImagenToolStripMenuItem1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(74, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tipo:";
            // 
            // TBNombreMedio
            // 
            this.TBNombreMedio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TBNombreMedio.Location = new System.Drawing.Point(77, 174);
            this.TBNombreMedio.Name = "TBNombreMedio";
            this.TBNombreMedio.Size = new System.Drawing.Size(292, 21);
            this.TBNombreMedio.TabIndex = 22;
            // 
            // RTDescMedio
            // 
            this.RTDescMedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTDescMedio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RTDescMedio.Location = new System.Drawing.Point(77, 223);
            this.RTDescMedio.MaxLength = 50;
            this.RTDescMedio.Name = "RTDescMedio";
            this.RTDescMedio.Size = new System.Drawing.Size(292, 96);
            this.RTDescMedio.TabIndex = 23;
            this.RTDescMedio.Text = "";
            // 
            // CBComportamiento
            // 
            this.CBComportamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBComportamiento.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CBComportamiento.FormattingEnabled = true;
            this.CBComportamiento.Location = new System.Drawing.Point(77, 353);
            this.CBComportamiento.Name = "CBComportamiento";
            this.CBComportamiento.Size = new System.Drawing.Size(292, 24);
            this.CBComportamiento.TabIndex = 24;
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
            this.BTGuardar.Location = new System.Drawing.Point(374, 435);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(104, 35);
            this.BTGuardar.TabIndex = 36;
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
            this.BTCancelar.Location = new System.Drawing.Point(199, 435);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(104, 35);
            this.BTCancelar.TabIndex = 37;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = false;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // FormCrearMediosPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 502);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.BTGuardar);
            this.Controls.Add(this.CBComportamiento);
            this.Controls.Add(this.RTDescMedio);
            this.Controls.Add(this.TBNombreMedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PBImagenMP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCrearMediosPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCrearMediosPago";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenMP)).EndInit();
            this.MenuImagen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox PBImagenMP;
        private System.Windows.Forms.ContextMenuStrip MenuImagen;
        private System.Windows.Forms.ToolStripMenuItem seleccionarNuevaImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarImagenToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBNombreMedio;
        private System.Windows.Forms.RichTextBox RTDescMedio;
        private System.Windows.Forms.ComboBox CBComportamiento;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.Button BTCancelar;
    }
}