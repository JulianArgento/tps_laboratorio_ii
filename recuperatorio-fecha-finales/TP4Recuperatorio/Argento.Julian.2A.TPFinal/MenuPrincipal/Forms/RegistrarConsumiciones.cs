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
using Logica.Manejo_de_consumiciones;
using Logica.Evento;
using System.Threading;

namespace Interfaz.Forms
{
    public partial class RegistrarConsumiciones : Form
    {


        RegistroClientes lista;
        ETamanio tamanio;
        bool tipo;
        EMarca marca;
        Compra compra;
        EventoCambioColor cambioColor = new EventoCambioColor();
      
        public RegistrarConsumiciones( RegistroClientes clientes)
        {
            InitializeComponent();
            lista = clientes;
           
        }

        /// <summary>
        /// Valida que los campos hayan sido ingresados y llama a ComprarGaseosa o ComprarPochoclos o a ambos en caso de comprar gaseosas y pochoclos, segun el caso 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            if (cmb_Tamanio.SelectedIndex != -1 && num_CantidadAComprar.Value > 0)
            {

                MessageBox.Show("Elija el cliente al que se le cobrara.");
                TablaClientes tabla = new TablaClientes(lista);
                Cliente consumidor;
                tabla.ShowDialog();

                try
                {
                    if (tabla.ClienteSeleccionado is not null)
                    {
                        consumidor = tabla.ClienteSeleccionado;
                        compra = new Compra();
                        compra.CantidadComprada = (int)num_CantidadAComprar.Value;
                        compra.NombreCliente = consumidor.Nombre;
                    }
                    else
                    {
                        throw new ValorInvalidoFueraDeRangoException();
                    }


                    if (cbx_Pochoclos.Checked == true && cmb_Tipo.SelectedIndex != -1 && cbx_Gaseosa.Checked == true && cmb_Marca.SelectedIndex != -1 && compra != null)
                    {
                        ComprarPochoclos(consumidor);
                        ComprarGaseosa(consumidor);


                        Pochoclos cajaP = new Pochoclos(tamanio, tipo);
                        Gaseosa cajaG = new Gaseosa(tamanio, getMarca(cmb_Marca.SelectedItem.ToString()));


                        compra.PrecioCompra = cajaP.Precio * (double)num_CantidadAComprar.Value + cajaG.Precio * (double)num_CantidadAComprar.Value;
                        compra.ProductosComprados = cajaP.ToString() + "|" + cajaG.ToString();
                      
                        MessageBox.Show("Se ha registrado la compra");
                        Close();


                    }
                    else if (cbx_Pochoclos.Checked == true && cmb_Tipo.SelectedIndex != -1 && compra != null)
                    {



                        ComprarPochoclos(consumidor);

                        Pochoclos cajaP = new Pochoclos(tamanio, tipo);
                        compra.PrecioCompra = cajaP.Precio * (double)num_CantidadAComprar.Value;
                        compra.ProductosComprados = cajaP.ToString();
                        MessageBox.Show("Se ha registrado la compra");
                        Close();


                    }
                    else if (cbx_Gaseosa.Checked == true && cmb_Marca.SelectedIndex != -1 && compra != null)
                    {
                        ComprarGaseosa(consumidor);

                        Gaseosa cajaG = new Gaseosa(tamanio, getMarca(cmb_Marca.SelectedItem.ToString()));
                        compra.PrecioCompra = cajaG.Precio * (double)num_CantidadAComprar.Value;
                        compra.ProductosComprados = cajaG.ToString();

                        MessageBox.Show("Se ha registrado la compra");
                        Close();


                    }
                    else
                    {
                        MessageBox.Show("Se ha cancelado la compra, marque todos los campos necesarios");
                        this.cambioColor.cambiarColor += CambiarColor;
                        this.cambioColor.CambiarColor();

                    }


                }
                catch (ValorInvalidoFueraDeRangoException)
                {
                    MessageBox.Show("Debe elegir a un cliente si quiere continuar con la compra");
                }



            }
            else
            {
                MessageBox.Show("Se debe indicar el tamaño y la cantidad a comprar");
                this.cambioColor.cambiarColor += CambiarColor;
                this.cambioColor.CambiarColor();
            }
        }

        /// <summary>
        /// Maneja una compra de un producto pochoclos
        /// </summary>
        private void ComprarPochoclos(Cliente cliente)
        {


            if((tamanio==ETamanio.Chico|| tamanio == ETamanio.Mediano || tamanio == ETamanio.Grande) && (tipo == true || tipo == false))
            {

                    Pochoclos caja = new Pochoclos(tamanio, tipo);


                if (cliente is not null)
                {

                    cliente.Cuenta += (caja.Precio * (double)num_CantidadAComprar.Value);

                }
                else
                {
                    MessageBox.Show("No se ha elejido al cliente.");

                }

            }



        }
        
