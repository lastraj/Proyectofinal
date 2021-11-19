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
    public class GestorUsuarios
    {
        DataUsuarios GestorUsrs = new DataUsuarios();

        public bool Registrar(Usuarios usuario)
        {
            return GestorUsrs.Registrar(usuario);
        }
        public bool IsEmpty(Usuarios usuario)
        {
            if (usuario.correo.Equals("") || usuario.contraseña.Equals(""))

            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool iniciarSesionUser(Usuarios usuario)
        {

            return GestorUsrs.iniciarSesionUser(usuario);

        }
        public bool email_bien_escrito(Usuarios usuario)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(usuario.correo, expresion))
            {
                if (Regex.Replace(usuario.correo, expresion, String.Empty).Length == 0)
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
