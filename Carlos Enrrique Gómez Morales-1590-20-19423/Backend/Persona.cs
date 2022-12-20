using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Persona
    {
        public string Nombre { 
            get; 
            set; 
        }

        public Persona(string nombreRecibir)
        {
            Nombre = nombreRecibir;
        }

        public string ObtenerInformacion()
        {
            return $" Nombre: {Nombre}";
        }
    }
}
