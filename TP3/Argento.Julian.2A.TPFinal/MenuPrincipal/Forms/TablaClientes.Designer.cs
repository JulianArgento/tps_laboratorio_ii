
namespace Interfaz.Forms
{
    partial class TablaClientes
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
            this.lsb_Clientes = new System.Windows.Forms.ListBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Ficha = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.lbl_Instruccion = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsb_Clientes
            // 
            this.lsb_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsb_Clientes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lsb_Clientes.FormattingEnabled = true;
            this.lsb_Clientes.ItemHeight = 21;
            this.lsb_Clientes.Location = new System.Drawing.Point(12, 87);
            this.lsb_Clientes.Name = "lsb_Clientes";
            this.lsb_Clientes.Size = new System.Drawing.Size(960, 315);
            this.lsb_Clientes.TabIndex = 0;
            this.lsb_Clientes.SelectedIndexChanged += new System.EventHandler(this.lsb_Clientes_SelectedIndexChanged);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 453);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(154, 62);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Ficha
            // 
            this.btn_Ficha.Location = new System.Drawing.Point(514, 453);
            this.btn_Ficha.Name = "btn_Ficha";
            this.btn_Ficha.Size = new System.Drawing.Size(154, 62);
            this.btn_Ficha.TabIndex = 2;
            this.btn_Ficha.Text = "Imprimir ficha de clientes";
            this.btn_Ficha.UseVisualStyleBackColor = true;
            this.btn_Ficha.Click += new System.EventHandler(this.btn_Ficha_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(196, 453);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(154, 62);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Enabled = false;
            this.btn_Seleccionar.Location = new System.Drawing.Point(793, 453);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(154, 62);
            this.btn_Seleccionar.TabIndex = 4;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // lbl_Instruccion
            // 
            this.lbl_Instruccion.AutoSize = true;
            this.lbl_Instruccion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Instruccion.Location = new System.Drawing.Point(12, 28);
            this.lbl_Instruccion.Name = "lbl_Instruccion";
            this.lbl_Instruccion.Size = new System.Drawing.Size(796, 30);
            this.lbl_Instruccion.TabIndex = 5;
            this.lbl_Instruccion.Text = "Seleccione el cliente con el que se quiere realizar la operacion, o agregue uno n" +
    "uevo";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Brown;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Cancelar.Location = new System.Drawing.Point(898, 12);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(74, 26);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // TablaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(984, 527);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_Instruccion);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Ficha);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lsb_Clientes);
            this.Name = "TablaClientes";
            this.Text = "TablaClientes";
            this.Load += new System.EventHandler(this.TablaClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_Clientes;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Ficha;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Label lbl_Instruccion;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}