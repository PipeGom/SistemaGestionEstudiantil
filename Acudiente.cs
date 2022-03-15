using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEstudiantil
{
    internal class Acudiente
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

        public void agregarAcudiente()
        {
            Console.Write("           Ingrese el id del acudiente: ");
            id = Console.ReadLine();
            Console.Write("           Ingrese el sexo del acudiente: ");
            sexo = Console.ReadLine();
            Console.Write("           Ingrese el nombre del acudiente: ");
            nombre = Console.ReadLine();
            Console.Write("           Ingrese el contacto del acudiente: ");
            contacto = Console.ReadLine();
            Console.Write("           Ingrese el parentezco del acudiente: ");
            parentezco = Console.ReadLine();
        }

        public void modificarDatosAcudiente(List<Acudiente> b)
        {
    
            Console.Write("\n                              Ingrese el Id del acudiente que necesita modificar: ");
            string p = Console.ReadLine();

            foreach (Acudiente e in b)
            {
                if (p == e.id)
                {
                    Console.WriteLine("-----------------------------Opciones--------------------------------");
                    Console.WriteLine("1. Modificar ID");
                    Console.WriteLine("2. Modificar Sexo");
                    Console.WriteLine("3. Modificar Nombre");
                    Console.WriteLine("4. Modificar Contacto");
                    Console.WriteLine("5. Modificar Parenteszco");
                    Console.Write("Ingrese la opcion del dato que desea modificar: ");

                    int m = int.Parse(Console.ReadLine());
                    if (m == 1)
                    {
                        Console.WriteLine("Ingrese el nuevo id:\n");
                        e.id = Console.ReadLine();
                    }
                    else if (m == 2)
                    {
                        Console.WriteLine("Ingrese el nuevo Sexo :\n");
                        e.sexo = Console.ReadLine();
                    }
                    else if (m == 3)
                    {
                        Console.WriteLine("Ingrese el nuevo Nombre :\n");
                        e.nombre = Console.ReadLine();
                    }
                    else if (m == 4)
                    {
                        Console.WriteLine("Ingrese el nuevo Contacto :\n");
                        e.contacto = Console.ReadLine();
                    }
                    else if (m == 5)
                    {
                        Console.WriteLine("Ingrese el nuevo Parentezco :\n");
                        e.parentezco = Console.ReadLine();
                    }
                  
                }
            }


        }

        public string solicitarInfoAcudiente(List<Acudiente> b)
        {
            Console.Write("\n                              Ingrese el Id del acudiente que necesita Consultar: ");
            string j = Console.ReadLine();

            //Para buscar un atributo de un estudiante dentro de la lista 
            foreach (Acudiente e in b)
            {
                if (j == e.id)
                {
                    Console.WriteLine("\n                                       El id del acudiente es: " + e.id + "\n                                       sexo: " + e.sexo + "\n                                       nombre: " +
                        e.nombre + "\n                                       contacto: " + "\n                                       parentezco: " + e.parentezco + "\n");
                }
            }
            return "                                       No se encontro el acudiente :( \n";
        }

        public object pasarAcudiente(List<Acudiente> b)
        {
            Console.Write("\n           Ingrese el Id del acudiente del estudiante: ");
            string j = Console.ReadLine();
            Console.WriteLine("");

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
