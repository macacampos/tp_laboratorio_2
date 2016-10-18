using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Gaseosa:Producto
    {
        protected float _litros;
        public static bool DeConsumo;

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return base._precio*0.42f;
            }
        }

        public override string Consumir()
        {
            return " Bebible ";
        }

        static Gaseosa()
        {
            DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, Producto.EMarcaProducto marca, float litros)
            : base(codigoBarra, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto p, float litros):this((int)p,p.Precio,p.Marca,litros)
        {
        }

        private string MostrarGaseosa()
        {
            return (Producto)this + " litros " + this._litros;
        }

        public override string ToString()
        {
            return this.MostrarGaseosa();
        }


    }
}
