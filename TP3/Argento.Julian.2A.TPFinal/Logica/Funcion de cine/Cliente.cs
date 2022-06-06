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





        //Metodos

        public  string Mostrar()
        {
            return $"|| Id: {this.id} || Nombre: {this.nombre} || Cuenta: { this.cuenta} || Butacas Reservadas: {ListarButacasReservadas()}";
        }


        public static Cliente operator +(Cliente c, double precio)
        {

            if (c is not null && precio>0)
            {
                c.cuenta+=precio;
            }



            return c;
        }

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
                    throw new ValorInvalidoFueraDeRango("La butaca ya estaba asociada al cliente");
                }
            }
            else
            {
                throw new ValorInvalidoFueraDeRango("La butaca o el cliente fueron NULL");
            }



            return c;
        }

        public string ListarButacasReservadas()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Butaca asiento in asientosReservados)
            {
                sb.Append(asiento.Mostrar()+" ");
            }

            return sb.ToString();

        }


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
