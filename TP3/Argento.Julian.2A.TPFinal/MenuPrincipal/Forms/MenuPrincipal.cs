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
        

        public MenuPrincipal()
        {

            InitializeComponent();
            clientes = new RegistroClientes();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            ClaseSerializadoraJson<List<Cliente>>.EscribirArchivo("lista", clientes.ClientesRegistrados);
            
            Close();
        }

        private void ReservarButacas_Click(object sender, EventArgs e)
        {
            SalaDeCine asientos = new SalaDeCine(clientes);
            asientos.Show();
            
        }

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
            

            

        }

       
        private void btn_Consumiciones_Click(object sender, EventArgs e)
        {
            try
            {
               

                
                RegistrarConsumiciones registroConsumiciones = new RegistrarConsumiciones(clientes);
                registroConsumiciones.Show();
                
                
                
                

            }
            catch(Exception)
            {
                MessageBox.Show("Se ha cancelado el proceso");
            }
        }



       


    }
}
