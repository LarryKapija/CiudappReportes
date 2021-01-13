using System;
using System.Collections.Generic;

namespace CiudappReportes.Constants
{
    public class Session
    {
        private Session()
        {   

        }
        private static Session instance;
        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                   return instance = new Session();
                }
                else
                {
                    return instance;
                }
               
            }
        }
        public Dictionary<string, string> myDict = new Dictionary<string, string>();
        public const string nombre = nameof(nombre);
        public const string apellido = nameof(apellido);
        public const string noDocumento = nameof(noDocumento);
        public const string nombreRol = nameof(nombreRol);
        public const string edad = nameof(edad);
        public const string correoElectronico = nameof(correoElectronico);
        public const string noTelefono = nameof(noTelefono);
       // public byte[] fotoPerfil = nameof(nombre);
        public const string idPersona = nameof(idPersona);
        public const string idTipoDocumento = nameof(idTipoDocumento);
        public const string idDireccion = nameof(idDireccion);
        public const string idRol = nameof(idRol);
    }
}
