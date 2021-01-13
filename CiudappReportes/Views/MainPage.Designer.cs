
namespace CiudappReportes.Views
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TechnicalButton = new System.Windows.Forms.Button();
            this.IniciarSesion = new System.Windows.Forms.Label();
            this.AdminButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CiudappReportes.Properties.Resources.CiudappIcon;
            this.pictureBox1.Location = new System.Drawing.Point(346, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.Controls.Add(this.TechnicalButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.IniciarSesion, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AdminButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(346, 198);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 189);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TechnicalButton
            // 
            this.TechnicalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.TechnicalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TechnicalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TechnicalButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.TechnicalButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TechnicalButton.Location = new System.Drawing.Point(26, 125);
            this.TechnicalButton.Margin = new System.Windows.Forms.Padding(26, 13, 26, 13);
            this.TechnicalButton.Name = "TechnicalButton";
            this.TechnicalButton.Size = new System.Drawing.Size(285, 51);
            this.TechnicalButton.TabIndex = 2;
            this.TechnicalButton.Text = "Técnico";
            this.TechnicalButton.UseVisualStyleBackColor = false;
            this.TechnicalButton.Click += new System.EventHandler(this.TechnicalButton_Click);
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.AutoSize = true;
            this.IniciarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.IniciarSesion.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F);
            this.IniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.IniciarSesion.Location = new System.Drawing.Point(3, 0);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(331, 37);
            this.IniciarSesion.TabIndex = 0;
            this.IniciarSesion.Text = "Iniciar Sesión";
            this.IniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(118)))), ((int)(((byte)(51)))));
            this.AdminButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminButton.FlatAppearance.BorderSize = 0;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.AdminButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdminButton.Location = new System.Drawing.Point(26, 50);
            this.AdminButton.Margin = new System.Windows.Forms.Padding(26, 13, 26, 13);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(285, 49);
            this.AdminButton.TabIndex = 1;
            this.AdminButton.Text = "Administrador";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::CiudappReportes.Properties.Resources.MOPC_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(26, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PictureBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 390);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Image = global::CiudappReportes.Properties.Resources.Image3;
            this.PictureBox.InitialImage = global::CiudappReportes.Properties.Resources.Image3;
            this.PictureBox.Location = new System.Drawing.Point(3, 198);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(337, 189);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            this.PictureBox.WaitOnLoad = true;
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(255, 187);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button TechnicalButton;
        private System.Windows.Forms.Label IniciarSesion;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Timer Timer;
    }
}