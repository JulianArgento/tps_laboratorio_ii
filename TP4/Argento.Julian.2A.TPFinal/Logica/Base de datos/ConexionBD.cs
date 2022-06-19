using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logica.Manejo_de_consumiciones;
using System.Threading;

namespace Logica
{
    public class ConexionBD
    {

        #region Atributos

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        #endregion

        #region Constructores

        static ConexionBD()
        {
            ConexionBD.cadena_conexion = @"Server=.;Database=TP4_DB;Trusted_Connection=True;";
        }

        public ConexionBD()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(ConexionBD.cadena_conexion);
        }

        #endregion
    
        #region Métodos

        #region Probar conexión
        /// <summary>
        /// Pruebo que funcione la conexion a la base de datos, si no funciona retorno false, si funciona true
        /// </summary>
        /// <returns></returns>
        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Select

        /// <summary>
        /// Obtengo la lista de compras de la bdd, asincrona para poder utilizar el form mientras se carga la lista
        /// </summary>
        /// <returns></returns>
        public async Task<List<Compra>> ObtenerListaCompras()
        {
            List<Compra> lista = new List<Compra>();


            try
            {

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Tabla_Compras";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();



                lista = await Task.Run(() =>
                {

                    //Sleep utilizado para simular una gran cantidad de datos
                    //para cargar: Thread.Sleep(3000);

                    while (lector.Read())
                    {
                        Compra item = new Compra();

                      
                        item.Id = (int)lector["ID_COMPRA"];
                        item.NombreCliente = lector[1].ToString().Trim();
                        item.PrecioCompra = double.Parse(lector[2].ToString().Trim());
                        item.ProductosComprados = lector[3].ToString().Trim();
                        item.CantidadComprada = (int)lector[4];

                        lista.Add(item);
                    }

                    lector.Close();


                    return lista;
                });  
                

            }
            catch (Exception)
            {
                throw new ValorInvalidoFueraDeRangoException("Hubo un error al cargar la lista");
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }

        #endregion

        #region Insert
        /// <summary>
        /// Agrego una compra a la base de datos
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public bool AgregarCompra(Compra param)
        {
            bool rta = true;

            try
            {
                conexion.Open();
                this.comando.CommandText = $"Insert into Tabla_Compras (NOMBRE_CLIENTE,PRECIO_COMPRA,PRODUCTOS_COMPRADOS,CANTIDAD_COMPRADA) values (@NOMBRE_CLIENTE,@PRECIO_COMPRA,@PRODUCTOS_COMPRADOS,@CANTIDAD_COMPRADA)";
                
                this.comando.Parameters.AddWithValue("@NOMBRE_CLIENTE", param.NombreCliente);
                this.comando.Parameters.AddWithValue("@PRECIO_COMPRA", param.PrecioCompra);
                this.comando.Parameters.AddWithValue("@PRODUCTOS_COMPRADOS", param.ProductosComprados);
                this.comando.Parameters.AddWithValue("@CANTIDAD_COMPRADA", param.CantidadComprada);

               

                

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                rta = false;
                throw new ValorInvalidoFueraDeRangoException(e.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Update
        /// <summary>
        /// Modifico un dato existente en la base de datos
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public bool ModificarDato(Compra param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@ID_COMPRA", param.Id);
                this.comando.Parameters.AddWithValue("@NOMBRE_CLIENTE", param.NombreCliente);
                this.comando.Parameters.AddWithValue("@PRECIO_COMPRA", param.PrecioCompra);
                this.comando.Parameters.AddWithValue("@PRODUCTOS_COMPRADOS", param.ProductosComprados);
                this.comando.Parameters.AddWithValue("@CANTIDAD_COMPRADA", param.CantidadComprada);


                string sql = "UPDATE Tabla_Compras ";
                sql += "SET NOMBRE_CLIENTE = @NOMBRE_CLIENTE, PRECIO_COMPRA = @PRECIO_COMPRA, CANTIDAD_COMPRADA = @CANTIDAD_COMPRADA ";
                sql += "WHERE ID_COMPRA = @ID_COMPRA";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {

                rta = false;
         
                throw new ValorInvalidoFueraDeRangoException(e.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Delete
        /// <summary>
        /// Elimino una compra de la base de datos, la cual pertenezca al id ingresado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool EliminarCompra(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM Tabla_Compras ";
                sql += "WHERE ID_COMPRA = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;

                throw new ValorInvalidoFueraDeRangoException("Hubo un error al eliminar el dato");
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #endregion
        
    }
}
