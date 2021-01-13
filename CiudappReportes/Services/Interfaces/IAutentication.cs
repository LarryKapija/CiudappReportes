namespace CiudappReportes.Services.Interfaces
{
    public interface IAutentication
    {
        bool SignInAutentication(string userEmail, string password);
    }
}
