using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_CS.Models
{
    public class SolicitudRegistro
    {
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public string empresa { get; set; }
        public string correo { get; set; }

    }
}