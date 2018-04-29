using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafitNewFace
{

    public class MedioPago
    {
        #region Atributos
        //F015_MP_ID int Unchecked
        //F015_MP_NOMBRE varchar(30) Checked
        //F015_MP_DESC    varchar(50) Checked
        //F015_MP_TIPO    int Checked
        //F015_MP_IMG image   Checked
        private long medioPagId;
        private string medioPagoNombre;
        private string medioPagoDescripcion;
        private int medioPagoTipo;
        private Bitmap medioPagoImagen;
        #endregion atributos

        #region Propiedades
        public long MedioPagId { get => medioPagId; set => medioPagId = value; }
        public string MedioPagoNombre { get => medioPagoNombre; set => medioPagoNombre = value; }
        public string MedioPagoDescripcion { get => medioPagoDescripcion; set => medioPagoDescripcion = value; }
        public int MedioPagoTipo { get => medioPagoTipo; set => medioPagoTipo = value; }
        public Bitmap MedioPagoImagen { get => medioPagoImagen; set => medioPagoImagen = value; }
        #endregion Propiedades

        #region Metodos
        public MedioPago()
        {
            medioPagId = 0;
            medioPagoNombre =string.Empty;
            medioPagoDescripcion = string.Empty;
            medioPagoTipo = 0;
            medioPagoImagen = null;

        }
        public MedioPago( long medioPagId, string medioPagoNombre, string medioPagoDescripcion, int medioPagoTipo, Bitmap medioPagoImagen)
        {
            this.medioPagId = medioPagId;
            this.medioPagoNombre =medioPagoNombre;
            this.medioPagoDescripcion = medioPagoDescripcion;
            this.medioPagoTipo = medioPagoTipo;
            this.medioPagoImagen = medioPagoImagen;

    }
        #endregion Metodos




    }
}
