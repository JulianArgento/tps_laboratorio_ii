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
    public partial class TablaClientes : Form
    {
        RegistroClientes listaClientes;
        Cliente clienteSeleccionado;


        public TablaClientes(RegistroClientes clientes)
        {
            InitializeComponent();
            listaClientes = clientes;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void TablaClientes_Load(object sender, EventArgs e)
        {

            foreach(Cliente cliente in listaClientes.ClientesRegistrados)
            {
                lsb_Clientes.Items.Add(cliente.Mostrar());
            }



        }
        /// <summary>
        /// Agrego un cliente a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente reservador;

                PedirDatosCliente fm = new PedirDatosCliente(listaClientes);

                DialogResult res = fm.ShowDialog();

                reservador = fm.Reservado;


                if (reservador is not null)
                {
                    listaClientes += reservador;
                    lsb_Clientes.Items.Add(reservador.Mostrar());
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No se ha agregado al cliente");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al agregar al cliente");
            }

        }

        /// <summary>
        /// Elimino un cliente de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"Desea eliminar a este cliente?", "Confirmacion", MessageBoxButtons.YesNo);

            try
            {
                if (respuesta == DialogResult.Yes)
                {
                    listaClientes -= listaClientes.ClientesRegistrados[lsb_Clientes.SelectedIndex];
                    lsb_Clientes.Items.RemoveAt(lsb_Clientes.SelectedIndex);
                    MessageBox.Show("Cliente eliminado");
                }
                else
                {
                    MessageBox.Show("No se elimino al cliente");
                }

            }
            catch(ValorInvalidoFueraDeRango ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        

        /// <summary>
        /// Propiedad para retornar el cliente seleccionado
        /// </summary>
        public Cliente ClienteSeleccionado
        {
            get
            {
                return clienteSeleccionado;
            }
        }





        /// <summary>
        /// Selecciono un cliente para retornarselo al form llamador con la propiedad ClienteSeleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = listaClientes.ClientesRegistrados[lsb_Clientes.SelectedIndex];
            DialogResult = DialogResult.OK;
            Close();
        }


        /// <summary>
        /// Imprimo la ficha de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ficha_Click(object sender, EventArgs e)
        {
            try
            {
                ArchivosTxt<string>.Escribir(listaClientes.Mostrar(),"Ficha de los clientes");
                MessageBox.Show("Se imprimieron los datos de los clientes");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron imprimir los datos del usuario");
            }




        }

        private void lsb_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsb_Clientes.SelectedIndex!=-1)
            {
                btn_Seleccionar.Enabled = true;
                btn_Eliminar.Enabled = true;
            }
            
        }
    }
}
