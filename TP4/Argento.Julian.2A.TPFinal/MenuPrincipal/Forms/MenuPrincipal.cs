using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Interfaz.Forms
{
    public partial class MenuPrincipal : Form
    {
        RegistroClientes clientes;
        ConexionBD conexionBD;
        bool rta;

        /// <summary>
        /// Inicializo la llamada a la base de datos y valido si se pudo lograr la conexion, informandolo
        /// </summary>
        public MenuPrincipal()
        {
            conexionBD = new ConexionBD();
            rta = conexionBD.ProbarConexion();
            InitializeComponent();
            clientes = new RegistroClientes();
        }

        /// <summary>
        /// Salgo de la aplicacion, guardando la lista de clientes modificada en el json 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Salir_Click(object sender, EventArgs e)
        {
            ClaseSerializadoraJson<List<Cliente>>.EscribirArchivo("lista", clientes.ClientesRegistrados);
            
            Close();
        }

        /// <summary>
        /// Llamo al form reservador de butacas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReservarButacas_Click(object sender, EventArgs e)
        {
            SalaDeCine asientos = new SalaDeCine(clientes);
            asientos.Show();
            
        }

        /// <summary>
        /// Cargo el archivo json de clientes al cargar el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                clientes.CargarArchivoClientes();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar el archivo de clientes");
                MessageBox.Show(ex.StackTrace);
            }
            
            if(rta)
            {
                MessageBox.Show("Se ha conectado a la base de datos");
            }
            else
            {
                MessageBox.Show("No se ha podido conectar a la base");
            }
            

        }

       /// <summary>
       /// LLamo al form que maneja consumiciones
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btn_Consumiciones_Click(object sender, EventArgs e)
        {
            try
            {
               

                
                TablaCompras Consumiciones = new TablaCompras(conexionBD, clientes);
                Consumiciones.ShowDialog();
                
                
                
                

            }
            catch(Exception)
            {
                MessageBox.Show("Se ha cancelado el proceso");
            }
        }



       


    }
}
