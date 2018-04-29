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
    public partial class frmCrearMembresia : Form
    {
        public frmCrearMembresia()
        {
            InitializeComponent();
        }

        private void verImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visor_de_Imagenes Visor = new Visor_de_Imagenes();
            Visor.PBVisorImagen.Image = PBImagenMemb.Image;

            Visor.ShowDialog();
        }

        private void eliminarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Image Files|*.PNG; *.JPG; *.GIF";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                PBImagenMemb.SizeMode = PictureBoxSizeMode.Zoom;
                PBImagenMemb.Image = Image.FromFile(opd.FileName);
            }
        }

        private void eliminarImagenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PBImagenMemb.Image = Rafit.Face.Properties.Resources.icons8_Gold_Medal_96px;
            PBImagenMemb.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
