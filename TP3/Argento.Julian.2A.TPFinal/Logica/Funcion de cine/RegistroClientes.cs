using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class RegistroClientes: IFuncionalidades
    {
        
        List<Cliente> clientesRegistrados;

        public List<Cliente> ClientesRegistrados { get => clientesRegistrados; set => clientesRegistrados = value; }

        public RegistroClientes()
        {
            ClientesRegistrados = new List<Cliente>();
        }


        public void CargarArchivoClientes()
        {



            
                ClientesRegistrados = ClaseSerializadoraJson<List<Cliente>>.LeerArchivo("lista");
           





        }


        public string Mostrar()
        {

            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (Cliente persona in ClientesRegistrados)
                {
                    sb.AppendLine(persona.ToString());
                    
                }

                return sb.ToString();
            }
            catch(Exception e)
            {
                throw new Exception("No se pudo listar a los empleados, la lista es invalida o esta vacia");
            }

        }



        public static RegistroClientes operator +(RegistroClientes r, Cliente c)
        {
            
                if (c is not null)
                {
                    if (r.BuscarCliente(c) is null)
                    {
                        r.ClientesRegistrados.Add(c);
                    }
                    else
                    { 
                        throw new ValorInvalidoFueraDeRango("El cliente ya esta en la lista", new ArgumentOutOfRangeException());
                    }
                }
                else
                {
                    throw new ValorInvalidoFueraDeRango("El cliente recibido es null");
                }
            
            
            
            
          
            return r;
        }

        public static RegistroClientes operator -(RegistroClientes r, Cliente c)
        {

            if (c is not null)
            {
                if (r.BuscarCliente(c) is not null)
                {
                    r.ClientesRegistrados.Remove(c);
                }
                else
                {
                    throw new ValorInvalidoFueraDeRango("El cliente no esta en la lista", new ArgumentOutOfRangeException());
                }
            }
            else
            {
                throw new ArgumentNullException();
            }


            return r;
        }


        public static bool operator ==(RegistroClientes r, Butaca b)
        {
            
            foreach(Cliente item in r.ClientesRegistrados)
            {
                if(item==b)
                {
                    return true;
                }
            }


            return false;
        }


        public static bool operator !=(RegistroClientes r, Butaca b)
        {

            return !(r==b);
        }

        public Cliente BuscarCliente(Cliente c)
        {
            foreach (Cliente item in ClientesRegistrados)
            {
                if (item == c)
                {
                    return item;
                }
            }

            return null;
        }

        public Cliente EncontrarClientePorButaca(Butaca lugar)
        {

            foreach (Cliente cliente in this.ClientesRegistrados)
            {
                if (cliente == lugar)
                {
                    return cliente;
                }
            }

            return null;

        }

        public bool ExisteClientePorId(double idCliente)
        {

            foreach (Cliente cliente in this.ClientesRegistrados)
            {
                if (cliente.Id == idCliente )
                {
                    return true;
                }
            }

            return false;

        }


    }
}
