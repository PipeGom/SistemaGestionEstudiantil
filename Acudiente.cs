using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEstudiantil
{
    internal class Acudiente : Program
    {
        public string id;
        public string sexo;
        public string nombre;
        public string contacto;
        public string parentezco;


        public Acudiente(string id = "", string sexo = "", string nombre = "", string contacto = "", string parentezco = "")
        {

            this.id = id;
            this.sexo = sexo;
            this.nombre = nombre;
            this.contacto = contacto;
            this.parentezco = parentezco;
        }

        public void AgregarAcudiente()
        {
            Console.WriteLine("Ingrese el id del acudiente: ");
            id = Console.ReadLine();
            Console.WriteLine("Ingrese el sexo del acudiente: ");
            sexo = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del acudiente: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el contacto del acudiente: ");
            contacto = Console.ReadLine();
            Console.WriteLine("Ingrese el parentezco del acudiente: ");
            parentezco = Console.ReadLine();
        }

        public void modificarDatos(List<Acudiente> b)
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

            Console.WriteLine("Ingrese el Id del acudiente que necesita modificar");
            string p = Console.ReadLine();
            foreach (Acudiente e in b)
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
        public string SolicitarInfo(List<Acudiente> b)
        {
            Console.WriteLine("Ingrese el Id del acudiente que necesita Consultar");
            string j = Console.ReadLine();

            //Para buscar un atributo de un estudiante dentro de la lista 
            foreach (Acudiente e in b)
            {
                if (j == e.id)
                {
                    Console.WriteLine("El id del acudiente es: \n" + e.id + " sexo: \n" + e.sexo + " nombre: \n" +
                        e.nombre + " contacto: \n" + " parentezco: \n");
                }
            }
            return "No se encontro el acudiente :( ";
        }
        public object PasarAcudiente(List<Acudiente> b)
        {
            Console.WriteLine("Ingrese el Id del acudiente que necesita buscar: ");
            string j = Console.ReadLine();

            //Para buscar un atributo de un estudiante dentro de la lista 
            foreach (Acudiente e in b)
            {
                if (j == e.id)
                {
                    return e;
                }
            }
            return "No se encontro el acudiente (*/ω＼*) ";
        }


    }
}

