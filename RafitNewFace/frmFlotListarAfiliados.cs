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
    public partial class frmFlotListarAfiliados : Form
    {
        Conexion Conn = new Conexion();
        public String Destinatarios;
        public List<String> Coleccion = null;
        public frmFlotListarAfiliados()
        {
            InitializeComponent();
            CargarLista();
        }


        public void CargarLista()
        {
            Conn.CargarChecklist(CHLAfiliados, "SPCARGARAFILIADOS", "Nombre", "Apellido", "Correo", "Id");

        }

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PBSelecAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CHLAfiliados.Items.Count; i++)
                CHLAfiliados.SetItemChecked(i, true);
        }

        private void PBSelecNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CHLAfiliados.Items.Count; i++)
                CHLAfiliados.SetItemChecked(i, false);
        }

        private void PBAceptar_Click(object sender, EventArgs e)
        {
            

            frmCompartir Div = new frmCompartir();
            Coleccion = new List<string>();
            foreach (Object Seleccionados in CHLAfiliados.CheckedItems)
            {
                Coleccion.Add(CHLAfiliados.GetItemText(Seleccionados).Split('(').Last().Split(')').First().ToString());
            }

            if (Coleccion.Count > 0)
                Destinatarios = "";

            foreach (String Datos in Coleccion)
            {
                Destinatarios += Datos + "; ";
            }
            this.DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
