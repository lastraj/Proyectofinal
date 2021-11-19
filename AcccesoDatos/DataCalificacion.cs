using Actores;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcccesoDatos
{
    public class DataCalificacion
    {
        string respuestaSP = "";
        SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["CadenaConexion"]);
        public string registrarCalificacion(Calificacion calificacion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_CalificarVehiculo", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@calificacion", calificacion.calificacion);
                cmd.Parameters.AddWithValue("@observacion", calificacion.observacion);
                cmd.Parameters.AddWithValue("@recomendacion", calificacion.recomendacion);
                cmd.Parameters.AddWithValue("@id", calificacion.idCarro);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    respuestaSP = dr["respuesta"].ToString();
                    cn.Close();
                }

            }
            catch (Exception err)
            {
                respuestaSP = err.Message;
                throw new Exception(err.Message);
            }

            return respuestaSP;
        }
        
        public DataTable MostrarTop(Vehiculos vehiculos)
        {


            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("USP_Top", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable DGVtop = new DataTable();
                DGVtop.Load(dr);
                cn.Close();

                return DGVtop;


            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public DataTable MostrarTopMenos(Vehiculos vehiculos)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("USP_TopMenos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable DGVtop = new DataTable();
                DGVtop.Load(dr);
                cn.Close();

                return DGVtop;


            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }



        }
    }
}
