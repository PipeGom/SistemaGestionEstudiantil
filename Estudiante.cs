using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEstudiantil
{
    internal class Estudiante
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
            Console.WriteLine("Ingrese el id del estudiante");
            id = Console.ReadLine();
            Console.WriteLine("Ingrese el sexo del estudiante");
            sexo = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del estudiante");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el grado a cursar del estudiante");
            gradoAcursar = Console.ReadLine();
            Console.WriteLine("Ingrese el promedio del estudiante");
            promedio = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion de residencia del estudiante");
            direccion = Console.ReadLine();



        }

}    }
