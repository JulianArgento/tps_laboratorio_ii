
namespace Clases
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_logUsuario = new System.Windows.Forms.Button();
            this.btn_logAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Titulo.Location = new System.Drawing.Point(259, 49);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(300, 55);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Cines Palomar";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(452, 320);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 40);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(194, 320);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(150, 40);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.Info;
            this.txt_nombre.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre.Location = new System.Drawing.Point(194, 148);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Usuario";
            this.txt_nombre.Size = new System.Drawing.Size(408, 39);
            this.txt_nombre.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Info;
            this.txt_password.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password.Location = new System.Drawing.Point(194, 216);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(408, 39);
            this.txt_password.TabIndex = 4;
            // 
            // btn_logUsuario
            // 
            this.btn_logUsuario.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_logUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_logUsuario.FlatAppearance.BorderSize = 0;
            this.btn_logUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logUsuario.Location = new System.Drawing.Point(12, 374);
            this.btn_logUsuario.Name = "btn_logUsuario";
            this.btn_logUsuario.Size = new System.Drawing.Size(160, 36);
            this.btn_logUsuario.TabIndex = 5;
            this.btn_logUsuario.Text = "Ingresar como usuario";
            this.btn_logUsuario.UseVisualStyleBackColor = false;
            this.btn_logUsuario.Click += new System.EventHandler(this.LogUsuario_Click);
            // 
            // btn_logAdmin
            // 
            this.btn_logAdmin.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_logAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_logAdmin.FlatAppearance.BorderSize = 0;
            this.btn_logAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logAdmin.Location = new System.Drawing.Point(12, 416);
            this.btn_logAdmin.Name = "btn_logAdmin";
            this.btn_logAdmin.Size = new System.Drawing.Size(160, 35);
            this.btn_logAdmin.TabIndex = 6;
            this.btn_logAdmin.Text = "Ingresar como admin";
            this.btn_logAdmin.UseVisualStyleBackColor = false;
            this.btn_logAdmin.Click += new System.EventHandler(this.LogAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logAdmin);
            this.Controls.Add(this.btn_logUsuario);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_logUsuario;
        private System.Windows.Forms.Button btn_logAdmin;
    }
}

