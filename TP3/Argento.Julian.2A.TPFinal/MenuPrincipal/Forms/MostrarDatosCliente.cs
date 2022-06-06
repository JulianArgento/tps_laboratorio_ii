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
    public partial class MostrarDatosCliente : Form
    {

        Cliente auxcliente = new Cliente();

        public MostrarDatosCliente(Cliente datos)
        {
            InitializeComponent();
            auxcliente = datos;
        }

        private void MostrarDatosCliente_Load(object sender, EventArgs e)
        {
            lbl_Nombre.Text = auxcliente.Nombre;
            lbl_Id.Text = auxcliente.Id.ToString();
            lbl_Gastos.Text += auxcliente.Cuenta.ToString();
            lbl_Butaca.Text = auxcliente.ListarButacasReservadas();

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ImprimirTicket_Click(object sender, EventArgs e)
        {
            try
            {
                ArchivosTxt<string>.Escribir(auxcliente.Mostrar(),$"Ficha del cliente {auxcliente.Nombre}");
                MessageBox.Show("Se imprimieron los datos del usuario");

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudieron imprimir los datos del usuario");
            }
            

        }
    }
}

