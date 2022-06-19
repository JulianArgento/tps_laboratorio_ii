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
using Logica.Manejo_de_consumiciones;

namespace Interfaz.Forms
{
    

    public partial class TablaCompras : Form
    {
        ConexionBD conexion;
        List<Compra> listaCompras;
        RegistroClientes lista;
        bool nocturno = false;


        public TablaCompras(ConexionBD baseDeDatos, RegistroClientes lista)
        {
            InitializeComponent();
            conexion = baseDeDatos;
            this.lista = lista;
        }

        private void ListaCompras_Load(object sender, EventArgs e)
        {
            ActualizacionDeDatos();
            this.btn_ModoNocturno.Click += new EventHandler(CambioTema);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Se borra la compra seleccionada del lsb y de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"Desea eliminar esta compra del registro??", "Confirmacion", MessageBoxButtons.YesNo);

            try
            {
                if (respuesta == DialogResult.Yes)
                {

                    

                    Cliente comprador = lista.EncontrarClientePorNombre(listaCompras[lsb_Compras.SelectedIndex].NombreCliente);


                    comprador.Cuenta -= listaCompras[lsb_Compras.SelectedIndex].PrecioCompra;

                    conexion.EliminarCompra(listaCompras[lsb_Compras.SelectedIndex].Id);
                    lsb_Compras.Items.RemoveAt(lsb_Compras.SelectedIndex);
                    MessageBox.Show("Compra eliminada");
                }
                else
                {
                    MessageBox.Show("No se elimino la compra");
                }

            }
            catch (ValorInvalidoFueraDeRangoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Valida que haya sido clickeada una compra para poder modificarla o borrarla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsb_Compras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsb_Compras.SelectedIndex != -1)
            {
                btn_Borrar.Enabled = true;
                btn_Modificar.Enabled = true;
            }
            else
            {
                btn_Borrar.Enabled = false;
                btn_Modificar.Enabled = false;
            }

        }

        /// <summary>
        /// Permite modificar la compra seleccionada, abriendo un nuevo form de RegistrarConsumiciones para poder darle los nuevos datos de la compra, modificando los datos en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"Desea modificar esta compra??", "Confirmacion", MessageBoxButtons.YesNo);

            try
            {
                if(respuesta == DialogResult.Yes)
                {

                    MessageBox.Show($"Ingrese los nuevos datos de la compra");


                    Compra compraModificar = listaCompras[lsb_Compras.SelectedIndex];
                    Cliente clienteAnterior = lista.EncontrarClientePorNombre(compraModificar.NombreCliente);
                    clienteAnterior.Cuenta -= compraModificar.PrecioCompra;
                    RegistrarConsumiciones consumicion = new RegistrarConsumiciones(lista);
                    consumicion.ShowDialog();
                    Compra comp = consumicion.GetConsumicion;
                    lista = consumicion.ListaActualizada;

                    comp.Id = compraModificar.Id;

                    if (comp is not null)
                    {
                        conexion.ModificarDato(comp);

                        ActualizacionDeDatos();


                    }
                    else
                    {
                        MessageBox.Show("Se cancelo la modificacion de la compra");
                    }
                }
                else
                {
                    MessageBox.Show("Se cancelo la modificacion de la compra");
                }

                
            }
            catch (ValorInvalidoFueraDeRangoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Agrega una compra a la lsb y a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            

            RegistrarConsumiciones consumicion = new RegistrarConsumiciones(lista);
            consumicion.ShowDialog();
            Compra comp = consumicion.GetConsumicion;
            lista = consumicion.ListaActualizada;
            if (comp is not null)
            {
                conexion.AgregarCompra(comp);

                ActualizacionDeDatos();

            }       
            else
            {
                MessageBox.Show("Se cancelo la compra");
            }
    
        }

        /// <summary>
        /// Recupera de manera asincrona la lista de compras de la base de datos, mostrando un "Cargando...." mientras no se recupoeren los datos y deshabilitando la capacidad de agregar mientras carga la lista
        /// </summary>
        private async void ActualizacionDeDatos()
        {
            btn_Agregar.Enabled = false;
            lsb_Compras.Items.Add("Cargando.....");
            listaCompras = await conexion.ObtenerListaCompras();
            btn_Agregar.Enabled = true;
            lsb_Compras.Items.Clear();
            foreach (Compra compra in listaCompras)
            {
      
                lsb_Compras.Items.Add(compra.Mostrar());
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
                lsb_Compras.BackColor = Color.DarkBlue;
                lsb_Compras.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.LightSalmon;
                lsb_Compras.BackColor = Color.White;
                lsb_Compras.ForeColor = Color.Black;
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

     

     
    }
}
