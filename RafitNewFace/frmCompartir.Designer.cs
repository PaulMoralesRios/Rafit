namespace RafitNewFace
{
    partial class frmCompartir
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
            this.label3 = new System.Windows.Forms.Label();
            this.TBAfiliadosSelecc = new System.Windows.Forms.TextBox();
            this.RTMensaje = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBLink = new System.Windows.Forms.TextBox();
            this.PBEnviar = new System.Windows.Forms.PictureBox();
            this.PBDescartar = new System.Windows.Forms.PictureBox();
            this.BTCopiasLink = new System.Windows.Forms.Button();
            this.BTBuscarAfi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDescartar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compartir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(712, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comparte con tus Fanaticos los eventos que creas para motivarlos a participar por" +
    " premios, a demas de fortalecer sus habilidades\r\n y lasos con tu Centro de Acond" +
    "icionamiento.\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selecciona los Invitados:";
            // 
            // TBAfiliadosSelecc
            // 
            this.TBAfiliadosSelecc.Location = new System.Drawing.Point(18, 113);
            this.TBAfiliadosSelecc.Name = "TBAfiliadosSelecc";
            this.TBAfiliadosSelecc.Size = new System.Drawing.Size(580, 21);
            this.TBAfiliadosSelecc.TabIndex = 3;
            // 
            // RTMensaje
            // 
            this.RTMensaje.Location = new System.Drawing.Point(18, 165);
            this.RTMensaje.Name = "RTMensaje";
            this.RTMensaje.Size = new System.Drawing.Size(682, 233);
            this.RTMensaje.TabIndex = 5;
            this.RTMensaje.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Deseas agregar un mensaje para tus invitados? (Si lo prefieres)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(15, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quieres Compartirlo por las redes sociales?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(15, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(686, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Es muy probable que ayudes a conocer tu gimnacio a travez de este medio, para com" +
    "partir solo copia el link que generamos\r\ny pegalo donde quieras que los demas lo" +
    " vean.";
            // 
            // TBLink
            // 
            this.TBLink.Location = new System.Drawing.Point(18, 462);
            this.TBLink.Name = "TBLink";
            this.TBLink.Size = new System.Drawing.Size(580, 21);
            this.TBLink.TabIndex = 9;
            // 
            // PBEnviar
            // 
            this.PBEnviar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBEnviar.Image = global::Rafit.Face.Properties.Resources.icons8_Ok_48px;
            this.PBEnviar.Location = new System.Drawing.Point(622, 514);
            this.PBEnviar.Name = "PBEnviar";
            this.PBEnviar.Size = new System.Drawing.Size(88, 50);
            this.PBEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBEnviar.TabIndex = 12;
            this.PBEnviar.TabStop = false;
            this.PBEnviar.Click += new System.EventHandler(this.PBEnviar_Click);
            // 
            // PBDescartar
            // 
            this.PBDescartar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBDescartar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBDescartar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBDescartar.Image = global::Rafit.Face.Properties.Resources.icons8_Delete_48px;
            this.PBDescartar.Location = new System.Drawing.Point(18, 514);
            this.PBDescartar.Name = "PBDescartar";
            this.PBDescartar.Size = new System.Drawing.Size(88, 50);
            this.PBDescartar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBDescartar.TabIndex = 11;
            this.PBDescartar.TabStop = false;
            this.PBDescartar.Click += new System.EventHandler(this.PBDescartar_Click);
            // 
            // BTCopiasLink
            // 
            this.BTCopiasLink.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.BTCopiasLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTCopiasLink.FlatAppearance.BorderSize = 0;
            this.BTCopiasLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.BTCopiasLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BTCopiasLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCopiasLink.Image = global::Rafit.Face.Properties.Resources.icons8_Share_50px;
            this.BTCopiasLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTCopiasLink.Location = new System.Drawing.Point(604, 455);
            this.BTCopiasLink.Name = "BTCopiasLink";
            this.BTCopiasLink.Size = new System.Drawing.Size(96, 37);
            this.BTCopiasLink.TabIndex = 10;
            this.BTCopiasLink.Text = "Copiar";
            this.BTCopiasLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTCopiasLink.UseVisualStyleBackColor = true;
            // 
            // BTBuscarAfi
            // 
            this.BTBuscarAfi.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.BTBuscarAfi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTBuscarAfi.FlatAppearance.BorderSize = 0;
            this.BTBuscarAfi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.BTBuscarAfi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BTBuscarAfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBuscarAfi.Image = global::Rafit.Face.Properties.Resources.icons8_Search_64px;
            this.BTBuscarAfi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTBuscarAfi.Location = new System.Drawing.Point(604, 106);
            this.BTBuscarAfi.Name = "BTBuscarAfi";
            this.BTBuscarAfi.Size = new System.Drawing.Size(96, 37);
            this.BTBuscarAfi.TabIndex = 4;
            this.BTBuscarAfi.Text = "Buscar";
            this.BTBuscarAfi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTBuscarAfi.UseVisualStyleBackColor = true;
            this.BTBuscarAfi.Click += new System.EventHandler(this.BTBuscarAfi_Click);
            // 
            // FormCompartir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 587);
            this.Controls.Add(this.PBEnviar);
            this.Controls.Add(this.PBDescartar);
            this.Controls.Add(this.BTCopiasLink);
            this.Controls.Add(this.TBLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RTMensaje);
            this.Controls.Add(this.BTBuscarAfi);
            this.Controls.Add(this.TBAfiliadosSelecc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCompartir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PBEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDescartar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTBuscarAfi;
        private System.Windows.Forms.RichTextBox RTMensaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBLink;
        private System.Windows.Forms.Button BTCopiasLink;
        private System.Windows.Forms.PictureBox PBDescartar;
        private System.Windows.Forms.PictureBox PBEnviar;
        public System.Windows.Forms.TextBox TBAfiliadosSelecc;
    }
}