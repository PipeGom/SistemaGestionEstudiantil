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
                        E.matricularUnEstudiante();

                        // Se crea la lista de objetos para tener los estudiantes de manera dinamica
                        ListEstudiantes.Add(new Estudiante(E.id, E.sexo, E.nombre, E.gradoAcursar, E.promedio, E.direccion));

                        Console.WriteLine("Si desea matricular otro estudiante ingrese 1 de lo contrario ingrese 2:");
                        Op = int.Parse(Console.ReadLine());

                    } while (Op == 1);

                    Console.WriteLine("Los Estudiantes matriculados son");

                    //Para buscar un atributo de un estudiante dentro de la lista esto
                    //servira para acceder a los atributos y posiblemente modificarlos para la gestion. 
                    foreach (Estudiante e in ListEstudiantes)
                    {
                        Console.WriteLine("\nEl id del estudiante es: " + e.id + "\nsexo: " + e.sexo + "\nnombre: " +
                            e.nombre + "\ngrado a cursar: " + e.gradoAcursar + "\nPromedio: " + e.promedio + "\ndireccion: " + e.direccion);
                    }
                }
                if (Op == 2)

                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------");




                }

                Console.WriteLine("Desea conocer el id del estudiante matriculado?\n");



                Console.ReadKey();

            }
            while (Op == 0);

        }


    }
}
