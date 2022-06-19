using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Manejo_de_consumiciones 
{
    public class Compra : IFuncionalidades
    {
        int id;
        string nombreCliente;
        double precioCompra;
        string productosComprados;
        int cantidadComprada;

        public Compra(string nombreComprador, double precioCompra, string productosComprados, int cantidadComprada)
        {
           
            this.NombreCliente = nombreComprador;
            this.PrecioCompra = precioCompra;
            this.ProductosComprados = productosComprados;
            this.CantidadComprada = cantidadComprada;
        }

        public Compra() : this("",0,"",0)
        {

        }


        /// <summary>
        /// Gets y sets de los atributos
        /// </summary>
        public int Id { get => id; set => id = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public double PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public string ProductosComprados { get => productosComprados; set => productosComprados = value; }
        public int CantidadComprada { get => cantidadComprada; set => cantidadComprada = value; }


        /// <summary>
        /// Se retorna un string con los datos de la compra
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            return $"Id: {Id} || Comprador: {NombreCliente}|| Precio: {PrecioCompra}|| Productos comprados: {ProductosComprados}|| Cantidad comprada: {cantidadComprada}";
        }
    }
}
