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
    public partial class frmListarUsuarios : Form
    {
        Conexion Conn = new Conexion();
        //Boolean Seleccion = false;
        public frmListarUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }


        public void CargarUsuarios()
        {
            FlowUsuarios.Controls.Clear();

            SqlDataReader Reader = Conn.ObtenerDatosSinParametros("SP_T03_USUARIOS_MOSTRAR");

            while (Reader.Read())
            {

                Panel Usuario = new Panel() { 
                     Width = 334,
                     Height = 170, //334; 170
                     BorderStyle = BorderStyle.None,
                     BackColor = Color.Transparent,
                    BackgroundImage = Rafit.Face.Properties.Resources.commlawnbkgd3,
                    BackgroundImageLayout = ImageLayout.Stretch,
                     Font = new Font("Century Gothic", 10F)

                };

                PictureBox ImagenPerfil = new PictureBox()
                {
                     Width = Usuario.Width/3 +(22),
                     Dock = DockStyle.Left,
                     BackColor = Color.Transparent,
                     Image = Rafit.Face.Properties.Resources.IMG_20160117_WA0040,
                    SizeMode = PictureBoxSizeMode.Zoom
                };


                PictureBox VerMas = new PictureBox() {
                    BackgroundImage = Rafit.Face.Properties.Resources.icons8_Plus_48px,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Location = new Point(225, 138),
                    Size = new Size(33, 29),
                    Cursor = Cursors.Hand

                };
                PictureBox Editar = new PictureBox() {
                    BackgroundImage = Rafit.Face.Properties.Resources.icons8_Edit_Property_48px,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Location = new Point(264, 138),
                    Size = new Size(33, 29),
                    Cursor = Cursors.Hand
                };
                PictureBox Eliminar = new PictureBox() {
                    BackgroundImage = Rafit.Face.Properties.Resources.icons8_Delete_48px,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Location = new Point(296, 138),
                    Size = new Size(33, 29),
                    Cursor = Cursors.Hand
                };

                Label Nombre = new Label()
                {

                    Text = Reader["F03_NOMBRE"].ToString(),
                    ForeColor = Color.Gray,
                    Location = new Point(139, 20)
                  
                };
                Label Aplleido = new Label()
                {

                    Text = Reader["F03_APELLIDO"].ToString(),
                    ForeColor = Color.Gray,
                    Location = new Point(139, 50)
                };
                Label Rol = new Label()
                {

                    Text = Reader["F03_ROL_ID"].ToString(),
                    ForeColor = Color.Gray,
                    Location = new Point(139, 80)
                };

                CheckBox Seleccion = new CheckBox {
                    Cursor = Cursors.Hand,
                    //Checked = true,
                    Visible = false,
                    Size = new Size(50,50),
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(300, 17)
                };



                Seleccion.FlatAppearance.BorderColor = Color.Gray;

                Usuario.Controls.Add(ImagenPerfil);
                //Usuario.Controls.Add(InfoUsuario);
                Usuario.Controls.Add(Nombre);
                Usuario.Controls.Add(Aplleido);
                Usuario.Controls.Add(Rol);
                Usuario.Controls.Add(Seleccion);
                Usuario.Controls.Add(VerMas);
                Usuario.Controls.Add(Editar);
                Usuario.Controls.Add(Eliminar);
                FlowUsuarios.Controls.Add(Usuario);

            }

        }

        private void BTNuevo_Click(object sender, EventArgs e)
        {
            frmCrearUsuario Fusuario = new frmCrearUsuario();
            Fusuario.ShowDialog();
        }

        private void BTMultiselect_Click(object sender, EventArgs e)
        {
            
                foreach (Control Paneles in FlowUsuarios.Controls)
                {

                    if (Paneles is Panel)
                    {

                        foreach (Control Controles in Paneles.Controls)
                        {
                            if (Controles is CheckBox)
                            {
                             Controles.Visible = true;
                            PBCancelar.Visible = true;
                            }
                        }
                    }
                }
               
         }

        private void PBCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control Paneles in FlowUsuarios.Controls)
            {

                if (Paneles is Panel)
                {

                    foreach (Control Controles in Paneles.Controls)
                    {
                        if (Controles is CheckBox)
                        {   
                            Controles.Visible = false;
                            PBCancelar.Visible = false;

                        }
                    }
                }
            }



        }
    }
}
