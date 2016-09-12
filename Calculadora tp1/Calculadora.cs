using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_tp1
{
    class Calculadora
    {
        /// <summary>
        /// opera dependiendo el operador ingresado
        /// </summary>
        /// <param name="Numero1">primer numero ingresado</param>
        /// <param name="Numero2">segundo numero ingresado</param>
        /// <param name="Operador">operador entre el primer y segundo numero</param>
        /// <returns></returns>
        public static double operar(Numero Numero1, Numero Numero2, string Operador)
        {

            double resultado = 0;
            if (Calculadora.validarOperador(Operador) == "+")
            {
                resultado =Numero1.getNumero() + Numero2.getNumero();
            }
            if (Calculadora.validarOperador(Operador) == "-")
            {
                resultado = Numero1.getNumero() - Numero2.getNumero();
            }
            if (Calculadora.validarOperador(Operador) == "*")
            {
                resultado = Numero1.getNumero() * Numero2.getNumero();
            }
            if (Calculadora.validarOperador(Operador) == "/")
            {
                if (Numero2.getNumero() != 0)
                {
                    resultado = Numero1.getNumero() / Numero2.getNumero();
                }
            }

            return resultado;
        }
        /// <summary>
        /// valida que se ingrese un operador valido
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static string validarOperador(string operador)
        {
            string retorno = "+";
            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                retorno = operador;
 
            }
            return retorno;
            

        }
    }
}
