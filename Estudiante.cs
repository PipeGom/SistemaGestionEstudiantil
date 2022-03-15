using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEstudiantil
{
    internal class Estudiante : Acudiente
    {
        public string id;
        public string sexo;
        public string nombre;
        public string gradoAcursar;
        public string promedio;
        public string direccion;
        public object acudiente;



        public Estudiante(string id = "", string sexo = "", string nombre = "", string gradoAcursar = "",
                                               string promedio = "", string direccion = "", object acudiente = null)
        {
            this.id = id;
            this.sexo = sexo;
            this.nombre = nombre;
            this.gradoAcursar = gradoAcursar;
            this.promedio = promedio;
            this.direccion = direccion;
            this.acudiente = acudiente;
        }


        public void matricularUnEstudiante(object Acudiente)
        {
            Console.Write("           Ingrese el id del estudiante: ");
            id = Console.ReadLine();
            Console.Write("           Ingrese el sexo del estudiante: ");
            sexo = Console.ReadLine();
            Console.Write("           Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();
            Console.Write("           Ingrese el grado a cursar del estudiante: ");
            gradoAcursar = Console.ReadLine();
            Console.Write("           Ingrese el promedio del estudiante: ");
            promedio = Console.ReadLine();
            Console.Write("           Ingrese la direccion de residencia del estudiante: ");
            direccion = Console.ReadLine();
            acudiente = Acudiente;
        }


        public void modificarDatosEstudiante(List<Estudiante> a)
        {

            string p = pasarId();

            foreach (Estudiante e in a)
            {
                if (p == e.id)
                {
                    Console.WriteLine("                                       -----------------------------Opciones--------------------------------");
                    Console.WriteLine("                                       1. Modificar ID");
                    Console.WriteLine("                                       2. Modificar Sexo");
                    Console.WriteLine("                                       3. Modificar Nombre");
                    Console.WriteLine("                                       4. Modificar Grado");
                    Console.WriteLine("                                       5. Modificar Promedio");
                    Console.WriteLine("                                       6. Modificar Direccion");
                    Console.Write("                                                 Ingrese la opcion del dato que desea modificar: ");

                    int m = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (m == 1)
                    {
                        Console.Write("                                                 Ingrese el nuevo id: ");
                        e.id = Console.ReadLine();
                    }
                    else if (m == 2)
                    {
                        Console.Write("                                                 Ingrese el nuevo Sexo : ");
                        e.sexo = Console.ReadLine();
                    }
                    else if (m == 3)
                    {
                        Console.Write("                                                 Ingrese el nuevo nombre : ");
                        e.nombre = Console.ReadLine();

                    }
                    else if (m == 4)
                    {
                        Console.Write("                                                 Ingrese el nuevo Grado : ");
                        e.gradoAcursar = Console.ReadLine();

                    }
                    else if (m == 5)
                    {
                        Console.Write("                                                 Ingrese el nuevo Promedio : ");
                        e.promedio = Console.ReadLine();

                    }
                    else if (m == 6)
                    {
                        Console.Write("                                                 Ingrese el nuevo Direccion :");
                        e.direccion = Console.ReadLine();

                    }
                    Console.WriteLine("");
                    Console.WriteLine("                                                 Modificación realizada con éxito");
                }
                else
                {
                    Console.WriteLine("No se encontró el Estudiante :(");
                }
                    
            }
        }
                    
        public string solicitarInfoEstudiante(List<Estudiante> a)
        {
            string c = pasarId();

            foreach (Estudiante e in a)
            {
                
                if (e.id == c)
                {
                    Console.WriteLine("\nLa información del estudiante con el ID " + e.id + " es: \nnombre: " +
                            e.nombre + " \nsexo: " + e.sexo + "\ngrado a cursar: " + e.gradoAcursar + "\nPromedio: " + e.promedio + "\ndireccion: " + e.direccion);
                    decoracion();
                }

            }
            return "El estudiante no se encuentra matriculado :(";
        }
        public string pasarId()
        {
            Console.Write("                                ingrese el ID del estudiante: ");
            string b = Console.ReadLine();
            Console.WriteLine("");
            return b;

        }
        public void decoracion()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
        }
        public object buscarEstudiante(List<Estudiante> a)
        {   
            string c = pasarId();
            Estudiante N = new Estudiante();

            foreach (Estudiante e in a)
            {
                if (e.id == c)
                {
                    return e;
                }
            }return N;
        }
            
                
            
    }
}
