
namespace Interfaz.Forms
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_reservarButacas = new System.Windows.Forms.Button();
            this.btn_Consumiciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Titulo.Location = new System.Drawing.Point(292, 22);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(252, 55);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Cines UTN";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(12, 387);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(180, 51);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btn_reservarButacas
            // 
            this.btn_reservarButacas.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_reservarButacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservarButacas.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reservarButacas.Location = new System.Drawing.Point(306, 147);
            this.btn_reservarButacas.Name = "btn_reservarButacas";
            this.btn_reservarButacas.Size = new System.Drawing.Size(225, 76);
            this.btn_reservarButacas.TabIndex = 2;
            this.btn_reservarButacas.Text = "Reservar butacas";
            this.btn_reservarButacas.UseVisualStyleBackColor = false;
            this.btn_reservarButacas.Click += new System.EventHandler(this.ReservarButacas_Click);
            // 
            // btn_Consumiciones
            // 
            this.btn_Consumiciones.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Consumiciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consumiciones.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Consumiciones.Location = new System.Drawing.Point(306, 261);
            this.btn_Consumiciones.Name = "btn_Consumiciones";
            this.btn_Consumiciones.Size = new System.Drawing.Size(225, 79);
            this.btn_Consumiciones.TabIndex = 3;
            this.btn_Consumiciones.Text = "Agregar consumiciones";
            this.btn_Consumiciones.UseVisualStyleBackColor = false;
            this.btn_Consumiciones.Click += new System.EventHandler(this.btn_Consumiciones_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interfaz.Properties.Resources.foto__1___1_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Consumiciones);
            this.Controls.Add(this.btn_reservarButacas);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_reservarButacas;
        private System.Windows.Forms.Button btn_Consumiciones;
    }
}

