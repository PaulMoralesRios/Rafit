namespace RafitNewFace
{
    partial class frmFlotListarAfiliados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PBCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBSelecNone = new System.Windows.Forms.PictureBox();
            this.PBSelecAll = new System.Windows.Forms.PictureBox();
            this.CHLAfiliados = new System.Windows.Forms.CheckedListBox();
            this.PBAceptar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSelecNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSelecAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indica tu Seleccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(38, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "A continuacion Veras el listado de los Afiliados, selecciona los que quieras anex" +
    "ar:";
            // 
            // PBCerrar
            // 
            this.PBCerrar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBCerrar.Image = global::Rafit.Face.Properties.Resources.icons8_Delete_48px;
            this.PBCerrar.Location = new System.Drawing.Point(41, 588);
            this.PBCerrar.Name = "PBCerrar";
            this.PBCerrar.Size = new System.Drawing.Size(88, 50);
            this.PBCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCerrar.TabIndex = 15;
            this.PBCerrar.TabStop = false;
            this.PBCerrar.Click += new System.EventHandler(this.PBCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Rafit.Face.Properties.Resources.rien;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PBSelecNone);
            this.panel1.Controls.Add(this.PBSelecAll);
            this.panel1.Controls.Add(this.CHLAfiliados);
            this.panel1.Location = new System.Drawing.Point(41, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 512);
            this.panel1.TabIndex = 14;
            // 
            // PBSelecNone
            // 
            this.PBSelecNone.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBSelecNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBSelecNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBSelecNone.Image = global::Rafit.Face.Properties.Resources.icons8_Uncheck_All_50px;
            this.PBSelecNone.Location = new System.Drawing.Point(261, 20);
            this.PBSelecNone.Name = "PBSelecNone";
            this.PBSelecNone.Size = new System.Drawing.Size(36, 32);
            this.PBSelecNone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSelecNone.TabIndex = 16;
            this.PBSelecNone.TabStop = false;
            this.PBSelecNone.Click += new System.EventHandler(this.PBSelecNone_Click);
            // 
            // PBSelecAll
            // 
            this.PBSelecAll.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBSelecAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBSelecAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBSelecAll.Image = global::Rafit.Face.Properties.Resources.icons8_Check_All_50px;
            this.PBSelecAll.Location = new System.Drawing.Point(67, 20);
            this.PBSelecAll.Name = "PBSelecAll";
            this.PBSelecAll.Size = new System.Drawing.Size(36, 32);
            this.PBSelecAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSelecAll.TabIndex = 15;
            this.PBSelecAll.TabStop = false;
            this.PBSelecAll.Click += new System.EventHandler(this.PBSelecAll_Click);
            // 
            // CHLAfiliados
            // 
            this.CHLAfiliados.BackColor = System.Drawing.Color.White;
            this.CHLAfiliados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CHLAfiliados.CheckOnClick = true;
            this.CHLAfiliados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CHLAfiliados.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CHLAfiliados.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CHLAfiliados.FormattingEnabled = true;
            this.CHLAfiliados.Location = new System.Drawing.Point(15, 58);
            this.CHLAfiliados.Name = "CHLAfiliados";
            this.CHLAfiliados.Size = new System.Drawing.Size(376, 442);
            this.CHLAfiliados.TabIndex = 0;
            // 
            // PBAceptar
            // 
            this.PBAceptar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBAceptar.Image = global::Rafit.Face.Properties.Resources.icons8_Ok_48px;
            this.PBAceptar.Location = new System.Drawing.Point(357, 588);
            this.PBAceptar.Name = "PBAceptar";
            this.PBAceptar.Size = new System.Drawing.Size(88, 50);
            this.PBAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAceptar.TabIndex = 13;
            this.PBAceptar.TabStop = false;
            this.PBAceptar.Click += new System.EventHandler(this.PBAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Todos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ninguno";
            // 
            // ListarAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 650);
            this.Controls.Add(this.PBCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListarAfiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarAfiliados";
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSelecNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSelecAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckedListBox CHLAfiliados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PBAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBSelecAll;
        private System.Windows.Forms.PictureBox PBCerrar;
        private System.Windows.Forms.PictureBox PBSelecNone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}