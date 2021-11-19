using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actores
{
    public class Vehiculos
    {


        public string marca { get; set; }
        public string modelo { get; set; }
        public string año { get; set; }
        public string motor { get; set; }
        public string linea { get; set; }
        public string precio { get; set; }

        public bool isEmpty(Vehiculos vehiculo)
        {


            if (vehiculo.marca.Equals(""))
            {

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
