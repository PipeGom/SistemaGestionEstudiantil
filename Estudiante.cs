using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEstudiantil
{
    internal class Estudiante: Program
    {
        public string id;
        public string sexo;
        public string nombre;
        public string gradoAcursar;
        public string promedio;
        public string direccion;



        public Estudiante(string id = "", string sexo = "", string nombre = "", string gradoAcursar = "",
                                               string promedio = "", string direccion = "")
        {

            this.id = id;
            this.sexo = sexo;
            this.nombre = nombre;
            this.gradoAcursar = gradoAcursar;
            this.promedio = promedio;
            this.direccion = direccion;

        }

        public void matricularUnEstudiante()
        {
            Console.WriteLine("Ingrese el id del estudiante: ");
            id = Console.ReadLine();
            Console.WriteLine("Ingrese el sexo del estudiante: ");
            sexo = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el grado a cursar del estudiante: ");
            gradoAcursar = Console.ReadLine();
            Console.WriteLine("Ingrese el promedio del estudiante: ");
            promedio = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion de residencia del estudiante: ");
            direccion = Console.ReadLine();

        }

        public void modificarDatos(List<Estudiante> b)
        {
            /*Console.WriteLine("--------------------Opciones-------------------------");
            Console.WriteLine("1. Modificar ID");
            Console.WriteLine("2. Modificar Sexo");
            Console.WriteLine("3. Modificar Nombre");
            Console.WriteLine("4. Modificar Grado");
            Console.WriteLine("5. Modificar Promedio");
            Console.WriteLine("6. Modificar Direccion");
            Console.WriteLine("7. Modificar Seguro social");
            Console.WriteLine("8. Modificar Fecha de Nacimiento");
            Console.WriteLine("9. Modificar Sede");
            Console.WriteLine("10. Modificar Condiciones especiales");*/

            Console.WriteLine("Ingrese el Id del estudiante que necesita modificar");
            string p= Console.ReadLine();
            foreach (Estudiante e in b)
            {
                if (p == e.id) 
                {
                    Console.WriteLine("1. Modificar el Id ");
                    Console.WriteLine("2. Modificar el nombre ");
                    Console.WriteLine("Ingrese la opcion del dato que desea modificar: ");
                    int m = int.Parse(Console.ReadLine());
                    if (m == 1)
                    {
                        Console.WriteLine("Ingrese el nuevo id:\n");
                        e.id = Console.ReadLine();
                    }
                    else if (m == 2) 
                    {
                        Console.WriteLine("Ingrese el nuevo nombre :\n");
                        e.nombre = Console.ReadLine();  
                    }
                }
            }


        }
        public string SolicitarInfo(List<Estudiante> b) 
        {
            Console.WriteLine("Ingrese el Id del estudiante que necesita Consultar");
            string j = Console.ReadLine();
   
            //Para buscar un atributo de un estudiante dentro de la lista 
            foreach (Estudiante e in b)
            {
                if (j == e.id)
                {
                    Console.WriteLine("El id del estudiante es: \n" + e.id + " sexo: \n" + e.sexo + " nombre: \n" +
                        e.nombre + " grado a cursar \n" + e.gradoAcursar + " Promedio \n" + e.promedio + " direccion \n" + e.direccion);
                }
            }
            return "El estudiante no se encuentra matriuculado :( ";
        }

       
    }
}
