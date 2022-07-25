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
    public delegate int DelegadoOrdenar(Cliente cliente1, Cliente ciente2);

    public partial class TablaClientes : Form
    {
        RegistroClientes listaClientes;
        Cliente clienteSeleccionado;
        bool nocturno = false;

        /// <summary>
        /// Delegado que contiene el metodo para ordenar alfabeticamente la lista 
        /// </summary>
        DelegadoOrdenar ordenamiento = new DelegadoOrdenar(OrdenarAlfabeticamente);

        /// <summary>
        /// Delegado que contiene el metodo para ordenar por ID la lista
        /// </summary>
        DelegadoOrdenar ordenamiento2 = new DelegadoOrdenar(OrdenarPorId);

        
       

       
        public TablaClientes(RegistroClientes clientes)
        {
            InitializeComponent();
            listaClientes = clientes;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

            Close();
        }
        /// <summary>
        /// Se carga la lista de clientes y se le asigna al boton cambiar estilo el evento CambioTema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TablaClientes_Load(object sender, EventArgs e)
        {

            CargarLista();

            this.btn_CambiarEstilo.Click += new EventHandler(CambioTema);


        }

        /// <summary>
        /// Carga el lsb con la lista de clientes
        /// </summary>
        public void CargarLista()
        {
            foreach (Cliente cliente in listaClientes.ClientesRegistrados)
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
            catch (ValorInvalidoFueraDeRangoException ex)
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
                ArchivosTxt<string>.Escribir(listaClientes.Mostrar(), "Ficha de los clientes");
                MessageBox.Show("Se imprimieron los datos de los clientes");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron imprimir los datos del usuario");
            }

        }
        /// <summary>
        /// Evento propio que se encarga de cambiar el estilo del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CambioTema(object sender, EventArgs e)
        {
            nocturno = !nocturno;

            if (nocturno)
            {
                this.BackColor = Color.Purple;
                lsb_Clientes.BackColor = Color.DarkBlue;
                lsb_Clientes.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.LightSalmon;
                lsb_Clientes.BackColor = Color.White;
                lsb_Clientes.ForeColor = Color.Black;
            }



            foreach (Control item in this.Controls)
            {


                if (nocturno)
                {
                    if (item is Button)
                    {
                        item.BackColor = Color.Indigo;
                        item.ForeColor = Color.LightGray;
                    }
                    else if (item is Label)
                    {
                        item.ForeColor = Color.LightGray;
                    }
                }
                else
                {
                    if (item is Button)
                    {
                        item.BackColor = Color.LavenderBlush;
                        item.ForeColor = Color.Black;
                    }
                    else if (item is Label)
                    {
                        item.ForeColor = Color.Black;
                    }
                }


            }


        }
        /// <summary>
        /// valida que haya sido clickeado un cliente para permitir eliminar o seleccionar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsb_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsb_Clientes.SelectedIndex != -1)
            {
                btn_Seleccionar.Enabled = true;
                btn_Eliminar.Enabled = true;
            }
            else
            {
                btn_Seleccionar.Enabled = false;
                btn_Eliminar.Enabled = false;
            }

        }

        /// <summary>
        /// Metodo de ordenamiento que valida si un nombre va antes alfabeticamente que otro
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static int OrdenarAlfabeticamente(Cliente cliente1, Cliente cliente2)
        {
            return string.Compare(cliente1.Nombre, cliente2.Nombre);
        }

        /// <summary>
        /// Metodo que llama al metodo de extension CompararNumeros para poder comparar los ids y ordenarlos de mayor a menor
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static int OrdenarPorId(Cliente cliente1, Cliente cliente2)
        {

            return cliente1.Id.CompararNumeros(cliente2.Id);
            
        }

        /// <summary>
        /// Se llama mediante una funcion flecha al delegado encargado del ordenamiento de nombres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OrdenarNombre_Click(object sender, EventArgs e)
        {
            listaClientes.ClientesRegistrados.Sort((x, y) => ordenamiento(x, y));
            lsb_Clientes.Items.Clear();
            btn_Seleccionar.Enabled = false;
            btn_Eliminar.Enabled = false;
            CargarLista();
        }

        /// <summary>
        /// Se llama mediante una funcion flecha al delegado encargado del ordenamiento de Ids
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OrdenarId_Click(object sender, EventArgs e)
        {
            listaClientes.ClientesRegistrados.Sort((x, y) => ordenamiento2(x, y));
            lsb_Clientes.Items.Clear();
            btn_Seleccionar.Enabled = false;
            btn_Eliminar.Enabled = false;
            CargarLista();
        }
    }
}
