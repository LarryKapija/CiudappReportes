using CiudappReportes.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiudappReportes.Views.Technical
{
    public partial class TechnicalProfilePage : Form
    {
        public TechnicalProfilePage()
        {
            InitializeComponent();
        }

        private void TechnicalProfilePage_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Session.Instance.myDict[Session.nombre];
            lblCorreo.Text = Session.Instance.myDict[Session.correoElectronico];
            lblNoCarnet.Text = Session.Instance.myDict[Session.idPersona];
            lblTelefono.Text = Session.Instance.myDict[Session.noTelefono];
        }
    }
}
