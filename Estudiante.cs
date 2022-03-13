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
                                               string promedio = "", string direccion = "", List<Estudiante> lista = new List<Estudiante>())
        {

            this.id = id;
            this.sexo = sexo;
            this.nombre = nombre;
            this.gradoAcursar = gradoAcursar;
            this.promedio = promedio;
            this.direccion = direccion;
            this.lista = 

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
        public void modificarDatos()
        {
            Console.WriteLine("--------------------Opciones-------------------------");
            Console.WriteLine("1. Modificar ID");
            Console.WriteLine("2. Modificar Sexo");
            Console.WriteLine("3. Modificar Nombre");
            Console.WriteLine("4. Modificar Grado");
            Console.WriteLine("5. Modificar Promedio");
            Console.WriteLine("6. Modificar Direccion");
            Console.WriteLine("7. Modificar Seguro social");
            Console.WriteLine("8. Modificar Fecha de Nacimiento");
            Console.WriteLine("9. Modificar Sede");
            Console.WriteLine("10. Modificar Condiciones especiales");


            int Op = int.Parse(Console.ReadLine());
            while (Op < 1 || Op > 6);
                Console.WriteLine("Opcion no valida");
                Op = int.Parse(Console.ReadLine());

            if (Op == 1)
            {
                this.id = Console.ReadLine();
            }
            if (Op == 2)
            {
                this.sexo = Console.ReadLine();
            }
            if(Op == 3)
            {
                this.nombre = Console.ReadLine();
            }
            if (Op == 4)
            {
                this.gradoAcursar = Console.ReadLine();
            }
            if (Op == 5)
            {
                this.promedio = Console.ReadLine();
            }
            if (Op == 6)
            {
                this.direccion = Console.ReadLine();
            }



        }
        public object BuscarEstudiante(List<Estudiante> a)
        {
            foreach (Estudiante e in ListEstudiantes)
        }
       
    }
}
