using CiudappReportes.Constants;
using CiudappReportes.Models.DBModelTableAdapters;
using CiudappReportes.Services.Interfaces;
using System.Windows.Forms;
using static CiudappReportes.Models.DBModel;

namespace CiudappReportes.Services.Classes
{
    public class Autentication : IAutentication
    {
        public bool AdminAutentication(string userEmail, string password)
        {
            try
            {
                tblPersonasTableAdapter tblPersona = new tblPersonasTableAdapter();
                tblPersonasDataTable personDataTable = tblPersona.GetDataBy(userEmail, password, null);

                foreach (tblPersonasRow value in personDataTable)
                {
                    Session.Instance.myDict.Add(Session.nombre, value.Nombre);
                    Session.Instance.myDict.Add(Session.apellido, value.Apellido);
                    Session.Instance.myDict.Add(Session.noDocumento,value.noDocumento);
                    Session.Instance.myDict.Add(Session.edad,value.Edad.ToString());
                    Session.Instance.myDict.Add(Session.correoElectronico,value.CorreoElectronico);
                    Session.Instance.myDict.Add(Session.noTelefono,value.noTelefono);
                    Session.Instance.myDict.Add(Session.idPersona,value.idPersona.ToString());
                    Session.Instance.myDict.Add(Session.idTipoDocumento,value.idTipoDocumento.ToString());
                    Session.Instance.myDict.Add(Session.idDireccion,value.idDireccion.ToString());
                    Session.Instance.myDict.Add(Session.idRol,value.idRol.ToString());

                }
                if (Session.Instance.myDict[Session.idPersona] == null)
                {
                    return false;
                }
                return true;

            }
            catch (System.Exception e)
            {
                return false;
            }
        }
    }
}
