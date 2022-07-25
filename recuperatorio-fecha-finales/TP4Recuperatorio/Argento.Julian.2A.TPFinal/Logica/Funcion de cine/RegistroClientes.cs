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

        /// <summary>
        /// Carga la lista de clientes leyendo el json que los contiene
        /// </summary>
        public void CargarArchivoClientes()
        {

                ClientesRegistrados = ClaseSerializadoraJson<List<Cliente>>.LeerArchivo("lista");


        }

        /// <summary>
        /// Devuelve un string mostrando los clientes de la lista
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {

            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (Cliente persona in ClientesRegistrados)
                {
                    sb.AppendLine(persona.Mostrar());
                    
                }

                return sb.ToString();
            }
            catch(Exception e)
            {
                throw new Exception("No se pudo listar a los empleados, la lista es invalida o esta vacia");
            }

        }


        /// <summary>
        /// Suma un cliente a la lista del registro
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
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
                        throw new ValorInvalidoFueraDeRangoException("El cliente ya esta en la lista", new ArgumentOutOfRangeException());
                    }
                }
                else
                {
                    throw new ValorInvalidoFueraDeRangoException("El cliente recibido es null");
                }
            
            
            
            
          
            return r;
        }

        /// <summary>
        /// Borra a un cliente de la lista si este se encuentra en ella
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
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
                    throw new ValorInvalidoFueraDeRangoException("El cliente no esta en la lista", new ArgumentOutOfRangeException());
                }
            }
            else
            {
                throw new ArgumentNullException();
            }


            return r;
        }

        /// <summary>
        /// Valida si una butaca ya fue reservada
        /// </summary>
        /// <param name="r"></param>
        /// <param name="b"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Se busca a el cliente resibido por parametro en la lista del registro, se retorna al cliente si esta en la lista, caso contrario se retorna null
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Encuentra al cliente que tiene asignada la butaca elegida
        /// </summary>
        /// <param name="lugar"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Encuentra al primer cliente que tenga el nombre recibido por parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Cliente EncontrarClientePorNombre(string nombre)
        {

            foreach (Cliente cliente in this.ClientesRegistrados)
            {
                if (cliente.Nombre == nombre)
                {
                    return cliente;
                }
            }

            return null;

        }

        /// <summary>
        /// Valida si hay un cliente con el id ingresado por parametro en la lista
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
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
