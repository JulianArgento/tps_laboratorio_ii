using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();

        }

       

        /// <summary>
        /// Limpia el formulario al cargarlo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, System.EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// valida que los 2 numeros ingresados sean double, asigna los numeros a 2 nuevos objetos operando y realiza la operacion entre
        /// esos objetos, utilizando el operador ingresado
        /// </summary>
        /// <param name="numero1">primer operando</param>
        /// <param name="numero2">segundo operando</param>
        /// <param name="operador">operador de la cuenta</param>
        /// <returns>retorna el resultado de la cuenta en caso de ser numeros, retorna NaN en caso de que se hayan recibido letras</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            //Outs del parse
            double num1;
            double num2;

            if (Double.TryParse(numero1, out num1)&& Double.TryParse(numero2, out num2))
            {
                Operando operando1 = new Operando(numero1);

                Operando operando2 = new Operando(numero2);


                if(operador!="")
                {
                    return Calculadora.Operar(operando1, operando2, operador[0]);
                }
                else
                {
                    return Calculadora.Operar(operando1, operando2, char.MinValue);
                }

                
            }

            


            return double.NaN;
         
        }


        /// <summary>
        /// Limpia los campos de texto del form, a excepcion del historial
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";

            txtNumero2.Text = "";

            cmbOperador.SelectedItem = "";

            lblResultado.Text = "";
        }

        
        /// <summary>
        /// Al clickear en el boton de limpiar, llama al metodo limpiar para liberar los campos de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            Limpiar();


        }

        /// <summary>
        /// Al clickear en operar, lee los operandos y el operador, llamando al m etodo operar y retornando el valor de la operacion
        /// en el label resultado. Tambien, agrega la operacion a la lista de operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {

            char operador;

            if(cmbOperador.SelectedIndex==0)
            {
                operador = '+';
            }
            else
            {
                operador = cmbOperador.Text[0];
            }


            if (txtNumero1.Text!="" && txtNumero2.Text != "")
            {
                double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                string mensaje = resultado.ToString();

                //Mostrar el resultado
                lblResultado.Text = mensaje;

                //Añadir la operacion a la lista de operaciones
                lstOperaciones.Items.Add(txtNumero1.Text + " " + operador + " " + txtNumero2.Text + " = " + mensaje);
            }
                



               
            

               
            
                 

        }

        /// <summary>
        /// Cierra el form al clickear el boton Cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Llama al metodo DecimalBinario cuando se clickea en el boton de convertir a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

            Operando op = new Operando();
            string resultado = default;

            if (lblResultado.Text != "Valor invalido" && lblResultado.Text != "")
            {
                resultado = op.DecimalBinario(Double.Parse(lblResultado.Text));

                if(resultado != "Valor invalido")
                {
                    lblResultado.Text = resultado;
                }
                else
                {
                    MessageBox.Show("El resultado ya es binario");
                }

            }
        }



        /// <summary>
        /// Llama al metodo BinarioDecimal cuando se clickea en el boton de convertir a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando op = new Operando();
            string resultado = default;

            if (lblResultado.Text != "Valor invalido" && lblResultado.Text != "")
            {
                resultado = op.BinarioDecimal(lblResultado.Text);


                if (resultado != "Valor invalido")
                {
                    lblResultado.Text = resultado;
                }
                else
                {
                    MessageBox.Show("El resultado ya es decimal");
                }
            }
        }



        /// <summary>
        /// Muestra al usuario una ventana de confirmacion de salida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Seguro que quiere cerrar el formulario?", "EXIT", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }


        }

        
    }
}
