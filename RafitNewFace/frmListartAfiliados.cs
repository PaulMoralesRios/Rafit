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
    public partial class frmListartAfiliados : Form
    {
        Conexion Con = new Conexion();
        Boolean activo = false;


        //Variables para Paginacion
        float TotalPag;
        int UltimoReg = 0, PagActual = 1;
        //String Total;
        //Parametros de Carga DataGrid
        String[] NombreParametro ;
        String[] ValorParametro;
        public frmListartAfiliados()
        {
            InitializeComponent();
            //CargarDataGridAfiliados("@UltReg",UltimoReg);
            //Paginacion();
        }

        public void CargarDataGridAfiliados(String Variable, int UltReg)
        {
            NombreParametro = new string[] { Variable };
            ValorParametro = new string[] { (UltReg).ToString() };
            Con.LLenarDataGrid("SP_LlamarAfiliados", DGListaAfiliados, NombreParametro, ValorParametro);
            LBPagAct.Text = PagActual.ToString();
        }


        private void DGListaAfiliados_MouseClick(object sender, MouseEventArgs e)
        {
            int LineaActual;
            if (e.Button == MouseButtons.Right)
            {
                MenuAfiliado.Show(DGListaAfiliados, new Point(e.X, e.Y));

                LineaActual = DGListaAfiliados.HitTest(e.X, e.Y).RowIndex;

                //DGListaAfiliados.Rows[LineaActual].Selected = true;
            }

     
        }


  


        private void HabilitarSeleccionMultiple()
        {
            if (activo == false)
            {
                ColumnSelect.Visible = true;

                DGListaAfiliados.MultiSelect = true;
                
                activo = true;
            }
            else
            {
                ColumnSelect.Visible = false;
                activo = false;
                
            }

        }


        //Funcion de Paginacion
        private void Paginacion()
        {
            String[] Variable = new String[] { "20" };
            String[] Parametro = new String[] { "@Vista" };
            SqlDataReader DataReader = Con.ProcedureObtenerDatos("ContabilizarRegistros", Parametro, Variable);
            if (DataReader.Read())
            {
                TotalPag = float.Parse(DataReader["Paginas"].ToString());
                DataReader.Close();
            }
            if (TotalPag % 1 == 0)
            {
                LBTotalPag.Text = (Convert.ToInt32(TotalPag)).ToString();

            }
            else { LBTotalPag.Text = (Convert.ToInt32(TotalPag) + 1).ToString(); }

        }

        private void PBNextPag_Click(object sender, EventArgs e)
        {
            //Siguiente Pagina
            if (PagActual < int.Parse(LBTotalPag.Text))
            {

                PagActual++;
                UltimoReg = +20;
                CargarDataGridAfiliados("@UltReg", UltimoReg);
            }
            else { MessageBox.Show("Esta en La Ultima Pagina", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void BTMultiselect_Click(object sender, EventArgs e)
        {
            HabilitarSeleccionMultiple();
        }

        private void BTNuevo_Click(object sender, EventArgs e)
        {
            frrmMasterStepFan Fanatico = new frrmMasterStepFan();
            Fanatico.ShowDialog();
        }

        //Opcion Menu Contextual


        private void PBBackPag_Click(object sender, EventArgs e)
        {
            //Pagina Anterior
            if (PagActual > 1)
            {
                PagActual--;
                UltimoReg = UltimoReg - 20;
                CargarDataGridAfiliados("@UltReg", UltimoReg);
            }
            else { MessageBox.Show("Esta en La Primera Pagina", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); }


        }



    }
}
