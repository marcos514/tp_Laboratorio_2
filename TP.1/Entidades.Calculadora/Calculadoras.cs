using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Calculadora
{
    public class Calculadoras
    {

        /// <summary>
        /// Hace la operacion deceada entre dos datos de tipo Numero
        /// </summary>
        /// <param name="primerNumero">Primer numero en la operacion de tipo Numero</param>
        /// <param name="segundoNumero">Segundo numero en la operacion de tipo Numero</param>
        /// <param name="operador">string con el operando deseado</param>
        /// <returns>double con la operacion resuelta</returns>
        public static double operar(Numeros primerNumero, Numeros segundoNumero, string operador)
        {
            double resultado = 0;
            if (!(segundoNumero.getNumero() == 0 && operador == "/"))
            {
                switch (operador)
                {
                    case "+":
                        resultado = primerNumero.getNumero() + segundoNumero.getNumero();
                        break;
                    case "-":
                        resultado = primerNumero.getNumero() - segundoNumero.getNumero();
                        break;
                    case "*":
                        resultado = primerNumero.getNumero() * segundoNumero.getNumero();
                        break;
                    case "/":
                        resultado = primerNumero.getNumero() / segundoNumero.getNumero();
                        break;
                }
            }
            return resultado;
        }


        /// <summary>
        /// valida si un string es o no un operando valido
        /// </summary>
        /// <param name="operador">string </param>
        /// <returns>"+" si el operador no es correcto o el operador sin modificar si esta bien </returns>
        public static string validarOperador(string operador)
        {
            switch (operador)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    break;
                default:
                    operador = "+";
                    break;

            }
            return operador;
        }
    }
}
