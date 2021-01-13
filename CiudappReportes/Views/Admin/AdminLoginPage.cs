using CiudappReportes.Constants;
using CiudappReportes.Services;
using CiudappReportes.Services.Classes;
using CiudappReportes.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace CiudappReportes.Views.Admin
{
    public partial class AdminLoginPage : Form
    {
        Encrypt encrypt;
        Alert alert;
        Autentication autentication;
        AdminProfilePage app;
        MainPage mainp;


        public AdminLoginPage(IEncrypt encrypt, IAlert alert, IAutentication autentication, AdminProfilePage app)
        {
            InitializeComponent();
            this.encrypt = (Encrypt)encrypt;
            this.alert = (Alert)alert;
            this.autentication = (Autentication)autentication;
            this.app = app;
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string sPass = encrypt.GetSHA256(entryPassword.Text.Trim());

            if (entryUserName.Text == null || sPass == null)
            {
                 alert.DisplayAlert(Messages.LoginEmpty, Messages.ERROR);
            }
            else
            {
                if ( autentication.SignInAutentication(entryUserName.Text, sPass))
                {
                    if (Session.Instance.myDict[Session.idRol] == "1")
                    {
                        alert.DisplayAlert($"{Messages.Welcome} {Session.Instance.myDict[Session.nombre]}", Messages.Authentication);
                        this.Hide();
                        app.FormClosed += (s, args) => this.Close();
                        app.Show();
                    }
                    else
                    {
                        alert.DisplayAlert($"{Messages.ERROR} {Session.Instance.myDict[Session.nombre]} no tiene permisos de administrador", Messages.Authentication);
                        Session.Instance.myDict.Clear();
                    }
;
                }
                else
                {
                     alert.DisplayAlert(Messages.WrongUser, Messages.ERROR);
                }
            }
           
        }
    }
}