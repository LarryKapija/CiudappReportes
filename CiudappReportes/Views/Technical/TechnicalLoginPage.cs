using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CiudappReportes.Views.Technical
{
    public partial class TechnicalLoginPage : Form
    {
        public TechnicalLoginPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogInPage lp = new LogInPage();
            lp.Show();
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
            TechnicalProfilePage tpp = new TechnicalProfilePage();
            tpp.Show();
        }
    }
}
