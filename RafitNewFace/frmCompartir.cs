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
    public partial class frmCompartir : Form
    {
        String Destinatarios = string.Empty;
        frmFlotListarAfiliados List = new frmFlotListarAfiliados();
        public frmCompartir()
        {
            InitializeComponent();
        }

        private void PBEnviar_Click(object sender, EventArgs e)
        {
            frmCargandoEnviarMensaje Carga = new frmCargandoEnviarMensaje();
            Carga.ShowDialog();
        }

        private void BTBuscarAfi_Click(object sender, EventArgs e)
        {
            frmFlotListarAfiliados List = new frmFlotListarAfiliados();
            if (List.ShowDialog() == DialogResult.Yes)
            {
                TBAfiliadosSelecc.Text = List.Destinatarios;
            }
        }


        private void PBDescartar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
