using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Jugo : Producto
    {
        protected ESaborJugo _sabor;
        public static bool DeConsumo;

        public enum ESaborJugo { Asqueroso, Pasable, Rico }

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return base._precio * 0.4f;
            }
        }

        public override string Consumir()
        {
            return " bebible ";
        }

        static Jugo()
        {
            DeConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, Producto.EMarcaProducto marca, Jugo.ESaborJugo sabor)
            : base(codigoBarra, marca, precio)
        {
            this._sabor = sabor;
        }

        private string MostrarJugo()
        {
            return ((Producto)this) + " sabor " + this._sabor.ToString();
        }

        public override string ToString()
        {
            return this.MostrarJugo();
        }

    }
}
