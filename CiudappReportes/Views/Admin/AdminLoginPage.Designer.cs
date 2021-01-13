
namespace CiudappReportes.Views.Admin
{
    partial class AdminLoginPage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SignInButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.entryPassword = new System.Windows.Forms.TextBox();
            this.entryUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.XButton = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.SignInButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.entryPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.entryUserName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.XButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SignInButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.SignInButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.SignInButton.Location = new System.Drawing.Point(209, 238);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(4);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(266, 31);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Ingresar";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(100, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(41, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Correo electrónico";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // entryPassword
            // 
            this.entryPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.entryPassword.Location = new System.Drawing.Point(208, 198);
            this.entryPassword.Name = "entryPassword";
            this.entryPassword.PasswordChar = '*';
            this.entryPassword.Size = new System.Drawing.Size(268, 29);
            this.entryPassword.TabIndex = 1;
            // 
            // entryUserName
            // 
            this.entryUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.entryUserName.Location = new System.Drawing.Point(208, 159);
            this.entryUserName.Name = "entryUserName";
            this.entryUserName.Size = new System.Drawing.Size(268, 29);
            this.entryUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(208, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XButton
            // 
            this.XButton.Image = global::CiudappReportes.Properties.Resources.x_button;
            this.XButton.Location = new System.Drawing.Point(649, 13);
            this.XButton.Margin = new System.Windows.Forms.Padding(170, 13, 3, 3);
            this.XButton.Name = "XButton";
            this.XButton.Padding = new System.Windows.Forms.Padding(3);
            this.XButton.Size = new System.Drawing.Size(21, 19);
            this.XButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.XButton.TabIndex = 8;
            this.XButton.TabStop = false;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // AdminLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(118)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entryPassword;
        private System.Windows.Forms.TextBox entryUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.PictureBox XButton;
    }
}