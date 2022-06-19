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
using Logica.Excepciones;

namespace Interfaz.Forms
{
    public partial class PedirDatosCliente : Form
    {
       
        
        Cliente reservador;
        RegistroClientes clientes;

       
        public PedirDatosCliente(RegistroClientes clientesRegistrados)
        {
            InitializeComponent();
            clientes = clientesRegistrados;

        }

        

        
        /// <summary>
        /// Se crea al cliente con los campos especificados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text;
            string id = txt_Id.Text;
            int idConvertido;

            bool resultado = int.TryParse(id, out idConvertido);

            try 
            {


                if(resultado&&nombre.NombreEsValido())
                {
                   
                    if(!clientes.ExisteClientePorId(double.Parse(id)))
                    {
                        reservador = new Cliente(nombre, double.Parse(id));
                    }
                    else
                    {
                        throw new IdExistenteException("El ID ingresado ya esta asociado a un usuario de la lista.");

                    }
                  

                }
                else
                {
                    throw new Exception();
                }
                this.DialogResult = DialogResult.OK;
                Close();

            }
            catch (IdExistenteException ex)
            {
                MessageBox.Show($"No se ha podido crear el cliente, ingrese campos validos.");
                MessageBox.Show(ex.Message);

            }
            catch (Exception)
            {
                MessageBox.Show($"No se ha podido crear el cliente, ingrese campos validos.");

                
            }

        }

        /// <summary>
        /// Propiedad para conseguir al cliente nuevo desde otro form
        /// </summary>
        public Cliente Reservado
        {
            get { return reservador; }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

       

        
    }
}
