
namespace CiudappReportes.Views.Tecnico
{
    partial class TecnicoLogin
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
            this.Contrasena = new System.Windows.Forms.TextBox();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Contrasena
            // 
            this.Contrasena.AllowDrop = true;
            this.Contrasena.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.Contrasena.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Contrasena.Location = new System.Drawing.Point(279, 227);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(253, 22);
            this.Contrasena.TabIndex = 5;
            this.Contrasena.Text = "Contraseña";
            this.Contrasena.TextChanged += new System.EventHandler(this.Contrasena_TextChanged);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AllowDrop = true;
            this.NombreUsuario.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.NombreUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NombreUsuario.Location = new System.Drawing.Point(279, 188);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(253, 22);
            this.NombreUsuario.TabIndex = 4;
            this.NombreUsuario.Text = "Nombre de usuario";
            this.NombreUsuario.TextChanged += new System.EventHandler(this.NombreUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "Técnico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TecnicoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.label1);
            this.Name = "TecnicoLogin";
            this.Text = "TecnicoLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Contrasena;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.Label label1;
    }
}