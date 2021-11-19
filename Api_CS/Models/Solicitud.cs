using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_CS.Models
{
    public class Solicitud 
    {
        public string contraseña { get; set; }
        public string correo { get; set; }
    }
}
