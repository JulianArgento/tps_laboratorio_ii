using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Gaseosa:IConsumiciones, IFuncionalidades
    {
        public EMarca marca;
        public ETamanio tamanio;
        public double precio;

        

        public Gaseosa(ETamanio tamanio, EMarca marca) 
        {
            this.marca = marca;
        }


        public EMarca Marca
        {
            get { return marca; }
            set { marca = value; }
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
        
        public ETamanio Tamanio {
            get { return tamanio; }
            set { tamanio=value; }
        }

        public  string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Producto: Gaseosa");

            sb.AppendLine($"Marca: {this.marca}");

            sb.AppendLine($"Tamanio: {this.tamanio}");

            sb.AppendLine($"Precio: {this.precio}");


            return sb.ToString();

        }


        public static bool operator ==(Gaseosa bebida1, Gaseosa bebida2)
        {



            return bebida1.marca == bebida2.marca && bebida1.precio == bebida2.precio && bebida1.precio == bebida2.precio;


        }

        public static bool operator !=(Gaseosa c, Gaseosa b)
        {



            return !(c == b);


        }

    }
}
