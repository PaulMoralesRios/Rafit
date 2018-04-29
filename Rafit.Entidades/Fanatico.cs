using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafit.Entidades
{
  public class Fanatico
    {
        #region Atributos
        //F04_FAN_ID int Unchecked
        //F04_FAN_TIPO_DOCID int Checked
        //F04_FAN_DOCID int Checked
        //F04_FAN_NOMBRE varchar(30) Checked
        //F04_FAN_APELLIDO    varchar(30) Checked
        //F04_FAN_TELEFONO    varchar(10) Checked
        //F04_FAN_FECH_NAC    date Checked
        //F04_FAN_CELULAR varchar(10) Checked
        //F04_FAN_GENERO  varchar(10) Checked
        //F04_FAN_DIRECC  varchar(50) Checked
        //F04_FAN_CORREO  varchar(40) Checked
        //F04_FAN_ID_MEMB int Checked
        //F04_FAN_ID_PROM int Checked
        //F04_FAN_FECH_VENC date    Checked
        //F04_FAN_FOTO    image Checked
        private long fanaticoID;
        private int fanaticoTipoId;
        private long fanaticoDocId;
        private string fanaticoNombre;
        private string fanaticoApellido;
        private string fanaticoTelefono;
        private DateTime fanaticoFechaNacimiento;
        private string fanaticoCelular;
        private string fanaticoGenero;
        private string fanaticoDireccion;
        private string fanaticoCorreo;
        private int fanaticoIdMembresia;
        private int fanaticoIdPromocion;
        private DateTime fanaticoFechaVencimiento;
        private Bitmap fanaticoImagen;
        #endregion atributos

        #region Propiedades
        public long FanaticoIDM { get => fanaticoID; set => fanaticoID = value; }
        public int FanaticoTipoId { get => fanaticoTipoId; set => fanaticoTipoId = value; }
        public long FanaticoDocId { get => fanaticoDocId; set => fanaticoDocId = value; }
        public string FanaticoNombre { get => fanaticoNombre; set => fanaticoNombre = value; }
        public string FanaticoApellido { get => fanaticoApellido; set => fanaticoApellido = value; }
        public string FanaticoTelefono { get => fanaticoTelefono; set => fanaticoTelefono = value; }
        public DateTime FanaticoFechaNacimiento { get => fanaticoFechaNacimiento; set => fanaticoFechaNacimiento = value; }
        public string FanaticoCelular { get => fanaticoCelular; set => fanaticoCelular = value; }
        public string FanaticoGenero { get => fanaticoGenero; set => fanaticoGenero = value; }
        public string FanaticoDireccion { get => fanaticoDireccion; set => fanaticoDireccion = value; }
        public string FanaticoCorreo { get => fanaticoCorreo; set => fanaticoCorreo = value; }
        public int FanaticoIdMembresia { get => fanaticoIdMembresia; set => fanaticoIdMembresia = value; }
        public int FanaticoIdPromocion { get => fanaticoIdPromocion; set => fanaticoIdPromocion = value; }
        public DateTime FanaticoFechaVencimiento { get => fanaticoFechaVencimiento; set => fanaticoFechaVencimiento = value; }
        public Bitmap FanaticoImagen { get => fanaticoImagen; set => fanaticoImagen = value; }
        #endregion Propiedades

        #region Metodos
        public Fanatico()
        {
            fanaticoID = 0 ;
            fanaticoTipoId = 0;
            fanaticoDocId = 0;
            fanaticoNombre = string.Empty;
            fanaticoApellido = string.Empty;
            fanaticoTelefono = string.Empty;
            fanaticoFechaNacimiento = DateTime.Now;
            fanaticoCelular = string.Empty;
            fanaticoGenero = string.Empty;
            fanaticoDireccion = string.Empty;
            fanaticoCorreo = string.Empty;
            fanaticoIdMembresia = 0;
            fanaticoIdPromocion = 0;
            fanaticoFechaVencimiento = DateTime.Now;
            fanaticoImagen = null;
        }

        public Fanatico( long fanaticoID,int fanaticoTipoId, long fanaticoDocId, string fanaticoNombre, string fanaticoApellido,
         string fanaticoTelefono, DateTime fanaticoFechaNacimiento,string fanaticoCelular,string fanaticoGenero, string fanaticoDireccion,
         string fanaticoCorreo, int fanaticoIdMembresia,int fanaticoIdPromocion, DateTime fanaticoFechaVencimiento, Bitmap fanaticoImagen)
        {
            this.fanaticoID               = fanaticoID;
            this.fanaticoTipoId            = fanaticoTipoId;
            this.fanaticoDocId             = fanaticoDocId;
            this.fanaticoNombre            = fanaticoNombre;
            this.fanaticoApellido          = fanaticoApellido;
            this.fanaticoTelefono          = fanaticoTelefono;
            this.fanaticoFechaNacimiento   = fanaticoFechaNacimiento;
            this.fanaticoCelular           = fanaticoCelular;
            this.fanaticoGenero            = fanaticoGenero;
            this.fanaticoDireccion         = fanaticoDireccion;
            this.fanaticoCorreo            = fanaticoCorreo;
            this.fanaticoIdMembresia       = fanaticoIdMembresia;
            this.fanaticoIdPromocion       = fanaticoIdPromocion;
            this.fanaticoFechaVencimiento  = fanaticoFechaVencimiento;
            this.fanaticoImagen            = fanaticoImagen;
        }

        #endregion Metod
    }

}