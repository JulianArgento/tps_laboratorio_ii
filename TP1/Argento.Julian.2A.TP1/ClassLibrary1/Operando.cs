using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
         
        
            //Atributo numero

            private double numero;


            //Constructores


            /// <summary>
            /// constructor por defecto de la clase Operando
            /// </summary>
            public Operando()
            {
                this.numero = 0;
            }


            /// <summary>
            /// constructor que recibe un numero de tipo double para asignar a el atributo numero de la clase
            /// </summary>
            /// <param name="numero">numero que se asignara</param>
            public Operando(double numero)
            {
                this.numero = numero;

            }
            
            /// <summary>
            /// Sobrecarga del constructor Operando, recibe un numero en forma de string
            /// </summary>
            /// <param name="numero">numero a asignarse en el atributo numero</param>
            public Operando(string numero) : this(Double.Parse(numero))
            {

            }




            /// <summary>
            /// valida el operando de la operacion a realizar
            /// </summary>
            /// <param name="strNumero">operando a validar</param>
            /// <returns></returns>
            private double ValidarOperando(string strNumero)
            {
                
                //out del parse
                double numero;

                //valido que el string no este vacio y que el numero sea un double
                if (!string.IsNullOrEmpty(strNumero) && Double.TryParse(strNumero, out numero))
                {
                    

                    Double.TryParse(strNumero, out numero);

                    return numero;


                }

                return 0;
            }

            /// <summary>
            /// Propiedades getter y setter de el atributo numero
            /// </summary>
            public double Numero
            {

                get
                {
                    return this.numero;
                }
                set
                {

                    

                    this.numero = ValidarOperando(this.numero.ToString());


                }

            }

            /// <summary>
            /// Valida que el string pasado por parametro sea un numero binario
            /// </summary>
            /// <param name="binario">string a analizar</param>
            /// <returns>false en caso de que no sea binario, true en caso de que sea</returns>
            private bool EsBinario(string binario)
            {


                for (int i = 0; i < binario.Length; i++)
                {

                    //si entra al if no es binario
                    if (binario[i] != '0' && binario[i] != '1')
                    {

                        return false;

                    }

                }

                return true;

            }
            

            /// <summary>
            /// Convierte el numero binario contenido por el string a un numero decimal y lo retorna en forma de string
            /// </summary>
            /// <param name="binario">Binario a convertir</param>
            /// <returns>binario convertido o "valor invalido" en caso de que no sea binario </returns>
            public string BinarioDecimal(string binario)
            {



                if (EsBinario(binario))
                {


                    int resultado = Convert.ToInt32(binario, 2);

                    return resultado.ToString();

                }
                
                

            
                



                return "Valor invalido";
            }
            


            /// <summary>
            /// Convierte el numero decimal double en un numero binario positivo
            /// </summary>
            /// <param name="numero">numero a convertir</param>
            /// <returns>retorna el numero convertido a binario</returns>
            public string DecimalBinario(double numero)
            {

                if (EsBinario(numero.ToString()))
                {
                    //valido que el numero recibido no sea un binario
                    
                    return numero.ToString();
                }
                else if (numero >= 0)
                {

                    return Convert.ToString((int)numero, 2);

                }
                else
                {
                    //si el numero es negativo le saco el signo para pasarlo a binario
                    return Convert.ToString((int)numero*-1, 2);
                }

               


            }
            
            /// <summary>
            /// conversion de decimal a binario
            /// </summary>
            /// <param name="numero">numero a convertir en string</param>
            /// <returns>retorna el binario convertido a double decimal</returns>
            public string DecimalBinario(string numero)
            {



                return DecimalBinario(Double.Parse(numero));

            }

            /// <summary>
            /// sobrecarga del operador + para poder sumar objetos Operando
            /// </summary>
            /// <param name="n1">Objeto de clase operando 1</param>
            /// <param name="n2">Objeto de clase operando 2</param>
            /// <returns>retorna la suma de los campos numero de los objetos operando</returns>
            public static double operator +(Operando n1, Operando n2)
            {
                return n1.numero + n2.numero;

            }


            /// <summary>
            /// Sobrecarga del operador - para poder restar objetos operando
            /// </summary>
            /// <param name="n1">Objeto de clase operando 1</param>
            /// <param name="n2">Objeto de clase operando 2</param>
            /// <returns>retorna el resultado de la resta de los campos numero de los objetos operando</returns>
            public static double operator -(Operando n1, Operando n2)
            {
                return n1.numero - n2.numero;

            }



            /// <summary>
            /// Sobrecarga del operador / para poder dividir objetos operando
            /// </summary>
            /// <param name="n1">Objeto de clase operando 1</param>
            /// <param name="n2">Objeto de clase operando 2</param>
            /// <returns>retorna el resultado de la division de los 2 campos numero de los objetos</returns>
            public static double operator /(Operando n1, Operando n2)
            {
                if (n2.numero == 0)
                {
                    return double.MinValue;
                }


                return n1.numero / n2.numero;

            }
            

            /// <summary>
            /// Sobrecarga del operador * para poder multiplicar objetos operando
            /// </summary>
            /// <param name="n1">objeto de la clase operando1</param>
            /// <param name="n2">objeto de la clase operando2</param>
            /// <returns>retorna el resultado de la multiplicacion de los 2 campos numero de los objetos</returns>
            public static double operator *(Operando n1, Operando n2)
            {


                return n1.numero * n2.numero;

            }







    }
}

