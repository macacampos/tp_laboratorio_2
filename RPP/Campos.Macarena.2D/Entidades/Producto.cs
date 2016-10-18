using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected int _codigoDeBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public enum EMarcaProducto { Manaos, Pitusas, Naranjú, Diversión, Swift, Favorita }
        public enum ETipoProducto { Harina, Galletita, Gaseosa, Jugo, Todos }

        public virtual float CalcularCostoDeProduccion
        {
            get { return 0f; }
        }
        public EMarcaProducto Marca
        {
            get { return this._marca; }
        }
        public float Precio
        {
            get { return this._precio; }
        }

        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._precio = precio;
            this._marca = marca;
            this._codigoDeBarra = codigoBarra;
        }

        private static string MostrarProducto(Producto p)
        {
            return " el codigo de barra es " + p._codigoDeBarra + " marca " + p._marca + " precio " + p._precio; 
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool ret = false;
            if (p1.GetType() == p2.GetType() && p1._marca == p2._marca && p1._codigoDeBarra == p2._codigoDeBarra)
            {
                ret = true;
            }
            return ret;     
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p, EMarcaProducto m)
        {
            bool ret = false;
            if (p._marca == m)
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Producto p, EMarcaProducto m)
        {
            return !(p == m);
        }

        public static explicit operator int(Producto p)
        {
            return p._codigoDeBarra;
        }

        public static implicit operator string(Producto p)
        {
            return Producto.MostrarProducto(p);
        }

        public override bool Equals(Object obj)
        {
            return this.GetType()==obj.GetType();
        }

        public virtual string Consumir()
        {
            return " Parte de una mezcla ";
        }


    }
}
