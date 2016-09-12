using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_tp1
{
    class Numero
    {
        /// <summary>
        /// se instancia el atributo numero
        /// </summary>
        private double _numero;
        
        /// <summary>
        /// inicializa el atributo numero en 0
        /// </summary>
        public Numero()
        {
            this._numero = 0;
        }
        /// <summary>
        /// valida el numero y lo carga
        /// </summary>
        /// <param name="Num">numero a validar</param>
        public Numero(string Num):this()
        {

            setNumero(Num);      
        }
        /// <summary>
        /// carga el numero 
        /// </summary>
        /// <param name="Num">numero a cargar</param>
        public Numero(double Num)
        {
            this._numero = Num;
        }
        /// <summary>
        /// valida que el numero sea un double y lo carga
        /// </summary>
        /// <param name="Num"></param>
        /// <returns>retorna el double validado o 0 en caso contrario</returns>
        private static double validarNumero(string Num)
        {
            double Numero = 0;
            double.TryParse(Num, out Numero);
            return Numero;

        }
        /// <summary>
        /// carga el numero ya validado
        /// </summary>
        /// <param name="Num"></param>
        private  void setNumero(string Num)
        {
            this._numero = Numero.validarNumero(Num);

        }
        /// <summary>
        /// retorna el atributo validado
        /// </summary>
        /// <returns></returns>
        public double getNumero()
        {
            return this._numero;
        }
    }
}
