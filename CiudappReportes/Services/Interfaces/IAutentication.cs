namespace CiudappReportes.Services.Interfaces
{
    public interface IAutentication
    {
        bool AdminAutentication(string userEmail, string password);
    }
}
