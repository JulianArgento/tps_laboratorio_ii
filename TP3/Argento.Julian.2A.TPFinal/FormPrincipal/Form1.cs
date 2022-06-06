using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LogUsuario_Click(object sender, EventArgs e)
        {

           
            
            txt_nombre.Text = "Juancito";
            txt_password.Text = "447890";


        }

        private void LogAdmin_Click(object sender, EventArgs e)
        {

            

            txt_nombre.Text = "Fernando";
            txt_password.Text = "2229018734";
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
