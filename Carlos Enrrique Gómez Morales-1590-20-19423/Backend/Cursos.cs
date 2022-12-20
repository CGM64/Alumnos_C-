using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Cursos
    {
        public string Codigo
        {
            get;
            set;
        }

        public string Curso
        {
            get;
            set;
        }

        public float PrimerParcial { 
            get; 
            set; 
        }

        public float SegundoParcial { 
            get; 
            set; 
        }

        public float Final { 
            get; 
            set; 
        }

        public float Zona { 
            get; 
            set; 
        }

        public float NotaFinal { 
            get; 
            set; 
        }

        private string situacion;

        public string Situacion
        {
            get { 
                if(NotaFinal >= 61)
                {
                    situacion = "APROBADO";
                } else if(NotaFinal < 61)
                {
                    situacion = "REPROBADO";
                }
                return situacion; 
            }
        }

        public float Promedio { 
            get; 
            set; 
        }
    }
}
