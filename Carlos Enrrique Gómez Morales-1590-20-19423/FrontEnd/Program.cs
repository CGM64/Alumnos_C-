using System;
using Backend;

namespace FrontEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string carnet, nombre;
            int cantidadCursos;
            float sumaNotasFinales = 0;

            Persona objPersona;
            Alumnos objAlumnos;

            Console.WriteLine("\t Universidad Mariano Gálvez de Guatemala");
            Console.WriteLine("\t\tDatos del alumno");
            Console.Write(" Carnet: ");
            carnet = Console.ReadLine();
            Console.Write(" Alumno (Nombre completo): ");
            nombre = Console.ReadLine();

            objPersona = new Persona(nombre);
            objAlumnos = new Alumnos(carnet, nombre);

            Cursos objCursos = new Cursos();

            Console.Write(" Cantidad de cursos: ");
            cantidadCursos = int.Parse(Console.ReadLine());

            //Arreglo de cursos
            Cursos[] objCursosArreglo = new Cursos[cantidadCursos];

            for (int i = 0;  i < objCursosArreglo.Length; i++)
            {
                //Con la instancia del objeto objCursos, cada vez que corre el ciclo, se agrega un nuevo objeto al vector del arreglo objCursosArreglo
                objCursos = new Cursos();

                Console.WriteLine(" Curso No." + (i + 1));
                Console.Write(" Código del curso: ");
                objCursos.Codigo = Console.ReadLine();
                Console.Write(" Nombre del curso: ");
                objCursos.Curso = Console.ReadLine();
                Console.Write(" Nota primer parcial: ");
                objCursos.PrimerParcial = float.Parse(Console.ReadLine());

                while (objCursos.PrimerParcial > 10 || objCursos.PrimerParcial < 0)
                {
                    if (objCursos.PrimerParcial > 10)
                    {
                        Console.WriteLine(" ¡Error: La nota del primer parcial, es superior a 10 puntos!\n");
                    }
                    else if (objCursos.PrimerParcial < 0)
                    {
                        Console.WriteLine(" ¡Error: La nota del primer parcial, es inferior a 0 puntos!\n");
                    }

                    Console.Write(" Nota primer parcial: ");
                    objCursos.PrimerParcial = float.Parse(Console.ReadLine());
                }

                Console.Write(" Nota segundo parcial: ");
                objCursos.SegundoParcial = float.Parse(Console.ReadLine());

                while (objCursos.SegundoParcial > 20 || objCursos.SegundoParcial < 0)
                {
                    if (objCursos.SegundoParcial > 20)
                    {
                        Console.WriteLine(" ¡Error: La nota del segundo parcial, es superior a 20 puntos!\n");
                    }
                    else if (objCursos.SegundoParcial < 0)
                    {
                        Console.WriteLine(" ¡Error: La nota del segundo parcial, es inferior a 0 puntos!\n");
                    }

                    Console.Write(" Nota segundo parcial: ");
                    objCursos.SegundoParcial = float.Parse(Console.ReadLine());
                }

                Console.Write(" Nota examen final: ");
                objCursos.Final = float.Parse(Console.ReadLine());

                while(objCursos.Final > 40 || objCursos.Final < 0)
                {
                    if (objCursos.Final > 40)
                    {
                        Console.WriteLine(" ¡Error: La nota del examen final, es superior a 40 puntos!\n");
                    }
                    else if (objCursos.Final < 0)
                    {
                        Console.WriteLine(" ¡Error: La nota del examen final, es inferior a 0 puntos!\n");
                    }

                    Console.Write(" Nota examen final: ");
                    objCursos.Final = float.Parse(Console.ReadLine());
                }

                Console.Write(" Zona: ");
                objCursos.Zona = float.Parse(Console.ReadLine());

                while(objCursos.Zona > 30 || objCursos.Zona < 0)
                {
                    if (objCursos.Zona > 30)
                    {
                        Console.WriteLine(" ¡Error: La nota de la zona, es superior a 30 puntos!\n");
                    }
                    else if (objCursos.Zona < 0)
                    {
                        Console.WriteLine(" ¡Error: La nota de la zona, es inferior a 0 puntos!\n");
                    }

                    Console.Write(" Zona: ");
                    objCursos.Zona = float.Parse(Console.ReadLine());
                }

                objCursos.NotaFinal = objCursos.PrimerParcial + objCursos.SegundoParcial + objCursos.Zona + objCursos.Final;

                objCursosArreglo[i] = objCursos;

                Console.Write(" Presione la tecla ENTER, para continuar.");

                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine(" \tUniversidad Mariano Gálvez de Guatemala");
            Console.WriteLine(objAlumnos.ObtenerInformacion());
            Console.WriteLine(objPersona.ObtenerInformacion() + "\n");

            for(int j = 0; j < objCursosArreglo.Length; j++)
            {
                Console.WriteLine(" Código: " + objCursosArreglo[j].Codigo);
                Console.WriteLine(" Curso: " + objCursosArreglo[j].Curso);
                Console.WriteLine(" Primer parcial: " + objCursosArreglo[j].PrimerParcial);
                Console.WriteLine(" Segundo parcial: " + objCursosArreglo[j].SegundoParcial);
                Console.WriteLine(" Final: " + objCursosArreglo[j].Final);
                Console.WriteLine(" Zona: " + objCursosArreglo[j].Zona);
                Console.WriteLine(" Nota final: " + objCursosArreglo[j].NotaFinal);
                Console.WriteLine(" Situación: " + objCursosArreglo[j].Situacion + "\n");

                sumaNotasFinales = sumaNotasFinales + objCursosArreglo[j].NotaFinal;
                
                if(j == objCursosArreglo.Length - 1)
                {
                    objCursos.Promedio = sumaNotasFinales / objCursosArreglo.Length;

                    Console.WriteLine(" Promedio de todas las notas finales: " + objCursos.Promedio);
                }
            }

            Console.ReadKey();
        }
    }
}