        /// <summary>
        /// Maneja una compra de un producto gaseosa
        /// </summary>
        private void ComprarGaseosa(Cliente cliente)
        {
            if ((tamanio == ETamanio.Chico || tamanio == ETamanio.Mediano || tamanio == ETamanio.Grande) && (marca == EMarca.CocaCola || marca == EMarca.Fanta || marca == EMarca.Sprite))
            {

                Gaseosa caja = new Gaseosa(tamanio, getMarca(cmb_Marca.SelectedItem.ToString()));


                if (cliente is not null)
                {

                    cliente.Cuenta += (caja.Precio * (double)num_CantidadAComprar.Value);
           
                   
                }
                else
                {
                    MessageBox.Show("No se ha elejido al cliente.");

                }


            }

        }


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }


        


        /// <summary>
        /// valida si se seleccionaron pochoclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_Pochoclos_CheckedChanged(object sender, EventArgs e)
        {

            cmb_Tamanio.Enabled = true;
            cmb_Tipo.Enabled = !cmb_Tipo.Enabled;
            

            if (!cbx_Pochoclos.Checked && !cbx_Gaseosa.Checked)
            {
                cmb_Tamanio.Enabled = false;
            }

        }

        private EMarca getMarca(string marca)
        {

            switch(marca)
            {
                case "CocaCola":
                   return EMarca.CocaCola;
                   

                case "Fanta":
                    return EMarca.Fanta;
                    
                case "Sprite":
                    return EMarca.Sprite;

                default:
                    return EMarca.Sprite;
                    
            }




        }



        /// <summary>
        /// valida si se seleccionaron gaseosas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_Gaseosa_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Tamanio.Enabled = true;
            
            cmb_Marca.Enabled = !cmb_Marca.Enabled;

            if(!cbx_Pochoclos.Checked&&!cbx_Gaseosa.Checked)
            {
                cmb_Tamanio.Enabled = false;
            }

            
        }



        

        /// <summary>
        /// asigna el tamanio elegido en el parametro tamanio para poder pasarlo a la compra 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Tamanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_Tamanio.SelectedItem.ToString())
            {
                case "Chico":
                    tamanio = ETamanio.Chico;
                    break;

                case "Mediano":
                    tamanio = ETamanio.Mediano;
                    break;

                case "Grande":
                    tamanio = ETamanio.Grande;
                    break;

            }

        }
        /// <summary>
        /// Recupera el parametro tipo elegido de los pochoclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Tipo.SelectedItem.ToString()=="Salado")
            {
                tipo = true;
            }
            else
            {
                tipo = false;
            }
        }
        /// <summary>
        /// Recupera la marca de gaseosa elegida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_Marca.SelectedItem.ToString())
            {
                case "CocaCola":
                    marca = EMarca.CocaCola;
                    break;

                case "Fanta":
                    marca = EMarca.Fanta;
                    break;

                case "Sprite":
                    marca = EMarca.Sprite;
                    break;

            }

        }

        /// <summary>
        /// Propiedad GET para recuperar la compra realizada para poder registrarla en la BDD
        /// </summary>
        public Compra GetConsumicion
        {
            get
            {

                return compra;
            }




        }
        /// <summary>
        /// Recupera la lista de clientes actualizada en caso de haber eliminado o agregado un cliente nuevo
        /// </summary>
        public RegistroClientes ListaActualizada
        {
            get
            {
                return lista;
            }
        }


        /// <summary>
        /// Cambia el backcolor de los campos requeridos a rojo
        /// </summary>
        public void CambiarColor()
        {
            
                if(cbx_Gaseosa.Checked && cbx_Pochoclos.Checked)
                {
                    this.cmb_Marca.BackColor = Color.Red;
                    
                    this.cmb_Tipo.BackColor = Color.Red;
                }
                else if(cbx_Gaseosa.Checked)
                {
                    this.cmb_Marca.BackColor = Color.Red;
                    
                }
                else if(cbx_Pochoclos.Checked)
                {
                    
                    this.cmb_Tipo.BackColor = Color.Red;
                }
                else
                {
                    this.cbx_Gaseosa.BackColor = Color.Red;
                    this.cbx_Pochoclos.BackColor = Color.Red;
                }

            if(cmb_Tamanio.SelectedIndex != -1)
            {
                this.cmb_Tamanio.BackColor = Color.Red;
            }


            if(num_CantidadAComprar.Value <= 0)
            {
                this.num_CantidadAComprar.BackColor = Color.Red;
            }
                




        }

    }
}
