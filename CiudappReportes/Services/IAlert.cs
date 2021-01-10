using System.Threading.Tasks;

namespace CiudappReportes.Services
{
    public interface IAlert
    {
        public Task DisplayAlert(string text, string caption);
    }
}
