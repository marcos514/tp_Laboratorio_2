using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Calculadora
{
    public class Numeros
    {

        private double numero;

        #region Constructores  
        
        /// <summary>
        /// constructor por defecto que inicializa el atributo numero en 0
        /// </summary>
        public Numeros() : this("0")
        {

        }

        /// <summary>
        /// constructor con un parametro de tipo string
        /// </summary>
        /// <param name="numero">string con el valor para inicializar el atributo numero</param>
        public Numeros(string numero)
        {
            this.setNumero(numero);
        }

        /// <summary>
        /// constructor con un parametro de tipo double
        /// </summary>
        /// <param name="numero">double con el valor para inicializar el atributo numero</param>
        public Numeros(double numero) : this(Convert.ToString(numero))
        {

        }
        #endregion Constructores

        #region Metodos Estaticos  
        /// <summary>
        /// valida si el string contiene solo numeros 
        /// </summary>
        /// <param name="numero">string </param>
        /// <returns>0 si el string no son todos numeros o el numero que representa el string</returns>
        private static double validarNumero(string numero)
        {
            double retorno = 0;
            double.TryParse(numero, out retorno);
            return retorno;
        }
        #endregion Metodos Estaticos 

        #region Metodos Instancia

        /// <summary>
        /// Devuelve el valor del atributo numero
        /// </summary>
        /// <returns>double</returns>
        public double getNumero()
        {
            return this.numero;
        }

        /// <summary>
        /// Reemplaza el valor del atributo numero por el string que se le pasa
        /// </summary>
        /// <param name="numero">string para ingresar en el atributo numero</param>
        private void setNumero(string numero)
        {
            this.numero = Numeros.validarNumero(numero);
        }
        #endregion Metodos Instancia 
    }
}
