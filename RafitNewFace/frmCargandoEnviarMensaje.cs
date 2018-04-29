using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafitNewFace
{
    public partial class frmCargandoEnviarMensaje : Form
    {
        public frmCargandoEnviarMensaje()
        {
            InitializeComponent();
            Completo();
        }

        public void Completo()
        {
            if (PBGifs.Enabled){ 
            Tiempo.Enabled = true;
            Tiempo.Interval = 9000;
            Tiempo.Tick += new EventHandler( Mensaje);
            }
        }


        public void Mensaje( object sender , EventArgs e)
        {
            Tiempo.Enabled = false;

            LBEstado.Text = "Completo";
            
        }

        private void PBGifs_Click(object sender, EventArgs e)
        {
            PBGifs.Enabled = Enabled;
            MessageBox.Show("Si Lo Toma");
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

            PBGifs.Image = Rafit.Face.Properties.Resources.Mensaje_Enviado;
            PBOk.Visible = true;
        }

        private void PBOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
