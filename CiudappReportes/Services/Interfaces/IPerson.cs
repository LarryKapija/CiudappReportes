using CiudappReportes.Models;
using System.Threading.Tasks;

namespace CiudappReportes.Services.Interfaces
{
    public interface IPerson
    {
        Task GetPerson(PersonModel person);
    }
}
