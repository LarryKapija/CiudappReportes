using CiudappReportes.Services;
using CiudappReportes.ViewModels;
using CiudappReportes.Views.Admin;
using CiudappReportes.Views.Technical;
using System.Windows.Forms;

namespace CiudappReportes.Views
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, System.EventArgs e)
        {

            //this.Hide();
            //AdminLoginPage alp = new AdminLoginPage();
            ////alp.FormClosed += (s, args) => this.Close();
            //alp.Show();
        }

        private void btnTechnical_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            TechnicalLoginPage tlp = new TechnicalLoginPage();
            //tlp.FormClosed += (s, args) => this.Close();
            tlp.Show();
        }
    }
}
