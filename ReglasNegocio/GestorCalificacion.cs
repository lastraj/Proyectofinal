using Actores;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcccesoDatos;
using System.Data;

namespace ReglasNegocio
{
    public class GestorCalificacion
    {
        DataCalificacion dataCalificacion = new DataCalificacion();
     
        string respuestaInsercion = "";

        public string ingresarCalificacion(Calificacion calificacion)
        {
            respuestaInsercion = dataCalificacion.registrarCalificacion(calificacion);
            return respuestaInsercion;
        }
        DataCalificacion GestorT = new DataCalificacion();

        public DataTable MostrarTop(Vehiculos vehiculos)
        {
            return GestorT.MostrarTop(vehiculos);
        }

        public DataTable MostrarTopMenos(Vehiculos vehiculos)
        {
            return GestorT.MostrarTopMenos(vehiculos);
        }
    }
}
