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
    public partial class frmCrearEvento : Form
    {
        string[] Meses = new string[] {"Enero", "Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
        Conexion Conn = new Conexion();
        //String[] Parametros, Valores;
        public frmCrearEvento()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void PBImagenEvent_Click(object sender, EventArgs e)
        {
            Visor_de_Imagenes Imagen = new Visor_de_Imagenes();
            Imagen.PBVisorImagen.Image = PBImagenEvent.Image;
            Imagen.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Image Files|*.PNG; *.JPG; *.GIF";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                PBImagenEvent.Image = Image.FromFile(opd.FileName);
            }
        }

        private void PBAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MCFecha_DateSelected(object sender, DateRangeEventArgs e)
        {
            LBNoDia.Text = MCFecha.SelectionStart.ToShortDateString().Split('/').First().ToString();
            int mes = Int32.Parse(MCFecha.SelectionStart.Month.ToString());
            LBMes.Text = Meses[mes-1];
            LBDiaSem.Text = MCFecha.SelectionStart.ToLongDateString().Split(',').First().Split(' ').First().Split(' ').Last().ToString();
            //LBMes.Text = MCFecha.SelectionStart.ToLongTimeString();

        }

        public void CargarCombos()
        {
           

            Conn.CargarCombo(CBUsuarioOrg, "[SPCARGARUSUARIOS]", "Nombre","Apellido","Id_Usu");

        }



    }
}
