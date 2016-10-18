using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Harina:Producto
    {
        protected ETipoHarina _tipo;
        public static bool DeConsumo;

        public enum ETipoHarina { CuatroCeros, Integral }

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return base._precio*0.6f;
            }
        }

         static Harina()
        {
            DeConsumo = true;
        }

         public Harina(int codigoBarra, float precio, Producto.EMarcaProducto marca, Harina.ETipoHarina tipo)
            : base(codigoBarra, marca, precio)
        {
            this._tipo = tipo;
        }

        private string MostrarHarina()
        {
            return (Producto)this + " tipo " + this._tipo;
        }

        public override string ToString()
        {
            return this.MostrarHarina();
        }

    }
}
