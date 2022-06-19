using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente:IFuncionalidades
    {
        
        private double id;
        private string nombre;
        private double cuenta;
        public List<Butaca> asientosReservados;
        


        //Constructores
        public Cliente(string nombre,double id, Butaca asiento):this(nombre,id)
        {
            
            asientosReservados.Add(asiento);
        }

        public Cliente(string nombre, double id):this()
        {
            this.nombre = nombre;
            this.id = id;
            cuenta = 0;
            
        }

        public Cliente()
        {
            asientosReservados = new List<Butaca>();
            
        }
        

        





        //Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public List<Butaca> AsientosReservados 
        { 
          get { return asientosReservados;} 
          set { asientosReservados = value;} 
        }





        
        /// <summary>
        /// devuelve un string con los datos del cliente
        /// </summary>
        /// <returns></returns>
        public  string Mostrar()
        {
            return $"|| Id: {this.id} || Nombre: {this.nombre} || Cuenta: { this.cuenta} || Butacas Reservadas: {ListarButacasReservadas()}";
        }

        /// <summary>
        /// Le suma el precio ingresado a la cuenta del cliente
        /// </summary>
        /// <param name="c"></param>
        /// <param name="precio"></param>
        /// <returns></returns>
        public static Cliente operator +(Cliente c, double precio)
        {

            if (c is not null && precio>0)
            {
                c.cuenta+=precio;
            }



            return c;
        }

        /// <summary>
        /// Le asocia la butaca b a la lista de butacas del cliente c
        /// </summary>
        /// <param name="c"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Cliente operator +(Cliente c, Butaca b)
        {

            if (c is not null && b is not null)
            {
                if(c != b)
                {
                    c.AsientosReservados.Add(b);
                }
                else
                {
                    throw new ValorInvalidoFueraDeRangoException("La butaca ya estaba asociada al cliente");
                }
            }
            else
            {
                throw new ValorInvalidoFueraDeRangoException("La butaca o el cliente fueron NULL");
            }



            return c;
        }

        /// <summary>
        /// Lista las butacas reservadas del cliente
        /// </summary>
        /// <returns></returns>
        public string ListarButacasReservadas()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Butaca asiento in asientosReservados)
            {
                sb.Append(asiento.Mostrar()+" ");
            }

            return sb.ToString();

        }

        

        /// <summary>
        /// Compara un cliente y una butaca, retornando true si el cliente tiene asociado esa butaca en su lista de butacas, false si no la tiene
        /// </summary>
        /// <param name="c"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente c,Butaca b)
        {

            foreach (Butaca asiento in c.AsientosReservados)
            {
                if(asiento==b)
                {
                    return true;
                }
            }

            return false;


        }

        public static bool operator !=(Cliente c,Butaca b)
        {
            return !(c == b);
        }



        /// <summary>
        /// Compara dos clientes por su id
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {

          

            return cliente1.Id==cliente2.Id;


        }

        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }




    }




}
