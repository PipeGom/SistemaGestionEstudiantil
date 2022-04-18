using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEstudiantil
{
    public class Acudiente
    {
        private string idAcudiente;
        private string sexoAcudiente;
        private string nombreAcudiente;
        private string contactoAcudiente;
        private string parentezcoAcudiente;


        public Acudiente(string id = "", string sexo = "", string nombre = "", string contacto = "", string parentezco = "")
        {

            this.IdAcudiente = id;
            this.SexoAcudiente = sexo;
            this.NombreAcudiente = nombre;
            this.ContactoAcudiente = contacto;
            this.ParentezcoAcudiente = parentezco;
        }

        public string IdAcudiente { get => idAcudiente; set => idAcudiente = value; }
        public string SexoAcudiente { get => sexoAcudiente; set => sexoAcudiente = value; }
        public string NombreAcudiente { get => nombreAcudiente; set => nombreAcudiente = value; }
        public string ContactoAcudiente { get => contactoAcudiente; set => contactoAcudiente = value; }
        public string ParentezcoAcudiente { get => parentezcoAcudiente; set => parentezcoAcudiente = value; }

        public void modificarDatosAcudiente(List<Estudiante> b)
        {
    
            Console.Write("\n                              Ingrese el Id del acudiente que necesita modificar: ");
            string p = Console.ReadLine();

            foreach (Estudiante e in b)
            {
                if (p == e.Id)  
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
                        e.IdAcudiente = Console.ReadLine();
                    }
                    else if (m == 2)
                    {
                        Console.WriteLine("Ingrese el nuevo Sexo :\n");
                        e.SexoAcudiente = Console.ReadLine();
                    }
                    else if (m == 3)
                    {
                        Console.WriteLine("Ingrese el nuevo Nombre :\n");
                        e.NombreAcudiente = Console.ReadLine();
                    }
                    else if (m == 4)
                    {
                        Console.WriteLine("Ingrese el nuevo Contacto :\n");
                        e.ContactoAcudiente = Console.ReadLine();
                    }
                    else if (m == 5)
                    {
                        Console.WriteLine("Ingrese el nuevo Parentezco :\n");
                        e.ParentezcoAcudiente = Console.ReadLine();
                    }
                  
                }
            }


        }

        public string solicitarInfoAcudiente(List<Estudiante> b)
        {
            Console.Write("\n                              Ingrese el Id del Estudiante para conocer su respectivo acudiente: ");
            string j = Console.ReadLine();

            //Para buscar un atributo de un estudiante dentro de la lista 
            foreach (Estudiante e in b)
            {
                if (j == e.Id)
                {
                    Console.WriteLine("\n                                       El id del acudiente es: " + e.IdAcudiente + "\n                                       sexo: " + e.SexoAcudiente + "\n                                       nombre: " +
                        e.NombreAcudiente + "\n                                       contacto: " + "\n                                       parentezco: " + e.ParentezcoAcudiente + "\n");
                }
            }
            return "                                       No se encontro el acudiente :( \n";
        }

        
    }
}
