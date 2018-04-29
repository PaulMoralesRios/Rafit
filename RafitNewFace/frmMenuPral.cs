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
    public partial class frmMenuPral : Form
    {
        Effectos Ef = new Effectos();
        Conexion Conn = new Conexion();
        Inicio_Sesion Login = new Inicio_Sesion();
        string[] Parametros, Valores;

        public frmMenuPral()
        {
            InitializeComponent();

        }

        private void PBFlecha_Click(object sender, EventArgs e)
        {
            SlidePanel();
        }


        private void SlidePanel()
        {
            //Delegado = new Delegate(Effect.slideHorizontaladentro);

            if (PNNotificacion.Width == 30)
            {
                Ef.slideHorizontalafuera(PNNotificacion, 30, 581, 371, 0);

            }
            else if (PNNotificacion.Width == 371)
            {

                PNNotificacion.Size = new Size(30, 581);
            }

        }

        private void cambiarModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFlotListarModulos Modulo = new frmFlotListarModulos();
            if (Modulo.ShowDialog() == DialogResult.Yes)
            {
                //PBModulo.Image = Modulo.PBModuloSelec.Image;
                PBModulo.Tag = Modulo.PBModuloSelec.Tag;
                CargarMenuModulo();

            }
           
        }


        private void PBMenuPerfil_Click(object sender, EventArgs e)
        {
            Point ptLowerLeft = new Point(PBMenuPerfil.Location.X+(Menuperfil.Width/2),PBMenuPerfil.Location.Y+Menuperfil.Height);
            Menuperfil.Show(ptLowerLeft);

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Esto deberia abrir el Login
            ActiveForm.Hide();
            Login.Show();
            
        }

        private void PBModulo_BackgroundImageChanged(object sender, EventArgs e)
        {
            CargarMenuModulo();
        }

        public void CargarMenuModulo()
        {
            FlowMenu.Controls.Clear();
            Parametros = new string[] { "@IN_ID_MOD" };
            Valores = new string[] { PBModulo.Tag.ToString() };


            SqlDataReader Reader = Conn.ProcedureObtenerDatos("SP_T02_SUBMENU_MOD_MOSTRAR", Parametros,Valores);

                while (Reader.Read())
                {

                Button subMenu = new Button()
                {
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(110, 30),
                    BackgroundImage = Rafit.Face.Properties.Resources.Boton_Transparente,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Name = Reader["F02_MODULO_SUBMENU_ID"].ToString(),
                    Text = Reader["F02_SUBMENU_NAME"].ToString(),
                    ForeColor = Color.White,
                                     

                 };
                subMenu.FlatAppearance.BorderSize = 0;
                subMenu.Click += new EventHandler(AbrirMenu);
                FlowMenu.Controls.Add(subMenu);
                
               
                }
            Reader.Close();
        }

        //Abre El menu Indicado Segun Tabla
        void AbrirMenu(object sender, EventArgs e)
        {
            Button Submenu = (Button)sender;

            switch (Submenu.Text)
            {
                case "Aficionados":
                    Ef.MostrarMenu(Contenedor, new frmListartAfiliados());
                    break;
                case "Usuarios":
                    Ef.MostrarMenu(Contenedor, new frmListarUsuarios());
                    //Ef.MostrarMenu(Contenedor, new GestAfiliados());
                    break;

            }

        }
        
    }
}

