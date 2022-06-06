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
    public partial class SalaDeCine : Form
    {

        
        Dictionary<string,Button> botones;
        List<Butaca> butacas;
        RegistroClientes clientesRegistrados;

        public SalaDeCine(RegistroClientes clientes)
        {
            InitializeComponent();
            botones = new Dictionary<string,Button>();
            CargarBotones();
            clientesRegistrados = clientes;
            
        }

        /// <summary>
        /// Asocio acada boton a el diccionario de botones
        /// </summary>
        private void CargarBotones()
        {
            botones.Add("1H",this.btn_Butaca1H);
            botones.Add("2H", this.btn_Butaca2H);
            botones.Add("3H", this.btn_Butaca3H);
            botones.Add("4H", this.btn_Butaca4H);
            botones.Add("5H", this.btn_Butaca5H);
            botones.Add("6H", this.btn_Butaca6H);
            botones.Add("7H", this.btn_Butaca7H);
            botones.Add("8H", this.btn_Butaca8H);
            botones.Add("1G", this.btn_Butaca1G);
            botones.Add("2G", this.btn_Butaca2G);
            botones.Add("3G", this.btn_Butaca3G);
            botones.Add("4G", this.btn_Butaca4G);
            botones.Add("5G", this.btn_Butaca5G);
            botones.Add("6G", this.btn_Butaca6G);
            botones.Add("7G", this.btn_Butaca7G);
            botones.Add("8G", this.btn_Butaca8G);
            botones.Add("1F", this.btn_Butaca1F);
            botones.Add("2F", this.btn_Butaca2F);
            botones.Add("3F", this.btn_Butaca3F);
            botones.Add("4F", this.btn_Butaca4F);
            botones.Add("5F", this.btn_Butaca5F);
            botones.Add("6F", this.btn_Butaca6F);
            botones.Add("7F", this.btn_Butaca7F);
            botones.Add("8F", this.btn_Butaca8F);
        }

        /// <summary>
        /// Cargo las butacas , vinculandolas con los botones
        /// </summary>
        private void CargarButacas()
        {
            butacas = new List<Butaca>();

            foreach (KeyValuePair<string, Button> item in botones)
            {

                Butaca asiento = new Butaca(item.Key, false);


                if(clientesRegistrados != asiento)
                {
                    asiento = new Butaca(item.Key, true);
                    
                }


                butacas.Add(asiento);


            }
        }

        private void Butacas_Load(object sender, EventArgs e)
        {
            
            CargarButacas();
            DisponibilidadButacas();
            
        }

        /// <summary>
        /// Cambio el color de la butaca dependiendo de su disponibilidad
        /// </summary>
        private void DisponibilidadButacas()
        {
           


            foreach(Butaca butaca in butacas)
            {


                if(clientesRegistrados == butaca)
                {
                    botones[butaca.Lugar].BackColor = Color.LightSalmon;
                }
                else
                {
                    botones[butaca.Lugar].BackColor = Color.LightGreen;
                }


            }
        }

        /// <summary>
        /// Detecto que butaca fue clickeada y se la mando por parametro a InformarButaca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_butaca_Click(object sender, EventArgs e)
        {
            Button auxBoton = (Button)sender;


            foreach(KeyValuePair<string,Button> item in botones)
            {
                if(item.Value == auxBoton)
                {

                    InformarButaca(item.Key);
                    break;
                }

            }


        }

        /// <summary>
        /// Si la butaca esta libre la ofrezco para reservar, sino muestro el cliente que la reservo
        /// </summary>
        /// <param name="key"></param>
        private void InformarButaca(string key)
        {

            foreach(Butaca asiento in butacas)
            {
                if(key==asiento.Lugar)
                { 

                    if(asiento.Disponibilidad==true)
                    {

                        ReservarButaca(asiento);
                        DisponibilidadButacas();
                        break;

                    }
                    else
                    {

                        Cliente reservador = clientesRegistrados.EncontrarClientePorButaca(asiento);
                        
                        MostrarDatosCliente fm = new MostrarDatosCliente(reservador);
                        fm.Show();
                        break;


                    }

                    

                }
            }


        }

        /// <summary>
        /// Reservo la butaca al cliente elegido en la Tabla de clientes
        /// </summary>
        /// <param name="asiento"></param>
        public void ReservarButaca(Butaca asiento)
        {

            
            DialogResult mensaje = MessageBox.Show($"La butaca {asiento.Mostrar()} esta disponible, quieres reservarla?", "Reservacion", MessageBoxButtons.YesNo);
            

            if (mensaje == DialogResult.Yes)
            {
                try
                {
                    

                    TablaClientes fm = new TablaClientes(clientesRegistrados);

                    DialogResult res=fm.ShowDialog();

                    if (fm.ClienteSeleccionado is not null)
                    {
                        Cliente reservador = clientesRegistrados.BuscarCliente(fm.ClienteSeleccionado);
                        asiento.Disponibilidad = false;
                        reservador += asiento;
                        reservador.Cuenta += 500;
                    }
                    else
                    {
                        throw new ValorInvalidoFueraDeRango("Se ha cancelado la reserva.");
                    }


                }
                catch(ValorInvalidoFueraDeRango ex)
                {
                    MessageBox.Show(ex.Message );

                   
                }
                catch(Exception)
                {
                    MessageBox.Show($"Hubo un error en la reserva");
                }
            }
           

        }







        private void Salir(object sender, EventArgs e)
        {

            Close();
        }
    }
}
