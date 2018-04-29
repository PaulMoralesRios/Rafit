using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Rafit.Entidades
{
    public class Usuario
    {
        #region Atributos
        //F03_USUARIO_ID int Unchecked
        //F03_NOMBRE varchar(30) Checked
        //F03_APELLIDO    varchar(30) Checked
        //F03_USUARIO varchar(30) Checked
        //F03_PASSWORD    varchar(30) Checked
        //F03_ROL_ID  int Checked
        //F03_FOTO_USU image   Checked
        string usuarioId, usuarioNombre, usuarioApellido, usuarioNick, usuarioPassword;
        int usuarioRol;
        Bitmap image;
        #endregion atributos

        #region Propiedades
        public string UsuarioId { get => usuarioId; set => usuarioId = value; }
        public string UsuarioNombre { get => usuarioNombre; set => usuarioNombre = value; }
        public string UsuarioApellido { get => usuarioApellido; set => usuarioApellido = value; }
        public string UsuarioNick { get => usuarioNick; set => usuarioNick = value; }
        public string UsuarioPassword { get => usuarioPassword; set => usuarioPassword = value; }
        public int UsuarioRol { get => usuarioRol; set => usuarioRol = value; }
        public Bitmap Image { get => image; set => image = value; }
        #endregion Propiedades

        #region Metodos
        public Usuario()
        {
            usuarioId = string.Empty;
            usuarioNombre = string.Empty;
            usuarioApellido = string.Empty;
            usuarioNick = string.Empty;
            usuarioPassword = string.Empty;
            usuarioRol = 1;
            image = null;
        }
        

        public Usuario(string usuarioId, string UsuarioNombre, string usuarioApellido, string usuarioNick, string UsuarioPassword, int usuarioRol,Bitmap image)
        {
            this.usuarioId = usuarioId;
            this.UsuarioNombre = UsuarioNombre;
            this.usuarioApellido = usuarioApellido;
            this.usuarioNick = usuarioNick;
            this.usuarioPassword = UsuarioPassword;
            this.usuarioRol = usuarioRol;
            this.image = image;
        }

        #endregion Metodos


    }
}
