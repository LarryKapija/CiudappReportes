using CiudappReportes.Services;
using System;
using System.Windows.Forms;

namespace CiudappReportes.Views.Admin
{
    public partial class AdminLoginPage : Form
    {
        public Alert alert ;
        public AdminLoginPage(IAlert alert)
        {
            InitializeComponent();
            this.alert = (Alert)alert;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            alert.DisplayAlert(entryUserName.Text,"ERROR");
            //LogInPage lp = new LogInPage();
            //lp.Show();
            //this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminProfilePage app = new AdminProfilePage();
            app.Show();
        }
    }
}
