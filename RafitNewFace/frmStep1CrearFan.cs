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
    public partial class frmStep1CrearFan : Form
    {
        //Paso 1 Creacion de Fanatico
       
        Conexion Conn = new Conexion();
        frrmMasterStepFan Fan = new frrmMasterStepFan();

        public frmStep1CrearFan()
        {
            InitializeComponent();
            CargarCombo();
      
        }
    
        private void PBCancelar_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void PBAceptar_Click(object sender, EventArgs e)
        {

            var boxes = Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    IndicadorError.SetError(box, "Please fill the required field");
                }
            }

        }

        private void PBAtras_Click(object sender, EventArgs e)
        {

            Close();

        }

        void CargarCombo()
        {
            Conn.CargarCombo(CBTipoDoc, "SP_T06_TIPO_ID_MOSTRAR", "F06_NOMB_TIPO_ID", "", "F06_ID_TIPO_ID");

        }


        private void eliminarImagenToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cambiarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorCamara Camara = new frmVisorCamara();
            if(Camara.ShowDialog() == DialogResult.Yes)
            {
                PBImgPerf.SizeMode = PictureBoxSizeMode.Zoom;
                PBImgPerf.Image = Camara.PBVideoImage.Image;
            }
        }


        private void PBImgPerf_Click(object sender, EventArgs e)
        {
            Visor_de_Imagenes Visor = new Visor_de_Imagenes();
            Visor.PBVisorImagen.Image = PBImgPerf.Image;

            Visor.ShowDialog();
        }

        private void eliminarImagenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PBImgPerf.Image = Rafit.Face.Properties.Resources.icons8_Vintage_Camera_96px;  
            PBImgPerf.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void BTContinuar_Click(object sender, EventArgs e)
        {
            Fan.Paso2_Click(null, null);

        }
    }
}


   