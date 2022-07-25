using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class ClaseExtensora
    {

        /// <summary>
        /// Metodo de extension de la clase string que valida si un nombre es valido para ingresar en la base de datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static bool NombreEsValido(this string nombre)
        {
            if(nombre.Length<30 && !string.IsNullOrEmpty(nombre))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        /// <summary>
        /// Metodo de extension de la clase double que compara 2 numeros para poder ordenarlos de mayor a menor
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public static int CompararNumeros(this double numero1, double numero2)
        {

            if(numero1>numero2)
            {
                return -1;
            }
            else if(numero1<numero2)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }




    }
}
