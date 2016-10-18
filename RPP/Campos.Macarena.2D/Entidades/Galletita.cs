using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Galletita:Producto
    {
        protected float _peso;
        public static bool DeConsumo;

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return base._precio*0.33f;
            }
        }

        public override string Consumir()
        {
            return " Comestible ";
        }

        public Galletita(int codigoBarra, float precio, Producto.EMarcaProducto marca, float peso)
            : base(codigoBarra, marca, precio)
        {
            this._peso = peso;
        }

        private static string MostrarGalletita(Galletita galletita)
        {
            return ((Producto)galletita)+ " peso "+ galletita._peso.ToString();
        }

        static Galletita()
        {
            DeConsumo = true;
        }

        public override string ToString()
        {
            return Galletita.MostrarGalletita(this);
        }




    }
}
