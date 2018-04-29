using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using  AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace RafitNewFace
{
    public partial class frmVisorCamara : Form
    {
        Dispositivos Ds = new Dispositivos();
        frmStep1CrearFan Afi = new frmStep1CrearFan();
        private FilterInfoCollection DispositivosDeVideo;

        private VideoCaptureDevice FuenteDeVideo = null;

        public frmVisorCamara()
        {
            InitializeComponent();
            Iniciarlizar();
        }

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            try { FuenteDeVideo.SignalToStop(); }
            catch { };
            
            Close();
        }

        public void Iniciarlizar()
        {
            PBCerrar.Parent = PBVideoImage;
            PBConfiguracion.Parent = PBVideoImage;
            BTIniciar.Parent = PBVideoImage;
            PNConfirmacion.Parent = PBVideoImage;
           
            DispositivosDeVideo =
            new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count != 0) { Ds.CargarDispositivos(DispositivosDeVideo, CBCamarasDisponibles);}
            try
            {
                FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[CBCamarasDisponibles.SelectedIndex].MonikerString);
                FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                FuenteDeVideo.Start();
            }
            catch (Exception e) { MessageBox.Show("Hubo Un Problema al Iniciar la Camara, Error: "+e.Message); }
            //try
            //{
            //MessageBox.Show(DispositivosDeVideo[CBCamarasDisponibles.SelectedIndex].Name.ToString());
           
                //}
                //catch { Ds.DetenerCamara(FuenteDeVideo); };
        }

        private void PBConfiguracion_Click(object sender, EventArgs e)
        {
            if (CBCamarasDisponibles.Visible == false) { CBCamarasDisponibles.Visible = true; } else { CBCamarasDisponibles.Visible = false; };
        }


        private void BTIniciar_Click(object sender, EventArgs e)
        {
            //aqui capturaremos la imagen
            if (PNConfirmacion.Visible != true) {
                try
                {
                    FuenteDeVideo.SignalToStop();
                    PNConfirmacion.Visible = true;

                }
                catch { MessageBox.Show("Hubo Un error en la captura"); }
            } else { MessageBox.Show("Tomar una nueva foto se debe descartar la Captura actual", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Error); };
        }


        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)

        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            try
            {
                PBVideoImage.Image = video;
            }
            catch {  };
            //pbFotoUser es nuestro pictureBox
        }

        private void PBAceptar_Click(object sender, EventArgs e)
        {
            PBVideoImage.Image.Save("Imagen de Perfil",ImageFormat.Jpeg);
            this.DialogResult = DialogResult.Yes;
            Afi.PBImgPerf.Image = PBVideoImage.Image;
            Close();
        }

        private void PBCancel_Click(object sender, EventArgs e)
        {
            PNConfirmacion.Visible = false;
            Iniciarlizar();
        }
    }
}
