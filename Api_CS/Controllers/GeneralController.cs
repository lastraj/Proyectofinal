using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReglasNegocio;
using Api_CS.Models;
using Actores;


namespace Api_CS.Controllers
{
    public class GeneralController : ApiController
    {

        [Route("api/inicio")]
        [HttpPost]
        public Respuesta InciarSesion([FromBody] Solicitud request)
        {
            GestorAdministradores Admin = new GestorAdministradores();

            Administradores adm = new Administradores();


            string contraseña = request.contraseña;
            string correo = request.correo;


            adm.contraseña = contraseña;
            adm.correo = correo;

            bool inicio = Admin.iniciarSesionAdmin(adm);

            Respuesta resp = new Respuesta();
            resp.resultado = inicio;

            return resp;
        }
        [Route("api/RegistroAdmin")]
        [HttpPost]
        public Respuesta RegistrarAdm([FromBody] SolicitudRegistro request2)
        {
            GestorAdministradores Admin = new GestorAdministradores();

            Administradores admi = new Administradores();

            string nombre = request2.nombre;
            string contraseña = request2.contraseña;
            string empresa = request2.empresa;
            string correo = request2.correo;

            admi.contraseña = contraseña;
            admi.correo = correo;
            admi.empresa = empresa;
            admi.nombre = nombre;

            bool registro = Admin.Registrar(admi);

            Respuesta resp = new Respuesta();
            resp.resultado = registro;

            return resp;
        }
        [Route("api/RegistroUser")]
        [HttpPost]
        public Respuesta RegistrarUser([FromBody] SolicitudRegistroUser request3)
        {
            GestorUsuarios Usr = new GestorUsuarios();

             Usuarios user = new Usuarios();

            string nombre = request3.nombre;
            string contraseña = request3.contraseña;
           
            string correo = request3.correo;

            user.nombre = contraseña;
            user.correo = correo;
            user.nombre = nombre;

            bool registro = Usr.Registrar(user);

            Respuesta resp = new Respuesta();
            resp.resultado = registro;

            return resp;
        }
        [Route("api/inicioUser")]
        [HttpPost]
        public Respuesta InciarSesionUser([FromBody] Solicitud request4)
        {
            GestorUsuarios User = new GestorUsuarios();

            Usuarios usr = new Usuarios();


            string contraseña = request4.contraseña;
            string correo = request4.correo;


            usr.contraseña = contraseña;
            usr.correo = correo;

            bool inicio = User.iniciarSesionUser(usr);

            Respuesta resp = new Respuesta();
            resp.resultado = inicio;

            return resp;
        }
        [Route("api/RegistroVehi")]
        [HttpPost]
        public Respuesta RegistrarVehi([FromBody] SolicitudRegistrarVehi request5)
        {
            GestorVehiculos Vehicu = new GestorVehiculos();

            Vehiculos veh = new Vehiculos();

            string marca = request5.marca;
            string modelo = request5.modelo;
            string año = request5.año;
            string precio = request5.precio;

            veh.marca = marca;
            veh.modelo = modelo;
            veh.año = año;
            veh.precio = precio;
            bool registro = Vehicu.RegistrarVehi(veh);

            Respuesta resp = new Respuesta();
            resp.resultado = registro;

            return resp;
        }
        [Route("api/MostrarVehi")]
        [HttpPost]
        public Respuesta_list MostrarVehi([FromBody] SolicitudMostrar request6)
        {
            GestorVehiculos Vehicu = new GestorVehiculos();
                                            
                      
            List<Vehiculos> V = Vehicu.MostrarVehiculos();

            Respuesta_list resp = new Respuesta_list();
            resp.NuevosVehiculos = V;

            return resp;
        }
    }



    
}
