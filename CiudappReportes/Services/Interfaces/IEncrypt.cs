namespace CiudappReportes.Services
{
    public interface IEncrypt
    {
        string GetSHA256(string str);
    }
}
