using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafit.Entidades
{
   
   public class Membresia
    {
        #region Atributos
        //F09_MEMB_ID int Unchecked
        //F09_MEMB_NOMB varchar(30) Checked
        //F09_MEMB_DESC   varchar(50) Checked
        //F09_MEMB_PRECIO float Checked
        //F09_MEMB_FOTO image   Checked
        private long membresiaID;
        private string membresiaNombre;
        private double membresiaPrecio;
        private Bitmap membresiaImage;
        #endregion atributos

        #region Propiedades
        public long MembresiaID { get => membresiaID; set => membresiaID = value; }
        public string MembresiaNombre { get => membresiaNombre; set => membresiaNombre = value; }
        public double MembresiaPrecio { get => membresiaPrecio; set => membresiaPrecio = value; }
        public Bitmap MembresiaImage { get => membresiaImage; set => membresiaImage = value; }
        #endregion Propiedades

        #region Metodos
        public Membresia()
        {
            membresiaID = 0;
            membresiaNombre = string.Empty;
            membresiaPrecio = 0.0;
            membresiaImage = null;
        }
        public Membresia(long membresiaID, string membresiaNombre, float membresiaPrecio,Bitmap membresiaImage)
        {
            this.membresiaID = membresiaID;
            this.membresiaNombre = membresiaNombre;
            this.membresiaPrecio = membresiaPrecio;
            this.membresiaImage = membresiaImage;
        }
        #endregion Metodos



    }
}
