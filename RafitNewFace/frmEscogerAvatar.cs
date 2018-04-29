using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace RafitNewFace
{
    public partial class frmEscogerAvatar : Form
    {
        frmStep1CrearFan Afiliado = new frmStep1CrearFan();
        frmCrearUsuario Usuario = new frmCrearUsuario();
        
        public frmEscogerAvatar()
        {
            InitializeComponent();
        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }


        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PBAvatar1_Click(object sender, EventArgs e)
        {

            PBseleccion.Image = PBAvatar1.Image;
            
            
        }

        private void PBAvatar2_Click(object sender, EventArgs e)
        {
            PBseleccion.Image = PBAvatar2.Image;
        }

        private void PBAvatar3_Click(object sender, EventArgs e)
        {
            PBseleccion.Image = PBAvatar3.Image;
        }

        private void PBAvatar4_Click(object sender, EventArgs e)
        {
            PBseleccion.Image = PBAvatar4.Image;
        }

        private void PBAvatar5_Click(object sender, EventArgs e)
        {
            PBseleccion.Image = PBAvatar5.Image;
        }

        private void PBAvatar6_Click(object sender, EventArgs e)
        {
            PBseleccion.Image = PBAvatar6.Image;
        }

        private void PBAvatar7_Click(object sender, EventArgs e)
        {
            PBseleccion.Image = PBAvatar7.Image;
        }

        private void PBAvatar8_Click(object sender, EventArgs e)
        {
            PBseleccion.Image = PBAvatar8.Image;
        }

        private void PBAvatar9_Click(object sender, EventArgs e)
        {
            PBseleccion.Image = PBAvatar9.Image;
        }

        private void PBAvatar10_Click(object sender, EventArgs e)
        {
            PBseleccion.Image = PBAvatar10.Image;
        }
    }
}
