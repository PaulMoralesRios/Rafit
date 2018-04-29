using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafitNewFace
{
    class Dispositivos
    {

        //Boolean Existenciadispositivos = false;
        //FilterInfoCollection DispositivosDeVideo;
       

        //Cargar Dispositivos de Camara del Pc
        public void CargarDispositivos(FilterInfoCollection Dispositivos, ComboBox CBDispositivos)
        {
            if (Dispositivos.Count > 0)
            {
                for (int i = 0; i < Dispositivos.Count; i++)
                {

                    CBDispositivos.Items.Clear();
                    CBDispositivos.Items.Add(Dispositivos[i].Name.ToString());

                }

                CBDispositivos.SelectedIndex = 0;
            }
            else
            {
                CBDispositivos.Items.Clear();
                CBDispositivos.Items.Add("No se Encontraron Dispositivos disponibles");
            }
        }


        public void iniciarCamara( VideoCaptureDevice Camara)
        {
            
            Camara.Start();
            
        }

        public void DetenerCamara(VideoCaptureDevice Camara)
        {
            if (Camara.IsRunning) {

                Camara.SignalToStop();
                Camara = null;
            }
        }




    }
}
