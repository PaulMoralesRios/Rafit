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
    public partial class frmFlotListarPromo : Form
    {
        string promoseleccion;
        Conexion Conn = new Conexion();
        

        public frmFlotListarPromo()
        {
            InitializeComponent();
            
            cargarpromos();
        }



        public void cargarpromos()
        {

            FlowPromo.Controls.Clear();

            SqlDataReader Reader = Conn.ObtenerDatosSinParametros("SP_T10_PROMOCIONES_MOSTRAR");

            if (Reader.HasRows)
            {

                while (Reader.Read())
                {

                    Panel Promocion = new Panel()
                    {
                        Width = 250,
                        Height = 70, //334; 170
                        BorderStyle = BorderStyle.None,
                        BackColor = Color.Transparent,
                        Cursor = Cursors.Hand,
                        BackgroundImage = Rafit.Face.Properties.Resources.commlawnbkgd3,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Font = new Font("Century Gothic", 10F),
                        Name = Reader["F010_PROM_DESCR"].ToString(),

                    };

                    Label Nombre = new Label()
                    {
                        Dock = DockStyle.Fill,
                        Tag = Reader["F010_PROM_ID"].ToString(),
                        Text = Reader["F010_PROM_DESCR"].ToString(),
                    };
                    Promocion.Controls.Add(Nombre);
                    Nombre.Click += new EventHandler(seleccionlabel);
                    Promocion.Click += new EventHandler(seleccion);
                    FlowPromo.Controls.Add(Promocion);
                }
                Reader.Close();
            }
            else {

                FlowPromo.BackgroundImage = Rafit.Face.Properties.Resources.Nada_en_esta_Lista_2;
                

            }
        }


        public void seleccion(object sender, EventArgs e)

        {
            Panel promo = (Panel)sender;

            promoseleccion = promo.Name.ToString();
            MessageBox.Show("Se selecciono: "+promoseleccion);
        }

        public void seleccionlabel(object sender, EventArgs e)

        {
            Label promo = (Label)sender;

            promoseleccion = promo.Tag.ToString();
            TBCode.Text =   promoseleccion;
        }

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            if(TBCode.Text != "")
            {
                this.DialogResult = DialogResult.Yes;

            }
            Close();
        }
    }
}
