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
    public partial class RegistrarConsumiciones : Form
    {


        RegistroClientes lista;
        
       
        ETamanio tamanio;
        bool tipo;
        EMarca marca;

        public RegistrarConsumiciones( RegistroClientes clientes)
        {
            InitializeComponent();
            lista = clientes;
           
        }

        private void RegistrarConsumiciones_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            if(cmb_Tamanio.SelectedIndex!=-1&&num_CantidadAComprar.Value>0)
            {
                if (cbx_Pochoclos.Checked == true && cmb_Tipo.SelectedIndex!=-1)
                {
                    ComprarPochoclos();
                }
                else if (cbx_Gaseosa.Checked == true&&cmb_Marca.SelectedIndex!=-1)
                {
                    ComprarGaseosa();
                }
                else
                {
                    MessageBox.Show("Marque el producto para comprar y sus caracteristicas");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el tamaño y la cantidad a comprar");
            }





        }

        private void ComprarPochoclos()
        {


            if((tamanio==ETamanio.Chico|| tamanio == ETamanio.Mediano || tamanio == ETamanio.Grande) && (tipo == true || tipo == false))
            {

                    Pochoclos caja = new Pochoclos(tamanio, tipo);

                
                
                    MessageBox.Show("Elija el cliente al que se le cobrara.");
                    TablaClientes tabla = new TablaClientes(lista);

                    tabla.ShowDialog();

                    Cliente consumidor = tabla.ClienteSeleccionado;

                    if(consumidor is not null)
                    {
     
                        consumidor.Cuenta += (caja.Precio * (double)num_CantidadAComprar.Value);
                        MessageBox.Show("Se le ha cobrado al cliente y se ha registrado en un .txt el valor de la compra.");
                        ArchivosTxt<double>.Escribir((caja.Precio * (double)num_CantidadAComprar.Value), "Ultima Compra");
                    }
                    else
                    {
                        MessageBox.Show("No se ha elejido al cliente.");

                    }


                


            }



        }
        
        private void ComprarGaseosa()
        {
            if ((tamanio == ETamanio.Chico || tamanio == ETamanio.Mediano || tamanio == ETamanio.Grande) && (marca == EMarca.CocaCola || marca == EMarca.Fanta || marca == EMarca.Sprite))
            {

                Gaseosa caja = new Gaseosa(tamanio, marca);



                MessageBox.Show("Elija el cliente al que se le cobrara.");
                TablaClientes tabla = new TablaClientes(lista);

                tabla.ShowDialog();

                Cliente consumidor = tabla.ClienteSeleccionado;

                if (consumidor is not null)
                {

                    consumidor.Cuenta += (caja.Precio * (double)num_CantidadAComprar.Value);
                    MessageBox.Show("Se le ha cobrado al cliente y se han borrado los productos.");
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


        



        private void cbx_Pochoclos_CheckedChanged(object sender, EventArgs e)
        {

            cmb_Tamanio.Enabled = true;
            cmb_Tipo.Enabled = true;
            cmb_Marca.Enabled = false;


            cbx_Gaseosa.Enabled = !cbx_Gaseosa.Enabled;
        }

        private void cbx_Gaseosa_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Tamanio.Enabled = true;
            cmb_Tipo.Enabled = false;
            cmb_Marca.Enabled = true;

            cbx_Pochoclos.Enabled = !cbx_Pochoclos.Enabled;
        }



        

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

        
    }
}
