using System;
using System.Text;

namespace Logica
{
    public class Butaca:IFuncionalidades
    {

        private string lugar;
        private bool disponibilidad;
        

  
        public Butaca(string lugar, bool disponibilidad):this()
        {
            this.lugar = lugar;
            this.disponibilidad = disponibilidad;
        }

       
        public Butaca()
        {
           
            disponibilidad = true;
            lugar = null;
        }


        public bool Disponibilidad
        {
            get { return disponibilidad; }
            set { this.disponibilidad = value; }
        }

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }



        public  string Mostrar()
        {

            return ($"{this.lugar}");
        }


        public static bool operator ==(Butaca butaca1, Butaca butaca2)
        {



            return butaca1.lugar == butaca2.lugar;


        }

        public static bool operator !=(Butaca butaca1, Butaca butaca2)
        {



            return !(butaca1 == butaca2);


        }



    }
}
