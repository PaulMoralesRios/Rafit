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
    public partial class Visor_de_Imagenes : Form
    {
        public Visor_de_Imagenes()
        {
            InitializeComponent();
        }

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
