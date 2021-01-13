using CiudappReportes.Constants;
using CiudappReportes.Models;
using CiudappReportes.Services;
using System.Windows.Forms;

namespace CiudappReportes.Views.Admin
{
    public partial class AdminProfilePage : Form
    {
        Alert alert;
        public AdminProfilePage(IAlert alert)
        {
            InitializeComponent();
            this.alert = (Alert)alert;
        }

        private void ReportProblemButton_Click(object sender, System.EventArgs e)
        {
           
        }

        private void AdminProfilePage_Load(object sender, System.EventArgs e)
        {
            lblNombre.Text = Session.Instance.myDict[Session.nombre];
            lblCorreo.Text = Session.Instance.myDict[Session.correoElectronico];
            lblNoCarnet.Text = Session.Instance.myDict[Session.idPersona];
            lblTelefono.Text = Session.Instance.myDict[Session.noTelefono];
        }
    }
}
