namespace RafitNewFace
{
    partial class frmFlotListarModulos
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
            this.FlowContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.PBCerrar = new System.Windows.Forms.PictureBox();
            this.LBEnunciado = new System.Windows.Forms.Label();
            this.BTAceptar = new System.Windows.Forms.Button();
            this.LBModulo = new System.Windows.Forms.Label();
            this.PBModuloSelec = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBModuloSelec)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowContenedor
            // 
            this.FlowContenedor.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold);
            this.FlowContenedor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FlowContenedor.Location = new System.Drawing.Point(0, 56);
            this.FlowContenedor.Name = "FlowContenedor";
            this.FlowContenedor.Size = new System.Drawing.Size(326, 278);
            this.FlowContenedor.TabIndex = 5;
            // 
            // PBCerrar
            // 
            this.PBCerrar.BackColor = System.Drawing.Color.Transparent;
            this.PBCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBCerrar.Image = global::Rafit.Face.Properties.Resources.icons8_Delete_48px;
            this.PBCerrar.Location = new System.Drawing.Point(289, 21);
            this.PBCerrar.Name = "PBCerrar";
            this.PBCerrar.Size = new System.Drawing.Size(23, 25);
            this.PBCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCerrar.TabIndex = 6;
            this.PBCerrar.TabStop = false;
            this.PBCerrar.Click += new System.EventHandler(this.PBCerrar_Click);
            // 
            // LBEnunciado
            // 
            this.LBEnunciado.AutoSize = true;
            this.LBEnunciado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.LBEnunciado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LBEnunciado.Location = new System.Drawing.Point(12, 21);
            this.LBEnunciado.Name = "LBEnunciado";
            this.LBEnunciado.Size = new System.Drawing.Size(206, 16);
            this.LBEnunciado.TabIndex = 9;
            this.LBEnunciado.Text = "Seleccione el Modulo que desea:";
            // 
            // BTAceptar
            // 
            this.BTAceptar.BackColor = System.Drawing.Color.LightGreen;
            this.BTAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTAceptar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAceptar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BTAceptar.ForeColor = System.Drawing.Color.White;
            this.BTAceptar.Location = new System.Drawing.Point(0, 338);
            this.BTAceptar.Name = "BTAceptar";
            this.BTAceptar.Size = new System.Drawing.Size(326, 63);
            this.BTAceptar.TabIndex = 10;
            this.BTAceptar.Text = "Aceptar";
            this.BTAceptar.UseVisualStyleBackColor = false;
            this.BTAceptar.Click += new System.EventHandler(this.BTAceptar_Click);
            // 
            // LBModulo
            // 
            this.LBModulo.AutoSize = true;
            this.LBModulo.Location = new System.Drawing.Point(226, 21);
            this.LBModulo.Name = "LBModulo";
            this.LBModulo.Size = new System.Drawing.Size(14, 16);
            this.LBModulo.TabIndex = 11;
            this.LBModulo.Text = "0";
            this.LBModulo.Visible = false;
            // 
            // PBModuloSelec
            // 
            this.PBModuloSelec.Location = new System.Drawing.Point(258, 21);
            this.PBModuloSelec.Name = "PBModuloSelec";
            this.PBModuloSelec.Size = new System.Drawing.Size(25, 25);
            this.PBModuloSelec.TabIndex = 12;
            this.PBModuloSelec.TabStop = false;
            this.PBModuloSelec.Tag = "0";
            // 
            // frmFlotListarModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(326, 401);
            this.Controls.Add(this.PBModuloSelec);
            this.Controls.Add(this.LBModulo);
            this.Controls.Add(this.BTAceptar);
            this.Controls.Add(this.LBEnunciado);
            this.Controls.Add(this.PBCerrar);
            this.Controls.Add(this.FlowContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFlotListarModulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBModuloSelec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel FlowContenedor;
        private System.Windows.Forms.PictureBox PBCerrar;
        private System.Windows.Forms.Label LBEnunciado;
        private System.Windows.Forms.Button BTAceptar;
        private System.Windows.Forms.Label LBModulo;
        public System.Windows.Forms.PictureBox PBModuloSelec;
    }
}