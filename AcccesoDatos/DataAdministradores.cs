using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Actores;
using System.Configuration;

namespace AcccesoDatos
{
    public class DataAdministradores
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["CadenaConexion"]);
        public bool RegistrarAdmin(Administradores administrador)

        {
            try
            {

                bool existe = false;
                string respuesta = "";



                SqlCommand cmd = new SqlCommand("USP_RegistrarAdmin", cn);



                cmd.CommandType = CommandType.StoredProcedure;

                
                cmd.Parameters.Add("@nombre", administrador.nombre);
                cmd.Parameters.Add("@contraseña", administrador.contraseña);
                cmd.Parameters.Add("@empresa", administrador.empresa);
                cmd.Parameters.Add("@correo", administrador.correo);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    respuesta = dr["respuesta"].ToString();
                    cn.Close();
                }


                if (respuesta.Equals("true"))
                {
                    existe = true;
                }

                return existe;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }

        }

        public bool iniciarsesionAdmin(Administradores administradores)
        {
            try
            {
                bool existe = false;
                string respuesta = "";



                SqlCommand cmd = new SqlCommand("USP_IniciarSesionAdmin", cn);



                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@correo", administradores.correo);
                cmd.Parameters.Add("@contraseña", administradores.contraseña);


                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    respuesta = dr["respuesta"].ToString();
                    cn.Close();
                }


                if (respuesta.Equals("true"))
                {
                    existe = true;
                }

                return existe;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
