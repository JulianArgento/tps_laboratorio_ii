using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Pochoclos : IConsumiciones, IFuncionalidades
    {
        public bool esSalado;
        ETamanio tamanio;
        double precio;

        public Pochoclos(ETamanio tamanio, bool esSalado) 
        {
            this.esSalado = esSalado;
            this.tamanio = tamanio;
        }

        public bool EsSalado
        {
            get { return esSalado; }
            set { esSalado = value; }
        }


        public double Precio
        {

            get
            {
                switch (tamanio)
                {

                    case ETamanio.Chico:
                        return 400;

                    case ETamanio.Mediano:
                        return 500;

                    case ETamanio.Grande:
                        return 600;



                    default:
                        return 0;
                }

            }
            set
            {
                precio = value;
            }

        }

        public ETamanio Tamanio
        {
            get { return tamanio; }
            set { tamanio = value; }
        }

        public  string Mostrar()
           {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Producto: Pochoclos");
                
                if(esSalado==true)
                {
                sb.AppendLine($"Tipo: Salado");
                }
                else
                {
                sb.AppendLine($"Tipo: Dulce");
                }

                sb.AppendLine($"Tamanio: {this.tamanio}");

                sb.AppendLine($"Precio: {this.precio}");


            return sb.ToString();

           }


        public static bool operator ==(Pochoclos comida1, Pochoclos comida2)
        {

            

            return comida1.esSalado==comida2.esSalado && comida1.Precio==comida2.Precio && comida1.Tamanio == comida2.Tamanio;


        }

        public static bool operator !=(Pochoclos c, Pochoclos b)
        {



            return !(c==b);


        }


    }













}

