using System.Threading.Tasks;

namespace CiudappReportes.Services
{
    public interface IAlert
    {
         Task DisplayAlert(string text, string caption);
    }
}
