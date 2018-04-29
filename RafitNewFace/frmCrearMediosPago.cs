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
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace RafitNewFace
{
    public partial class frmCrearMediosPago : Form
    {
        Conexion Conn = new Conexion();
        String[] Parametros, Valores;
        MemoryStream ms = new MemoryStream();
        byte[] Foto;
        public frmCrearMediosPago()
        {
            InitializeComponent();
            CargarCombo();
        }

        private void seleccionarNuevaImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Image Files|*.PNG; *.JPG; *.GIF";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                PBImagenMP.SizeMode = PictureBoxSizeMode.Zoom;
                PBImagenMP.Image = Image.FromFile(opd.FileName);
            }
        }

        private void verImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visor_de_Imagenes Visor = new Visor_de_Imagenes();
            Visor.PBVisorImagen.Image = PBImagenMP.Image;

            Visor.ShowDialog();
        }

        private void eliminarImagenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PBImagenMP.Image = Rafit.Face.Properties.Resources.icons8_Vintage_Camera_96px;
            PBImagenMP.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        void CargarCombo()
        {
            Conn.CargarCombo(CBComportamiento, "SP_T014_COMP_MEDIOS_PAGO", "F014_NOMBRE_COMP", "", "F014_ID_COMP_MP_ID");

        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            PBImagenMP.Image.Save(ms, ImageFormat.Png);
            Foto = ms.GetBuffer();
            Parametros = new string[] { "@IN_NOMBRE","@IN_DESC", "@IN_TIPO" };
            Valores = new string[] { TBNombreMedio.Text, RTDescMedio.Text, CBComportamiento.SelectedValue.ToString()};
            try {
                if (Conn.InsertarconImagen("SP_T015_MEDIO_PAGOS_CREAR", Parametros,Valores, "@IN_IMAGE",Foto) != 0) {
                    MessageBox.Show("Exitoso");
                    Close();
                }
                else { MessageBox.Show("Algo Salio Mal, Por favor revisa los parametros"); };


            }
            catch(SqlException SqlError) {
                MessageBox.Show("Error SQL: "+SqlError);
            }
            


        }
    }
}
