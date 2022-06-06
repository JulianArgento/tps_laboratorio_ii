
namespace Interfaz.Forms
{
    partial class MostrarDatosCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Dato1 = new System.Windows.Forms.Label();
            this.lbl_Dato2 = new System.Windows.Forms.Label();
            this.lbl_Dato3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Gastos = new System.Windows.Forms.Label();
            this.lbl_Dato4 = new System.Windows.Forms.Label();
            this.lbl_Butaca = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ImprimirTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Dato1
            // 
            this.lbl_Dato1.AutoSize = true;
            this.lbl_Dato1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Dato1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dato1.Location = new System.Drawing.Point(12, 58);
            this.lbl_Dato1.Name = "lbl_Dato1";
            this.lbl_Dato1.Size = new System.Drawing.Size(89, 23);
            this.lbl_Dato1.TabIndex = 0;
            this.lbl_Dato1.Text = "Nombre: ";
            // 
            // lbl_Dato2
            // 
            this.lbl_Dato2.AutoSize = true;
            this.lbl_Dato2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Dato2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dato2.Location = new System.Drawing.Point(12, 113);
            this.lbl_Dato2.Name = "lbl_Dato2";
            this.lbl_Dato2.Size = new System.Drawing.Size(32, 23);
            this.lbl_Dato2.TabIndex = 1;
            this.lbl_Dato2.Text = "Id:";
            // 
            // lbl_Dato3
            // 
            this.lbl_Dato3.AutoSize = true;
            this.lbl_Dato3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Dato3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dato3.Location = new System.Drawing.Point(12, 177);
            this.lbl_Dato3.Name = "lbl_Dato3";
            this.lbl_Dato3.Size = new System.Drawing.Size(156, 23);
            this.lbl_Dato3.TabIndex = 2;
            this.lbl_Dato3.Text = "Gastos en cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Nombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(90, 60);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(71, 21);
            this.lbl_Nombre.TabIndex = 4;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Id.Location = new System.Drawing.Point(38, 115);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(26, 21);
            this.lbl_Id.TabIndex = 5;
            this.lbl_Id.Text = "Id";
            // 
            // lbl_Gastos
            // 
            this.lbl_Gastos.AutoSize = true;
            this.lbl_Gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Gastos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Gastos.Location = new System.Drawing.Point(162, 180);
            this.lbl_Gastos.Name = "lbl_Gastos";
            this.lbl_Gastos.Size = new System.Drawing.Size(19, 21);
            this.lbl_Gastos.TabIndex = 6;
            this.lbl_Gastos.Text = "$";
            // 
            // lbl_Dato4
            // 
            this.lbl_Dato4.AutoSize = true;
            this.lbl_Dato4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Dato4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dato4.Location = new System.Drawing.Point(12, 248);
            this.lbl_Dato4.Name = "lbl_Dato4";
            this.lbl_Dato4.Size = new System.Drawing.Size(178, 23);
            this.lbl_Dato4.TabIndex = 7;
            this.lbl_Dato4.Text = "Butacas reservadas: ";
            // 
            // lbl_Butaca
            // 
            this.lbl_Butaca.AutoSize = true;
            this.lbl_Butaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Butaca.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Butaca.Location = new System.Drawing.Point(180, 250);
            this.lbl_Butaca.Name = "lbl_Butaca";
            this.lbl_Butaca.Size = new System.Drawing.Size(69, 21);
            this.lbl_Butaca.TabIndex = 8;
            this.lbl_Butaca.Text = "Butacas";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cerrar.Location = new System.Drawing.Point(445, 11);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(66, 37);
            this.btn_Cerrar.TabIndex = 9;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Reservado por:";
            // 
            // btn_ImprimirTicket
            // 
            this.btn_ImprimirTicket.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ImprimirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImprimirTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ImprimirTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ImprimirTicket.Location = new System.Drawing.Point(360, 283);
            this.btn_ImprimirTicket.Name = "btn_ImprimirTicket";
            this.btn_ImprimirTicket.Size = new System.Drawing.Size(151, 37);
            this.btn_ImprimirTicket.TabIndex = 12;
            this.btn_ImprimirTicket.Text = "Imprimir ticket";
            this.btn_ImprimirTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_ImprimirTicket.UseVisualStyleBackColor = false;
            this.btn_ImprimirTicket.Click += new System.EventHandler(this.btn_ImprimirTicket_Click);
            // 
            // MostrarDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(523, 332);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ImprimirTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lbl_Butaca);
            this.Controls.Add(this.lbl_Dato4);
            this.Controls.Add(this.lbl_Gastos);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Dato3);
            this.Controls.Add(this.lbl_Dato2);
            this.Controls.Add(this.lbl_Dato1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MostrarDatosCliente";
            this.Text = "Datos del cliente";
            this.Load += new System.EventHandler(this.MostrarDatosCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Dato1;
        private System.Windows.Forms.Label lbl_Dato2;
        private System.Windows.Forms.Label lbl_Dato3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Gastos;
        private System.Windows.Forms.Label lbl_Dato4;
        private System.Windows.Forms.Label lbl_Butaca;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ImprimirTicket;
    }
}