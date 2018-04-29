namespace RafitNewFace
{
    partial class frmCrearEvento
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
            this.PNSuperior = new System.Windows.Forms.Panel();
            this.PNFechas = new System.Windows.Forms.Panel();
            this.LBDiaSem = new System.Windows.Forms.Label();
            this.LBNoDia = new System.Windows.Forms.Label();
            this.LBMes = new System.Windows.Forms.Label();
            this.PBAtras = new System.Windows.Forms.PictureBox();
            this.MCFecha = new System.Windows.Forms.MonthCalendar();
            this.PNInferior = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DTHorainicio = new System.Windows.Forms.DateTimePicker();
            this.LBHora = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PBImagenEvent = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBUsuarioOrg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PNSuperior.SuspendLayout();
            this.PNFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAtras)).BeginInit();
            this.PNInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // PNSuperior
            // 
            this.PNSuperior.BackColor = System.Drawing.Color.BlueViolet;
            this.PNSuperior.Controls.Add(this.PNFechas);
            this.PNSuperior.Controls.Add(this.PBAtras);
            this.PNSuperior.Controls.Add(this.MCFecha);
            this.PNSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNSuperior.Location = new System.Drawing.Point(0, 0);
            this.PNSuperior.Name = "PNSuperior";
            this.PNSuperior.Size = new System.Drawing.Size(893, 266);
            this.PNSuperior.TabIndex = 0;
            // 
            // PNFechas
            // 
            this.PNFechas.Controls.Add(this.LBDiaSem);
            this.PNFechas.Controls.Add(this.LBNoDia);
            this.PNFechas.Controls.Add(this.LBMes);
            this.PNFechas.Location = new System.Drawing.Point(265, 3);
            this.PNFechas.Name = "PNFechas";
            this.PNFechas.Size = new System.Drawing.Size(360, 245);
            this.PNFechas.TabIndex = 17;
            // 
            // LBDiaSem
            // 
            this.LBDiaSem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBDiaSem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBDiaSem.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.LBDiaSem.ForeColor = System.Drawing.Color.White;
            this.LBDiaSem.Location = new System.Drawing.Point(0, 213);
            this.LBDiaSem.Name = "LBDiaSem";
            this.LBDiaSem.Size = new System.Drawing.Size(360, 32);
            this.LBDiaSem.TabIndex = 2;
            this.LBDiaSem.Text = "Lunes";
            this.LBDiaSem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBNoDia
            // 
            this.LBNoDia.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBNoDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBNoDia.Font = new System.Drawing.Font("Century Gothic", 90F);
            this.LBNoDia.ForeColor = System.Drawing.Color.White;
            this.LBNoDia.Location = new System.Drawing.Point(0, 70);
            this.LBNoDia.Name = "LBNoDia";
            this.LBNoDia.Size = new System.Drawing.Size(360, 143);
            this.LBNoDia.TabIndex = 1;
            this.LBNoDia.Text = "31";
            this.LBNoDia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBMes
            // 
            this.LBMes.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBMes.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.LBMes.ForeColor = System.Drawing.Color.White;
            this.LBMes.Location = new System.Drawing.Point(0, 0);
            this.LBMes.Name = "LBMes";
            this.LBMes.Size = new System.Drawing.Size(360, 70);
            this.LBMes.TabIndex = 0;
            this.LBMes.Text = "enero";
            this.LBMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBAtras
            // 
            this.PBAtras.BackColor = System.Drawing.Color.Transparent;
            this.PBAtras.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBAtras.Image = global::Rafit.Face.Properties.Resources.ic_arrow_back_black_48dp;
            this.PBAtras.Location = new System.Drawing.Point(28, 12);
            this.PBAtras.Name = "PBAtras";
            this.PBAtras.Size = new System.Drawing.Size(100, 50);
            this.PBAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAtras.TabIndex = 16;
            this.PBAtras.TabStop = false;
            this.PBAtras.Click += new System.EventHandler(this.PBAtras_Click);
            // 
            // MCFecha
            // 
            this.MCFecha.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MCFecha.Location = new System.Drawing.Point(627, 43);
            this.MCFecha.Name = "MCFecha";
            this.MCFecha.TabIndex = 1;
            this.MCFecha.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MCFecha_DateSelected);
            // 
            // PNInferior
            // 
            this.PNInferior.BackColor = System.Drawing.Color.Indigo;
            this.PNInferior.Controls.Add(this.dateTimePicker1);
            this.PNInferior.Controls.Add(this.label6);
            this.PNInferior.Controls.Add(this.DTHorainicio);
            this.PNInferior.Controls.Add(this.LBHora);
            this.PNInferior.Controls.Add(this.button1);
            this.PNInferior.Controls.Add(this.PBImagenEvent);
            this.PNInferior.Controls.Add(this.textBox3);
            this.PNInferior.Controls.Add(this.label5);
            this.PNInferior.Controls.Add(this.CBUsuarioOrg);
            this.PNInferior.Controls.Add(this.label3);
            this.PNInferior.Controls.Add(this.richTextBox1);
            this.PNInferior.Controls.Add(this.label2);
            this.PNInferior.Controls.Add(this.textBox2);
            this.PNInferior.Controls.Add(this.label1);
            this.PNInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNInferior.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.PNInferior.ForeColor = System.Drawing.Color.White;
            this.PNInferior.Location = new System.Drawing.Point(0, 266);
            this.PNInferior.Name = "PNInferior";
            this.PNInferior.Size = new System.Drawing.Size(893, 337);
            this.PNInferior.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 10F);
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(654, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hora Fin:";
            // 
            // DTHorainicio
            // 
            this.DTHorainicio.CalendarFont = new System.Drawing.Font("Century Gothic", 10F);
            this.DTHorainicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTHorainicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTHorainicio.Location = new System.Drawing.Point(420, 263);
            this.DTHorainicio.Name = "DTHorainicio";
            this.DTHorainicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTHorainicio.Size = new System.Drawing.Size(200, 24);
            this.DTHorainicio.TabIndex = 14;
            // 
            // LBHora
            // 
            this.LBHora.AutoSize = true;
            this.LBHora.Location = new System.Drawing.Point(417, 233);
            this.LBHora.Name = "LBHora";
            this.LBHora.Size = new System.Drawing.Size(108, 17);
            this.LBHora.TabIndex = 13;
            this.LBHora.Text = "Hora de Inicio:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(164, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PBImagenEvent
            // 
            this.PBImagenEvent.BackColor = System.Drawing.Color.Transparent;
            this.PBImagenEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBImagenEvent.Image = global::Rafit.Face.Properties.Resources.icons8_Vintage_Camera_96px;
            this.PBImagenEvent.Location = new System.Drawing.Point(40, 233);
            this.PBImagenEvent.Name = "PBImagenEvent";
            this.PBImagenEvent.Size = new System.Drawing.Size(98, 64);
            this.PBImagenEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagenEvent.TabIndex = 11;
            this.PBImagenEvent.TabStop = false;
            this.PBImagenEvent.Click += new System.EventHandler(this.PBImagenEvent_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBox3.Location = new System.Drawing.Point(214, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(434, 24);
            this.textBox3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lugar de Celebracion:";
            // 
            // CBUsuarioOrg
            // 
            this.CBUsuarioOrg.BackColor = System.Drawing.Color.White;
            this.CBUsuarioOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBUsuarioOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBUsuarioOrg.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CBUsuarioOrg.FormattingEnabled = true;
            this.CBUsuarioOrg.Location = new System.Drawing.Point(40, 125);
            this.CBUsuarioOrg.Name = "CBUsuarioOrg";
            this.CBUsuarioOrg.Size = new System.Drawing.Size(330, 25);
            this.CBUsuarioOrg.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quien organiza este evento?";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(420, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cunetanos Algo Sobre Este Dia";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBox2.Location = new System.Drawing.Point(40, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 24);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Evento";
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 603);
            this.Controls.Add(this.PNInferior);
            this.Controls.Add(this.PNSuperior);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEvento";
            this.PNSuperior.ResumeLayout(false);
            this.PNFechas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBAtras)).EndInit();
            this.PNInferior.ResumeLayout(false);
            this.PNInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNSuperior;
        private System.Windows.Forms.MonthCalendar MCFecha;
        private System.Windows.Forms.Panel PNInferior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBUsuarioOrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PBImagenEvent;
        private System.Windows.Forms.PictureBox PBAtras;
        private System.Windows.Forms.Panel PNFechas;
        private System.Windows.Forms.Label LBNoDia;
        private System.Windows.Forms.Label LBMes;
        private System.Windows.Forms.Label LBDiaSem;
        private System.Windows.Forms.DateTimePicker DTHorainicio;
        private System.Windows.Forms.Label LBHora;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
    }
}