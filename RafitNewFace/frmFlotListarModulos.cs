using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace RafitNewFace
{


    public partial class frmFlotListarModulos : Form
    {
        
        
        Conexion Conn = new Conexion();

        public frmFlotListarModulos()
        {
            InitializeComponent();
            CargarModulos();
        }

        public void CargarModulos()
        {

            FlowContenedor.Controls.Clear();
            FlowContenedor.AutoScroll = true;
            SqlDataReader Reader = Conn.ObtenerDatosSinParametros("SP_T01_MODULOS_MOSTRAR");

            while (Reader.Read())
            {

                Button modulo = new Button()
                {
                    Width = 320,
                    Height = 40, //334; 170
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Transparent,
                    Text = Reader["F01_NOMB_MODULO"].ToString(),
                    Tag = Reader["F001_ID_MODULO"].ToString(),
                    Cursor = Cursors.Hand,
                
                    Font = new Font("Century Gothic", 8F),
                    //Image = Rafit.Face.Properties.Resources.success,
                    
                    //ImageAlign = ContentAlignment.MiddleRight,
                };

                PictureBox PBCheck = new PictureBox() {

                    Width= 25,
                    Height= 25,
                    Image = Rafit.Face.Properties.Resources.success,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Visible = false,
                    Dock = DockStyle.Right,
                
                };


                modulo.FlatAppearance.BorderSize = 0;
                modulo.Click += new EventHandler(Button_Click);
                modulo.Controls.Add(PBCheck);
                FlowContenedor.Controls.Add(modulo);

            }
        }


        private void PBCerrar_Click(object sender, EventArgs e)
        {
        
            Close(); 
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button Boton = (Button)sender;
            PBModuloSelec.Tag = Boton.Tag;
            //MessageBox.Show(PBModuloSelec.Tag.ToString());
            LBModulo.Text = Boton.Tag.ToString();

            foreach (Button BT in FlowContenedor.Controls)
            {
                foreach (PictureBox Pic in BT.Controls)
                {
                    Pic.Visible = false;
                }
            }

            foreach (PictureBox Pic in  Boton.Controls)
            { Pic.Visible = true; };
        }

        private void BTAceptar_Click(object sender, EventArgs e)
        {
            if (PBModuloSelec.Tag.ToString() != "0")
            {
                this.DialogResult = DialogResult.Yes;
                Close();
            }
            else { MessageBox.Show("Se Debe Indicar un Modulo para Continuar, O si no cancela la operacion"); }
        }
    }
}
