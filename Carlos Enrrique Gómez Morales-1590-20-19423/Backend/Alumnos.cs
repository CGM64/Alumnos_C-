using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Alumnos:Persona
    {
        public string Carnet
        {
            get;
            set;
        }

        public Alumnos(string nombresRecibir, string carnetRecibir): base(nombresRecibir)
        {
            Carnet = carnetRecibir;
        }

        public string ObtenerInformacion()
        {
            return $" Carnet: {Carnet}";
        }
    }
}
