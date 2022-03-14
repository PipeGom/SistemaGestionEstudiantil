using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEstudiantil
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Op;
            List<Estudiante> ListEstudiantes = new List<Estudiante>();
            Estudiante E = new Estudiante();

            List<Acudiente> ListAcudiente = new List<Acudiente>();
            Acudiente A = new Acudiente();


            do
            {
                Console.WriteLine("Bienvenido al sistema de Gestion de informacion de La institucion educativa santa Pepita\n");
                Console.WriteLine("1. Matricular un estudiante\n");
                Console.WriteLine("2. Gestionar la informacion de un estudiante\n");
                Console.WriteLine("Ingrese el numero de la opcion:\n");
                Op = int.Parse(Console.ReadLine());

                while (Op <= 0 || Op >= 3)
                {
                    Console.WriteLine("Solo puede escoger la opcion 1 o 2:");
                    Op = int.Parse(Console.ReadLine());
                }
                if (Op == 1)

                {
                    do
                    {
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                        A.AgregarAcudiente();
                        ListAcudiente.Add(new Acudiente(A.id, A.sexo, A.nombre, A.contacto, A.parentezco));
                        E.matricularUnEstudiante(A.PasarAcudiente(ListAcudiente));

                        //A.AgregarAcudiente();

                        // Se crea la lista de objetos para tener los estudiantes de manera dinamica
                        ListEstudiantes.Add(new Estudiante(E.id, E.sexo, E.nombre, E.gradoAcursar, E.promedio, E.direccion, E.acudiente));

                        Console.WriteLine("1. Desea ingresar un nuevo estudiante ");
                        Console.WriteLine("2. Desea gestionar la informacion de un estudiante");
                        Op = int.Parse(Console.ReadLine());

                    } while (Op == 1);

                    Console.WriteLine("Los Estudiantes matriculados son");

                    //Para buscar un atributo de un estudiante dentro de la lista esto
                    //servira para acceder a los atributos y posiblemente modificarlos para la gestion. 
                    foreach (Estudiante e in ListEstudiantes)
                    {
                        Console.WriteLine("\nEl id del estudiante es: " + e.id + "\nsexo: " + e.sexo + "\nnombre: " +
                            e.nombre + "\ngrado a cursar: " + e.gradoAcursar + "\nPromedio: " + e.promedio + "\ndireccion: " +
                            e.direccion + "\nacudiente: " + e.acudiente);
                        
                    }
                }

                
                if (Op == 2)

                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("1. Modificar informacion de un estudiante.");
                    Console.WriteLine("2. Solicitar info de un estudiante. ");
                    int p = int.Parse(Console.ReadLine());
                    if (p == 1)
                    {
                        E.modificarDatos(ListEstudiantes);
                    }
                    if (p == 2)

                    {
                        E.SolicitarInfo(ListEstudiantes);
                    }
                }

                Console.WriteLine("Se verifica la info");
                E.SolicitarInfo(ListEstudiantes);
                Console.ReadKey();
            }
            while (Op == 0);
            
        }


    }
}
