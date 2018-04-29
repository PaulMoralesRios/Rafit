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
    public partial class frmStep2Facturacion : Form
    {
        //Paso 2 Creacion de Nuevo Fanatico
        Conexion Conn = new Conexion();
        frrmMasterStepFan Fan = new frrmMasterStepFan();
        public frmStep2Facturacion()
        {
            InitializeComponent();
            cargarmembresias();
        }


        public void cargarmembresias()
        {
            PNFlowMemb.Controls.Clear();

            SqlDataReader Reader = Conn.ObtenerDatosSinParametros("SP_T09_MEMBRESIA_MOSTRAR");
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {

                    Panel Membresia = new Panel()
                    {
                        Width = 100,
                        Height = 100, //334; 170
                        BorderStyle = BorderStyle.None,
                        BackColor = Color.Transparent,
                        BackgroundImage = Rafit.Face.Properties.Resources.Boton_Transparente,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Font = new Font("Century Gothic", 10F),
                        Name = Reader["F09_MEMB_NOMB"].ToString(),

                    };
                    //No esta Mostrando Tooltip Bien
                    ToolTipName.SetToolTip(Membresia, "Mensaje Loco");

                    Membresia.Click += new EventHandler(Seleccion);
                    PNFlowMemb.Controls.Add(Membresia);
                }
                Reader.Close();
            }
            else { PNFlowMemb.BackgroundImage = Rafit.Face.Properties.Resources.Imagen_no_Encontrada; }
        }

        void Seleccion(object sender, EventArgs e)
        {
            //Captura Membresia Seleccionada
            TBPromo.Focus();
            Panel PN = sender as Panel;
            LBMembSelec.Text = PN.Name;
        }


        private void PBBuscarpromo_Click(object sender, EventArgs e)
        {
            //Mostrar las Promo Disponibles
            frmFlotListarPromo Promos = new frmFlotListarPromo();
            if (Promos.ShowDialog() == DialogResult.Yes)
            {
                TBPromo.Text = Promos.TBCode.Text;
            }
        }

        private void BTCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BTContinuar_Click(object sender, EventArgs e)
        {
            Fan.Paso3_Click(null, null);
        }
    }
}
