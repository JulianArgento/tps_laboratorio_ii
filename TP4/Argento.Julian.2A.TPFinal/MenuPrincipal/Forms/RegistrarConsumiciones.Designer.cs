
namespace Interfaz.Forms
{
    partial class RegistrarConsumiciones
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.num_CantidadAComprar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.cbx_Pochoclos = new System.Windows.Forms.CheckBox();
            this.cbx_Gaseosa = new System.Windows.Forms.CheckBox();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.cmb_Tamanio = new System.Windows.Forms.ComboBox();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.cmb_Marca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Tamanio = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_CantidadAComprar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(101, 36);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Tienda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Comprar.Location = new System.Drawing.Point(722, 401);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(161, 50);
            this.btn_Comprar.TabIndex = 4;
            this.btn_Comprar.Text = "Realizar compra";
            this.btn_Comprar.UseVisualStyleBackColor = false;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // num_CantidadAComprar
            // 
            this.num_CantidadAComprar.BackColor = System.Drawing.Color.LightSalmon;
            this.num_CantidadAComprar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_CantidadAComprar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_CantidadAComprar.Location = new System.Drawing.Point(289, 426);
            this.num_CantidadAComprar.Name = "num_CantidadAComprar";
            this.num_CantidadAComprar.Size = new System.Drawing.Size(161, 25);
            this.num_CantidadAComprar.TabIndex = 5;
            this.num_CantidadAComprar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(289, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad a comprar";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Red;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Salir.Location = new System.Drawing.Point(816, 9);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(67, 36);
            this.btn_Salir.TabIndex = 33;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // cbx_Pochoclos
            // 
            this.cbx_Pochoclos.AutoSize = true;
            this.cbx_Pochoclos.BackColor = System.Drawing.Color.LightSalmon;
            this.cbx_Pochoclos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Pochoclos.ForeColor = System.Drawing.Color.Black;
            this.cbx_Pochoclos.Location = new System.Drawing.Point(23, 192);
            this.cbx_Pochoclos.Name = "cbx_Pochoclos";
            this.cbx_Pochoclos.Size = new System.Drawing.Size(109, 25);
            this.cbx_Pochoclos.TabIndex = 34;
            this.cbx_Pochoclos.Text = "Pochoclos";
            this.cbx_Pochoclos.UseVisualStyleBackColor = false;
            this.cbx_Pochoclos.CheckedChanged += new System.EventHandler(this.cbx_Pochoclos_CheckedChanged);
            // 
            // cbx_Gaseosa
            // 
            this.cbx_Gaseosa.AutoSize = true;
            this.cbx_Gaseosa.BackColor = System.Drawing.Color.LightSalmon;
            this.cbx_Gaseosa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Gaseosa.ForeColor = System.Drawing.Color.Black;
            this.cbx_Gaseosa.Location = new System.Drawing.Point(23, 281);
            this.cbx_Gaseosa.Name = "cbx_Gaseosa";
            this.cbx_Gaseosa.Size = new System.Drawing.Size(93, 25);
            this.cbx_Gaseosa.TabIndex = 35;
            this.cbx_Gaseosa.Text = "Gaseosa";
            this.cbx_Gaseosa.UseVisualStyleBackColor = false;
            this.cbx_Gaseosa.CheckedChanged += new System.EventHandler(this.cbx_Gaseosa_CheckedChanged);
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Producto.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Producto.Location = new System.Drawing.Point(23, 110);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(109, 27);
            this.lbl_Producto.TabIndex = 36;
            this.lbl_Producto.Text = "Productos";
            // 
            // cmb_Tamanio
            // 
            this.cmb_Tamanio.BackColor = System.Drawing.Color.LightSalmon;
            this.cmb_Tamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tamanio.Enabled = false;
            this.cmb_Tamanio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Tamanio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Tamanio.FormattingEnabled = true;
            this.cmb_Tamanio.Items.AddRange(new object[] {
            "Chico",
            "Mediano",
            "Grande"});
            this.cmb_Tamanio.Location = new System.Drawing.Point(249, 156);
            this.cmb_Tamanio.Name = "cmb_Tamanio";
            this.cmb_Tamanio.Size = new System.Drawing.Size(121, 29);
            this.cmb_Tamanio.TabIndex = 37;
            this.cmb_Tamanio.SelectedIndexChanged += new System.EventHandler(this.cmb_Tamanio_SelectedIndexChanged);
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.BackColor = System.Drawing.Color.LightSalmon;
            this.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo.Enabled = false;
            this.cmb_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Tipo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Salados",
            "Dulces"});
            this.cmb_Tipo.Location = new System.Drawing.Point(461, 158);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(121, 29);
            this.cmb_Tipo.TabIndex = 38;
            this.cmb_Tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_Tipo_SelectedIndexChanged);
            // 
            // cmb_Marca
            // 
            this.cmb_Marca.BackColor = System.Drawing.Color.LightSalmon;
            this.cmb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Marca.Enabled = false;
            this.cmb_Marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Marca.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Marca.FormattingEnabled = true;
            this.cmb_Marca.Items.AddRange(new object[] {
            "Coca-Cola",
            "Sprite",
            "Fanta"});
            this.cmb_Marca.Location = new System.Drawing.Point(668, 158);
            this.cmb_Marca.Name = "cmb_Marca";
            this.cmb_Marca.Size = new System.Drawing.Size(121, 29);
            this.cmb_Marca.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(249, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 36);
            this.label4.TabIndex = 40;
            // 
            // lbl_Tamanio
            // 
            this.lbl_Tamanio.AutoSize = true;
            this.lbl_Tamanio.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Tamanio.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tamanio.Location = new System.Drawing.Point(249, 110);
            this.lbl_Tamanio.Name = "lbl_Tamanio";
            this.lbl_Tamanio.Size = new System.Drawing.Size(88, 27);
            this.lbl_Tamanio.TabIndex = 41;
            this.lbl_Tamanio.Text = "Tamaño";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Tipo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tipo.Location = new System.Drawing.Point(425, 110);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(187, 27);
            this.lbl_Tipo.TabIndex = 42;
            this.lbl_Tipo.Text = "Tipo de pochoclos";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Marca.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Marca.Location = new System.Drawing.Point(641, 110);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(183, 27);
            this.lbl_Marca.TabIndex = 43;
            this.lbl_Marca.Text = "Marca de gaseosa";
            // 
            // RegistrarConsumiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interfaz.Properties.Resources.TiendaCine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 463);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Tamanio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Marca);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.cmb_Tamanio);
            this.Controls.Add(this.lbl_Producto);
            this.Controls.Add(this.cbx_Gaseosa);
            this.Controls.Add(this.cbx_Pochoclos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_CantidadAComprar);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "RegistrarConsumiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Consumiciones";
       
            ((System.ComponentModel.ISupportInitialize)(this.num_CantidadAComprar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.NumericUpDown num_CantidadAComprar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.CheckBox cbx_Pochoclos;
        private System.Windows.Forms.CheckBox cbx_Gaseosa;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.ComboBox cmb_Tamanio;
        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.ComboBox cmb_Marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Tamanio;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_Marca;
    }
}