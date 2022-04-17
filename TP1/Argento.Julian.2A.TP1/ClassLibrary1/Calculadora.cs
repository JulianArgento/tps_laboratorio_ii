using System;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Valida el operador pasado por parametro
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>retorna el operador ingresado en caso de ser valido, retorna el operador '+' en caso de que el ingresado
        /// sea invalido</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                return '+';
            }


                return operador;
        }


        /// <summary>
        /// Realiza la operacion entre los numeros ingresados
        /// </summary>
        /// <param name="num1">Primer numero a operar</param>
        /// <param name="num2">Segundo numero a operar</param>
        /// <param name="operador">Operador del calculo que se desee realizar</param>
        /// <returns>retorna el resultado de la cuenta, en caso de que el operador no sea valido retornara un 0</returns>
        public static double Operar(Operando num1, Operando num2 , char operador)
        {
            
            char op = ValidarOperador(operador);





            switch(op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '/':
                    return num1 / num2;
                case '*':
                    return num1 * num2;

            }


           

            return 0;

        }


    }


    

    









}
