using System;
using System.IO;
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
    public partial class frmCrearUsuario : Form
    {
        Conexion Conn = new Conexion();
        //FileStream Fs;
        public frmCrearUsuario()
        {
            InitializeComponent();
            Cargarcomponentes();
            
        }


        public void Cargarcomponentes()
        {
 
            PBImgPerf.SizeMode = PictureBoxSizeMode.CenterImage;
            PBImgPerf.Image = Rafit.Face.Properties.Resources.icons8_Vintage_Camera_96px;
            Conn.CargarCombo(CBRol, "[SPCARGARROLES]", "Nombre", "", "Id");
        }

        //Menu ContextToolStrip
        private void seleccionarNuevaImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Image Files|*.PNG; *.JPG; *.GIF";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                PBImgPerf.SizeMode = PictureBoxSizeMode.Zoom;
                PBImgPerf.Image = Image.FromFile(opd.FileName);
            }   
        }


        private void verImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visor_de_Imagenes Visor = new Visor_de_Imagenes();
            Visor.PBVisorImagen.Image = PBImgPerf.Image;

            Visor.ShowDialog();
        }
  
        private void PrediseñadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEscogerAvatar avatar = new frmEscogerAvatar();
            if (avatar.ShowDialog() == DialogResult.Yes) { ;
                PBImgPerf.SizeMode = PictureBoxSizeMode.Zoom;
                PBImgPerf.Image = avatar.PBseleccion.Image;
            }
        }
        private void eliminarImagenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PBImgPerf.Image = Rafit.Face.Properties.Resources.icons8_Vintage_Camera_96px;
            PBImgPerf.SizeMode = PictureBoxSizeMode.CenterImage;
        }


        public void Animacion(object sender, EventArgs e)
        {
            Close();
        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            //File.Delete("Perfil.png");
            BTGuardar.Text = string.Empty;
            BTGuardar.Image = Rafit.Face.Properties.Resources.Correcto;
            Tiempo.Enabled = true;
            Tiempo.Interval = 4000;
            Tiempo.Tick += new EventHandler(Animacion);
        }


        private void PBImgPerf_Click(object sender, EventArgs e)
        {
            Visor_de_Imagenes Visor = new Visor_de_Imagenes();
            Visor.PBVisorImagen.Image = PBImgPerf.Image;

            Visor.ShowDialog();
        }



        private void PBCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Close();
            
        }
    }
}
