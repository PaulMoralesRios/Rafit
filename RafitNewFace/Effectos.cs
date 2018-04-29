using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace RafitNewFace
{
    class Effectos
    {
        public void slideHorizontalafuera(Panel Panel, int SizeH, int SizeV, int Desp, int tiempo)
        {

            for (int i = SizeH; i <= Desp; i++)
            {
                Panel.Size = new Size(i, SizeV);
                Thread.Sleep(tiempo);
            }
        }


        public void slideHorizontaladentro(Panel Panel, int SizeH, int SizeV, int Desp, int tiempo)
        {
            for (int i = Desp; i >= SizeH; i--)
            {
                Panel.Size = new Size(i, SizeV);
                Thread.Sleep(tiempo);
            }

        }



        public void MostrarMenu(Panel PanelContenedor, Object Ventana)
        {
            if (PanelContenedor.Controls.Count > 0)
            {
                PanelContenedor.Controls.RemoveAt(0);
            }
            Form Vent = Ventana as Form;
            Vent.TopLevel = false;

            Vent.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Add(Vent);
            PanelContenedor.Tag = Vent;
            Vent.Show();
        }
    }

}
