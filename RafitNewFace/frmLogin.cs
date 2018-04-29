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
    public partial class Inicio_Sesion : Form
    {
        
        public Inicio_Sesion()
        {
            InitializeComponent();
            TBusuario.GotFocus += Placeholderin;
            TBusuario.LostFocus += Placeholderout;
            TBContraseña.GotFocus += Placeholderin;
            TBContraseña.LostFocus += Placeholderout;
        }

        private void BTInicioSesion_Click(object sender, EventArgs e)
        {
            if (TBusuario.Text != "Usuario" || TBContraseña.Text != "Contraseña")
            {
                if (TBusuario.Text == "Paul" && TBContraseña.Text == "123")
                {
                    frmMenuPral Men = new frmMenuPral();
                    ActiveForm.Hide();
                    Men.Show();
                }
                else {
                    PBiconerror.Visible = true;                     
                    LBMensajeError.Visible = true;
                    PBIconoAlerta.Visible = false;
                    LBMensajealerta.Visible = false;
                }
            }
            else { PBIconoAlerta.Visible = true;
                   LBMensajealerta.Visible = true;
                PBiconerror.Visible = false;
                LBMensajeError.Visible = false;
            };
        }

        public void Placeholderin(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            switch (tx.Text)
            {
                case("Usuario"):
                    tx.Text = "";
                    LBUsuario.Visible = true;
                    tx.ForeColor = Color.Black;
                    break;
                case ("Contraseña"):
                    tx.Text = "";
                    
                    
                    LBContraseña.Visible = true;
                    tx.ForeColor = Color.Black;
                    tx.PasswordChar = '*';
                    break;

            }

        }
        public void Placeholderout(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            if (tx.Text == String.Empty)
            { 
                if (tx.Name == "TBusuario")
                {
                    tx.Text = "Usuario";
                    LBUsuario.Visible = false;
                    tx.ForeColor = Color.LightSlateGray;
                }

                if (tx.Name == "TBContraseña")
                {
                    tx.UseSystemPasswordChar = false;
                    tx.Text = "Contraseña";
                    LBContraseña.Visible = false;
                    tx.ForeColor = Color.LightSlateGray;
                }
            }
         }

        

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
