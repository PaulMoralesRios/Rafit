using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafitNewFace
{
    public partial class frmStep4MedioPago : Form
    {
        Conexion Conn = new Conexion();
        frrmMasterStepFan Fan = new frrmMasterStepFan();
        public frmStep4MedioPago()
        {
            InitializeComponent();
            CargarMediosPago();
        }



        void CargarMediosPago()
        {
            FlowMediodePago.Controls.Clear();
            FlowMediodePago.AutoScroll = true;
            SqlDataReader Reader = Conn.ObtenerDatosSinParametros("T015_MEDIOS_PAGO_MOSTRAR");
            if (Reader.HasRows)
            {

                while (Reader.Read())
                {

                    Button mediodepago = new Button()
                    {
                        Width = 337,
                        Height = 40, //334; 170
                        FlatStyle = FlatStyle.Flat,
                        Dock = DockStyle.Bottom,
                        BackColor = Color.Transparent,
                        Text = Reader["F015_MP_NOMBRE"].ToString(),
                        Tag = Reader["F015_MP_ID"].ToString(),
                        Cursor = Cursors.Hand,

                        Font = new Font("Century Gothic", 10F),
                        //BackgroundImage = Rafit.Face.Properties.Resources.Boton_Transparente,
                        //BackgroundImageLayout = ImageLayout.Stretch
                        //ImageAlign = ContentAlignment.MiddleRight,
                    };

                    PictureBox PBCheck = new PictureBox()
                    {

                        Width = 25,
                        Height = 25,
                        Image = Rafit.Face.Properties.Resources.success,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Visible = false,
                        Dock = DockStyle.Right,

                    };


                    mediodepago.FlatAppearance.BorderSize = 0;
                    mediodepago.Click += new EventHandler(btnClick);
                    mediodepago.Controls.Add(PBCheck);
                    FlowMediodePago.Controls.Add(mediodepago);
                   
                }
            }
            else { FlowMediodePago.BackgroundImage = Rafit.Face.Properties.Resources.Nada_en_esta_Lista_2; };
        }


        public  void btnClick(object sender, EventArgs e)
        {
            Button Boton = sender as Button;
           
           
            LBMedioPago.Text = Boton.Tag.ToString();

            foreach (Button BT in FlowMediodePago.Controls)
            {
                foreach (PictureBox Pic in BT.Controls)
                {
                    Pic.Visible = false;
                    BT.BackColor = Color.Transparent;
                }
            }

            foreach (PictureBox Pic in Boton.Controls)
            { Pic.Visible = true;
               
            };

            Boton.BackColor = Color.Green;


        }



    }
}
