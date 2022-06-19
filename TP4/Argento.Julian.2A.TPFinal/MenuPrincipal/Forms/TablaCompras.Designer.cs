
namespace Interfaz.Forms
{
    partial class TablaCompras
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
            this.lsb_Compras = new System.Windows.Forms.ListBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_ModoNocturno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsb_Compras
            // 
            this.lsb_Compras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsb_Compras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lsb_Compras.FormattingEnabled = true;
            this.lsb_Compras.ItemHeight = 19;
            this.lsb_Compras.Location = new System.Drawing.Point(12, 60);
            this.lsb_Compras.Name = "lsb_Compras";
            this.lsb_Compras.Size = new System.Drawing.Size(1046, 325);
            this.lsb_Compras.TabIndex = 0;
            this.lsb_Compras.SelectedIndexChanged += new System.EventHandler(this.lsb_Compras_SelectedIndexChanged);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Salir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(912, 391);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(146, 47);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Borrar.Enabled = false;
            this.btn_Borrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Borrar.Location = new System.Drawing.Point(12, 391);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(146, 47);
            this.btn_Borrar.TabIndex = 2;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = false;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Modificar.Enabled = false;
            this.btn_Modificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.Location = new System.Drawing.Point(247, 391);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(146, 47);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Agregar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.Location = new System.Drawing.Point(501, 391);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(146, 47);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_ModoNocturno
            // 
            this.btn_ModoNocturno.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_ModoNocturno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ModoNocturno.Location = new System.Drawing.Point(12, 7);
            this.btn_ModoNocturno.Name = "btn_ModoNocturno";
            this.btn_ModoNocturno.Size = new System.Drawing.Size(146, 29);
            this.btn_ModoNocturno.TabIndex = 5;
            this.btn_ModoNocturno.Text = "Modo Nocturno";
            this.btn_ModoNocturno.UseVisualStyleBackColor = false;
            
            // 
            // TablaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ModoNocturno);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lsb_Compras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TablaCompras";
            this.Text = "ListaCompras";
            this.Load += new System.EventHandler(this.ListaCompras_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_Compras;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_ModoNocturno;
    }
}