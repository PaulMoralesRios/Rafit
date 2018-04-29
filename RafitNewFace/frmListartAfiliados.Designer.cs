namespace RafitNewFace
{
    partial class frmListartAfiliados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuAfiliado = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PNPrincipal = new System.Windows.Forms.Panel();
            this.PanelTotal = new System.Windows.Forms.Panel();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.LBT = new System.Windows.Forms.Label();
            this.PNAcciomes = new System.Windows.Forms.Panel();
            this.BTBuscar = new System.Windows.Forms.Button();
            this.PBBuscar = new System.Windows.Forms.PictureBox();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.BTEliminar = new System.Windows.Forms.Button();
            this.BTMultiselect = new System.Windows.Forms.Button();
            this.BTNuevo = new System.Windows.Forms.Button();
            this.PBSiguiente = new System.Windows.Forms.PictureBox();
            this.PBAtras = new System.Windows.Forms.PictureBox();
            this.PanelPagina = new System.Windows.Forms.Panel();
            this.LBPagAct = new System.Windows.Forms.Label();
            this.LBTotalPag = new System.Windows.Forms.Label();
            this.LBnada = new System.Windows.Forms.Label();
            this.DGListaAfiliados = new System.Windows.Forms.DataGridView();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MenuAfiliado.SuspendLayout();
            this.PNPrincipal.SuspendLayout();
            this.PanelTotal.SuspendLayout();
            this.PNAcciomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAtras)).BeginInit();
            this.PanelPagina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuAfiliado
            // 
            this.MenuAfiliado.BackColor = System.Drawing.Color.Transparent;
            this.MenuAfiliado.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.MenuAfiliado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.MenuAfiliado.Name = "MenuAfiliado";
            this.MenuAfiliado.Size = new System.Drawing.Size(122, 70);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Image = global::Rafit.Face.Properties.Resources.icons8_Eye_48px;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::Rafit.Face.Properties.Resources.icons8_Edit_Row_40px;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::Rafit.Face.Properties.Resources.icons8_Delete_View_40px;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // PNPrincipal
            // 
            this.PNPrincipal.Controls.Add(this.PanelTotal);
            this.PNPrincipal.Controls.Add(this.PNAcciomes);
            this.PNPrincipal.Controls.Add(this.PanelPagina);
            this.PNPrincipal.Controls.Add(this.DGListaAfiliados);
            this.PNPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PNPrincipal.Name = "PNPrincipal";
            this.PNPrincipal.Size = new System.Drawing.Size(1040, 581);
            this.PNPrincipal.TabIndex = 9;
            // 
            // PanelTotal
            // 
            this.PanelTotal.BackColor = System.Drawing.Color.Transparent;
            this.PanelTotal.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PanelTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelTotal.Controls.Add(this.TBTotal);
            this.PanelTotal.Controls.Add(this.LBT);
            this.PanelTotal.Location = new System.Drawing.Point(718, 544);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Size = new System.Drawing.Size(200, 34);
            this.PanelTotal.TabIndex = 11;
            // 
            // TBTotal
            // 
            this.TBTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TBTotal.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.TBTotal.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBTotal.Location = new System.Drawing.Point(86, 11);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.Size = new System.Drawing.Size(100, 15);
            this.TBTotal.TabIndex = 1;
            this.TBTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBT
            // 
            this.LBT.AutoSize = true;
            this.LBT.Location = new System.Drawing.Point(17, 11);
            this.LBT.Name = "LBT";
            this.LBT.Size = new System.Drawing.Size(40, 16);
            this.LBT.TabIndex = 0;
            this.LBT.Text = "Total: ";
            // 
            // PNAcciomes
            // 
            this.PNAcciomes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNAcciomes.Controls.Add(this.BTBuscar);
            this.PNAcciomes.Controls.Add(this.PBBuscar);
            this.PNAcciomes.Controls.Add(this.TBBuscar);
            this.PNAcciomes.Controls.Add(this.BTEliminar);
            this.PNAcciomes.Controls.Add(this.BTMultiselect);
            this.PNAcciomes.Controls.Add(this.BTNuevo);
            this.PNAcciomes.Controls.Add(this.PBSiguiente);
            this.PNAcciomes.Controls.Add(this.PBAtras);
            this.PNAcciomes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNAcciomes.Location = new System.Drawing.Point(0, 0);
            this.PNAcciomes.Name = "PNAcciomes";
            this.PNAcciomes.Size = new System.Drawing.Size(1040, 50);
            this.PNAcciomes.TabIndex = 2;
            // 
            // BTBuscar
            // 
            this.BTBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTBuscar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.BTBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTBuscar.FlatAppearance.BorderSize = 0;
            this.BTBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBuscar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BTBuscar.ForeColor = System.Drawing.Color.GhostWhite;
            this.BTBuscar.Location = new System.Drawing.Point(684, 17);
            this.BTBuscar.Name = "BTBuscar";
            this.BTBuscar.Size = new System.Drawing.Size(79, 23);
            this.BTBuscar.TabIndex = 7;
            this.BTBuscar.Text = "Buscar";
            this.BTBuscar.UseVisualStyleBackColor = false;
            // 
            // PBBuscar
            // 
            this.PBBuscar.BackColor = System.Drawing.Color.Transparent;
            this.PBBuscar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBBuscar.Image = global::Rafit.Face.Properties.Resources.icons8_Search_100px;
            this.PBBuscar.Location = new System.Drawing.Point(514, 12);
            this.PBBuscar.Name = "PBBuscar";
            this.PBBuscar.Size = new System.Drawing.Size(49, 31);
            this.PBBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBBuscar.TabIndex = 6;
            this.PBBuscar.TabStop = false;
            // 
            // TBBuscar
            // 
            this.TBBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBBuscar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TBBuscar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBBuscar.Location = new System.Drawing.Point(578, 19);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(100, 17);
            this.TBBuscar.TabIndex = 5;
            this.TBBuscar.Text = "Buscar...";
            // 
            // BTEliminar
            // 
            this.BTEliminar.BackColor = System.Drawing.Color.Crimson;
            this.BTEliminar.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.BTEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTEliminar.FlatAppearance.BorderSize = 0;
            this.BTEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEliminar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BTEliminar.ForeColor = System.Drawing.Color.GhostWhite;
            this.BTEliminar.Location = new System.Drawing.Point(175, 16);
            this.BTEliminar.Name = "BTEliminar";
            this.BTEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTEliminar.TabIndex = 4;
            this.BTEliminar.Text = "Eliminar";
            this.BTEliminar.UseVisualStyleBackColor = false;
            // 
            // BTMultiselect
            // 
            this.BTMultiselect.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTMultiselect.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.BTMultiselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTMultiselect.FlatAppearance.BorderSize = 0;
            this.BTMultiselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTMultiselect.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BTMultiselect.ForeColor = System.Drawing.Color.GhostWhite;
            this.BTMultiselect.Location = new System.Drawing.Point(322, 16);
            this.BTMultiselect.Name = "BTMultiselect";
            this.BTMultiselect.Size = new System.Drawing.Size(132, 23);
            this.BTMultiselect.TabIndex = 3;
            this.BTMultiselect.Text = "Seleccionar Varios";
            this.BTMultiselect.UseVisualStyleBackColor = false;
            this.BTMultiselect.Click += new System.EventHandler(this.BTMultiselect_Click);
            // 
            // BTNuevo
            // 
            this.BTNuevo.BackColor = System.Drawing.Color.LightGreen;
            this.BTNuevo.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.BTNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNuevo.FlatAppearance.BorderSize = 0;
            this.BTNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNuevo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BTNuevo.ForeColor = System.Drawing.Color.White;
            this.BTNuevo.Location = new System.Drawing.Point(37, 16);
            this.BTNuevo.Name = "BTNuevo";
            this.BTNuevo.Size = new System.Drawing.Size(75, 23);
            this.BTNuevo.TabIndex = 2;
            this.BTNuevo.Text = "Nuevo";
            this.BTNuevo.UseVisualStyleBackColor = false;
            this.BTNuevo.Click += new System.EventHandler(this.BTNuevo_Click);
            // 
            // PBSiguiente
            // 
            this.PBSiguiente.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBSiguiente.Image = global::Rafit.Face.Properties.Resources.icons8_Next_page_48px;
            this.PBSiguiente.Location = new System.Drawing.Point(954, 16);
            this.PBSiguiente.Name = "PBSiguiente";
            this.PBSiguiente.Size = new System.Drawing.Size(37, 28);
            this.PBSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSiguiente.TabIndex = 1;
            this.PBSiguiente.TabStop = false;
            this.PBSiguiente.Click += new System.EventHandler(this.PBNextPag_Click);
            // 
            // PBAtras
            // 
            this.PBAtras.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PBAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBAtras.Image = global::Rafit.Face.Properties.Resources.icons8_Back_To_48px_1;
            this.PBAtras.Location = new System.Drawing.Point(893, 16);
            this.PBAtras.Name = "PBAtras";
            this.PBAtras.Size = new System.Drawing.Size(37, 28);
            this.PBAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAtras.TabIndex = 0;
            this.PBAtras.TabStop = false;
            this.PBAtras.Click += new System.EventHandler(this.PBBackPag_Click);
            // 
            // PanelPagina
            // 
            this.PanelPagina.BackColor = System.Drawing.Color.Transparent;
            this.PanelPagina.BackgroundImage = global::Rafit.Face.Properties.Resources.Boton_Transparente;
            this.PanelPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelPagina.Controls.Add(this.LBPagAct);
            this.PanelPagina.Controls.Add(this.LBTotalPag);
            this.PanelPagina.Controls.Add(this.LBnada);
            this.PanelPagina.Location = new System.Drawing.Point(394, 544);
            this.PanelPagina.Name = "PanelPagina";
            this.PanelPagina.Size = new System.Drawing.Size(257, 34);
            this.PanelPagina.TabIndex = 10;
            // 
            // LBPagAct
            // 
            this.LBPagAct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBPagAct.AutoSize = true;
            this.LBPagAct.Location = new System.Drawing.Point(16, 11);
            this.LBPagAct.Name = "LBPagAct";
            this.LBPagAct.Size = new System.Drawing.Size(14, 16);
            this.LBPagAct.TabIndex = 6;
            this.LBPagAct.Text = "0";
            this.LBPagAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBTotalPag
            // 
            this.LBTotalPag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBTotalPag.AutoSize = true;
            this.LBTotalPag.Location = new System.Drawing.Point(229, 11);
            this.LBTotalPag.Name = "LBTotalPag";
            this.LBTotalPag.Size = new System.Drawing.Size(14, 16);
            this.LBTotalPag.TabIndex = 5;
            this.LBTotalPag.Text = "0";
            this.LBTotalPag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBnada
            // 
            this.LBnada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBnada.AutoSize = true;
            this.LBnada.Location = new System.Drawing.Point(117, 11);
            this.LBnada.Name = "LBnada";
            this.LBnada.Size = new System.Drawing.Size(23, 16);
            this.LBnada.TabIndex = 7;
            this.LBnada.Text = "De";
            this.LBnada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGListaAfiliados
            // 
            this.DGListaAfiliados.AllowUserToAddRows = false;
            this.DGListaAfiliados.AllowUserToDeleteRows = false;
            this.DGListaAfiliados.AllowUserToOrderColumns = true;
            this.DGListaAfiliados.AllowUserToResizeColumns = false;
            this.DGListaAfiliados.AllowUserToResizeRows = false;
            this.DGListaAfiliados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGListaAfiliados.BackgroundColor = System.Drawing.Color.White;
            this.DGListaAfiliados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGListaAfiliados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaAfiliados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGListaAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSelect});
            this.DGListaAfiliados.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaAfiliados.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGListaAfiliados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DGListaAfiliados.Location = new System.Drawing.Point(23, 50);
            this.DGListaAfiliados.MultiSelect = false;
            this.DGListaAfiliados.Name = "DGListaAfiliados";
            this.DGListaAfiliados.RowHeadersVisible = false;
            this.DGListaAfiliados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGListaAfiliados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGListaAfiliados.Size = new System.Drawing.Size(977, 488);
            this.DGListaAfiliados.TabIndex = 1;
            this.DGListaAfiliados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGListaAfiliados_MouseClick);
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnSelect.HeaderText = "Seleccion";
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.Visible = false;
            // 
            // GestAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 581);
            this.Controls.Add(this.PNPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GestAfiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestAfiliados";
            this.MenuAfiliado.ResumeLayout(false);
            this.PNPrincipal.ResumeLayout(false);
            this.PanelTotal.ResumeLayout(false);
            this.PanelTotal.PerformLayout();
            this.PNAcciomes.ResumeLayout(false);
            this.PNAcciomes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAtras)).EndInit();
            this.PanelPagina.ResumeLayout(false);
            this.PanelPagina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaAfiliados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LBTotalPag;
        private System.Windows.Forms.Label LBPagAct;
        private System.Windows.Forms.Label LBnada;
        private System.Windows.Forms.ContextMenuStrip MenuAfiliado;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel PNPrincipal;
        private System.Windows.Forms.DataGridView DGListaAfiliados;
        private System.Windows.Forms.Panel PNAcciomes;
        private System.Windows.Forms.PictureBox PBSiguiente;
        private System.Windows.Forms.PictureBox PBAtras;
        private System.Windows.Forms.Button BTNuevo;
        private System.Windows.Forms.Button BTMultiselect;
        private System.Windows.Forms.Button BTEliminar;
        private System.Windows.Forms.Panel PanelPagina;
        private System.Windows.Forms.Panel PanelTotal;
        private System.Windows.Forms.TextBox TBTotal;
        private System.Windows.Forms.Label LBT;
        private System.Windows.Forms.PictureBox PBBuscar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Button BTBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
    }
}