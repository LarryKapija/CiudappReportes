using CiudappReportes.Services;
using CiudappReportes.Views.Admin;
using CiudappReportes.Views.Technical;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CiudappReportes.Views
{
    public partial class MainPage : Form
    {
        AdminLoginPage alp;
        TechnicalLoginPage tlp;
        Random random;
        public MainPage(AdminLoginPage alp, TechnicalLoginPage tlp)
        {
            InitializeComponent();
            this.alp = alp;
            this.tlp = tlp;

        }

        public MainPage()
        {
            InitializeComponent();
        }




        private void MainPage_Load(object sender, System.EventArgs e)
        {
            string[] img = { @"C:\Users\User\Documents\Trimestre 5\Base de Datos\Recursos\Image1.jpg", 
                @"C:\Users\User\Documents\Trimestre 5\Base de Datos\Recursos\Image2.jpg",
                @"C:\Users\User\Documents\Trimestre 5\Base de Datos\Recursos\Image3.png", 
                @"C:\Users\User\Documents\Trimestre 5\Base de Datos\Recursos\Image4.jpg", 
                @"C:\Users\User\Documents\Trimestre 5\Base de Datos\Recursos\Image5.jpg" };
            var image = ImageList.Images;
            foreach (var item in img)
            {
                image.Add(Image.FromFile(item));
            }
        }
        private void Timer_Tick(object sender, System.EventArgs e)
        {
            random = new Random();
            PictureBox.Image = ImageList.Images[random.Next(0, 2)];
        }

        private void AdminButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            alp.FormClosed += (s, args) => this.Close();
            alp.Show();
        }

        private void TechnicalButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            tlp.FormClosed += (s, args) => this.Close();
            tlp.Show();
        }


    }
}
