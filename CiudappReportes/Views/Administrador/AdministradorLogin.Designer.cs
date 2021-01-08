
namespace CiudappReportes.Views.Administrador
{
    partial class AdministradorLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.Contrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AllowDrop = true;
            this.NombreUsuario.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.NombreUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NombreUsuario.Location = new System.Drawing.Point(273, 175);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(253, 22);
            this.NombreUsuario.TabIndex = 1;
            this.NombreUsuario.Text = "Nombre de usuario";
            // 
            // Contrasena
            // 
            this.Contrasena.AllowDrop = true;
            this.Contrasena.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.Contrasena.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Contrasena.Location = new System.Drawing.Point(274, 214);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(253, 22);
            this.Contrasena.TabIndex = 2;
            this.Contrasena.Text = "Contraseña";
            // 
            // AdministradorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.label1);
            this.Name = "AdministradorLogin";
            this.Text = "AdministradorLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.TextBox Contrasena;
    }
}