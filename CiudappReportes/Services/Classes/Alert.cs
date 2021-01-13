using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiudappReportes.Services
{
    public class Alert : IAlert
    {
        public Task DisplayAlert(string text, string caption)
        {
            MessageBox.Show(text, caption);
            return null;
        }
    }
}
