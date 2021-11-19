using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actores;
using AcccesoDatos;
using System.Text.RegularExpressions;

namespace ReglasNegocio
{
    public class GestorAdministradores
    {
         DataAdministradores GestorADM = new DataAdministradores();

        public bool Registrar(Administradores administradores)
        {
            return GestorADM.RegistrarAdmin(administradores);
        }
        public bool IsEmpty(Administradores administradores)
        {
            if (administradores.correo.Equals("") || administradores.contraseña.Equals("") )

            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool iniciarSesionAdmin(Administradores administradores)
        {

            return GestorADM.iniciarsesionAdmin(administradores);

        }
        public bool email_bien_escrito(Administradores administradores)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(administradores.correo, expresion))
            {
                if (Regex.Replace(administradores.correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
