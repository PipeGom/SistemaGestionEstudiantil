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
            int Ap;
            List<Estudiante> ListEstudiantes = new List<Estudiante>();
            Estudiante E = new Estudiante();

            List<Acudiente> ListAcudiente = new List<Acudiente>();
            Acudiente A = new Acudiente();


            do
            {
                Console.WriteLine("-----------------Bienvenido al sistema de Gestion de informacion de La institucion educativa santa Pepita--------------\n");
                Console.WriteLine("1. Matricular un estudiante");
                Console.WriteLine("2. Gestionar la informacion de un estudiante");
                Console.WriteLine("3. Gestionar la informacion de un Acudiente\n");
                Console.Write("Ingrese el numero de la opcion: ");
                Op = int.Parse(Console.ReadLine());


                while (Op <= 0 || Op >= 4)
                {
                    Console.WriteLine("Solo puede escoger la opcion 1, 2 o 3:");
                    Op = int.Parse(Console.ReadLine());
                }

                if (Op == 1)

                {
                    do
                    {
                        E.decoracion(); 
                        A.agregarAcudiente();
                        ListAcudiente.Add(new Acudiente(A.id, A.sexo, A.nombre, A.contacto, A.parentezco));
                        E.matricularUnEstudiante(A.pasarAcudiente(ListAcudiente));
                        Console.WriteLine("\n                     Estudiante registrado con éxito \n");

                        // Se crea la lista de objetos para tener los estudiantes de manera dinamica
                        ListEstudiantes.Add(new Estudiante(E.id, E.sexo, E.nombre, E.gradoAcursar, E.promedio, E.direccion, E.acudiente));

                        Console.WriteLine("                     -----------------------------Opciones--------------------------------");
                        Console.WriteLine("                     1.Desea ingresar un nuevo estudiante ");
                        Console.WriteLine("                     2.Desea gestionar la informacion de un estudiante ");
                        Console.WriteLine("                     3.Desea gestionar la informacion de un Acudiente \n");
                        Console.Write("                     Ingrese el numero de la opcion que desea realizar: ");
                        Op = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                    } while (Op == 1);

                    Console.WriteLine("Los Estudiantes matriculados son: ");

                    //Para buscar un atributo de un estudiante dentro de la lista esto
                    //servira para acceder a los atributos y posiblemente modificarlos para la gestion. 
                    foreach (Estudiante e in ListEstudiantes)
                    {
                        Console.WriteLine("\nEl id del estudiante es: " + e.id + "\nsexo: " + e.sexo + "\nnombre: " +
                            e.nombre + "\ngrado a cursar: " + e.gradoAcursar + "\nPromedio: " + e.promedio + "\ndireccion: " + e.direccion + "\nacudiente: " + e.acudiente);
                    }
                }
                if(Op == 2)

                {
                    Console.WriteLine("-----------------------------Opciones--------------------------------");
                    Console.WriteLine("           1. Modificar informacion del estudiante");
                    Console.WriteLine("           2. Solicitar informacion del estudiante\n");
                    Console.Write("                     Ingrese el numero de la opcion: ");
                    Ap = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (Ap == 1)
                    {

                        E.modificarDatosEstudiante(ListEstudiantes);
                    }
                    else if (Ap == 2)
                    {
                        E.solicitarInfoEstudiante(ListEstudiantes);
                    }
                   
                }
                if (Op == 3)

                {
                    Console.WriteLine("-----------------------------Opciones--------------------------------");
                    Console.WriteLine("            1. Modificar informacion del Acudiente");
                    Console.WriteLine("            2. Solicitar informacion del Acudiente\n");
                    Console.Write("                      Ingrese el numero de la opcion: ");
                    Ap = int.Parse(Console.ReadLine());
                    if (Ap == 1)
                    {
                        A.modificarDatosAcudiente(ListAcudiente);
                    }
                    else if (Ap == 2)
                    {
                        A.solicitarInfoAcudiente(ListAcudiente);
                    }

                }


            }
            while (true);
            Console.ReadKey();
        }
    }
}
