using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _producto;

        private Estante()
        {
            this._producto = new List<Producto>();
        }

        public Estante(sbyte capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProductos()
        {
            return this._producto;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder ret = new StringBuilder();

            foreach (Producto pro in e._producto)
            {
                if (pro is Jugo)
                {
                    ret.AppendLine(((Jugo)pro).ToString());
                }
                if (pro is Harina)
                {
                    ret.AppendLine(((Harina)pro).ToString());
                }
                if (pro is Galletita)
                {
                    ret.AppendLine(((Galletita)pro).ToString());
                }
                if (pro is Gaseosa)
                {
                    ret.AppendLine(((Gaseosa)pro).ToString());
                }
            }

            return ret.ToString();
        }

        public static bool operator ==(Estante e, Producto prod)
        {
            bool ret = false;

            foreach (Producto p in e._producto)
            {
                if (p == prod)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }

        public static bool operator +(Estante e, Producto prod)
        {
            bool ret = false;
            if (e != prod && e._producto.Count < e._capacidad)
            {
                ret = true;
            }

            return ret;
        }

        public static Estante operator -(Estante e, Producto prod)
        {
            int i;

            for (i = 0; i < e._producto.Count; i++)
            {
                if (e._producto[i] == prod)
                {
                    e._producto.Remove(prod);
                    break;
                }
            }
            return e;
        }

        public static Estante operator -(Estante e, Producto.ETipoProducto tipo)
        {
             int i;

             for (i = 0; i < e._producto.Count; i++)
             {
                 if (tipo == Producto.ETipoProducto.Galletita && e._producto[i] is Galletita)
                 {
                     e = e - e._producto[i];
                     i--;
                 }
                 if (tipo == Producto.ETipoProducto.Jugo && e._producto[i] is Jugo)
                 {
                     e = e - e._producto[i];
                     i--;
                 }
                 if (tipo == Producto.ETipoProducto.Gaseosa && e._producto[i] is Gaseosa)
                 {
                     e = e - e._producto[i];
                     i--;
                 }
                 if (tipo == Producto.ETipoProducto.Harina && e._producto[i] is Harina)
                 {
                     e = e - e._producto[i];
                     i--;
                 }

             }
             return e;
        }

        public float GetValorEstante(Producto.ETipoProducto tipo)
        {
            int i;
            float ret = 0;

            for (i = 0; i < this._producto.Count; i++)
            {
                if (tipo == Producto.ETipoProducto.Galletita && this._producto[i] is Galletita)
                {
                    ret = ret + this._producto[i].Precio;
                }
                if (tipo == Producto.ETipoProducto.Jugo && this._producto[i] is Jugo)
                {

                    ret = ret + this._producto[i].Precio;
                }
                if (tipo == Producto.ETipoProducto.Gaseosa && this._producto[i] is Gaseosa)
                {
                    ret = ret + this._producto[i].Precio;
                }
                if (tipo == Producto.ETipoProducto.Harina && this._producto[i] is Harina)
                {
                    ret = ret + this._producto[i].Precio;
                }
                if (tipo == Producto.ETipoProducto.Todos)
                {
                    ret = ret + this._producto[i].Precio;
                }

          }
            return ret;
        }

        private float GetValorEstante()
        {
            float ret = 0;

            foreach (Producto prod in this._producto)
            {
                ret = ret + prod.Precio;
            }
            return ret;
        }

        public float ValorEstanteTotal
        {
            get
            {
                return GetValorEstante();
            }
        }
    }
}
