using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEstudiantil
{
    internal class Estudiante : Acudiente
    {
        private string id;
        private string sexo;
        private string nombre;
        private string gradoAcursar;
        private string promedio;
        private string direccion;
        public Acudiente acudiente;

        public string Id { get => id; set => id = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string GradoAcursar { get => gradoAcursar; set => gradoAcursar = value; }
        public string Promedio { get => promedio; set => promedio = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public Estudiante(string id= "", string sexo = "", string nombre = "", string gradoAcursar = "",
                                               string promedio = "", string direccion = "", string nombreAcum = "", string idAcum = "", string sexoAcum = "", string contactoAcum = "",  string parentezcoAcum = "", Acudiente acudiente = null)
        {
            this.Id = id;
            this.Sexo = sexo;
            this.Nombre = nombre;
            this.GradoAcursar = gradoAcursar;
            this.Promedio = promedio;
            this.Direccion = direccion;
            this.NombreAcudiente = nombreAcum;
            this.IdAcudiente = idAcum;
            this.SexoAcudiente = sexoAcum;
            this.ContactoAcudiente = contactoAcum;
            this.ParentezcoAcudiente = parentezcoAcum;
            this.acudiente = new Acudiente(nombreAcum, idAcum, sexoAcum, contactoAcum, parentezcoAcum);
        }


        public void matricularUnEstudiante()
        {
            Console.Write("           Ingrese el id del estudiante: ");
            Id = Console.ReadLine();
            Console.Write("           Ingrese el sexo del estudiante: ");
            Sexo = Console.ReadLine();
            Console.Write("           Ingrese el nombre del estudiante: ");
            Nombre = Console.ReadLine();
            Console.Write("           Ingrese el grado a cursar del estudiante: ");
            GradoAcursar = Console.ReadLine();
            Console.Write("           Ingrese el promedio del estudiante: ");
            Promedio = Console.ReadLine();
            Console.Write("           Ingrese la direccion de residencia del estudiante: ");
            Direccion = Console.ReadLine();

            Console.WriteLine("\n           Informacion del acudiente del estudiante\n");

            Console.Write("           Ingrese el nombre del acudiente: ");
            NombreAcudiente = Console.ReadLine();
            Console.Write("           Ingrese el id del acudiente: ");
            IdAcudiente = Console.ReadLine();
            Console.Write("           Ingrese el sexo del acudiente: ");
            SexoAcudiente = Console.ReadLine();
            Console.Write("           Ingrese el contacto del acudiente: ");
            ContactoAcudiente = Console.ReadLine();
            Console.Write("           Ingrese el parentezco del acudiente: ");
            ParentezcoAcudiente = Console.ReadLine();

            acudiente = new Acudiente(NombreAcudiente, IdAcudiente, SexoAcudiente, ContactoAcudiente, ParentezcoAcudiente);



        }


        public void modificarDatosEstudiante(List<Estudiante> a)
        {

            string p = pasarId();

            foreach (Estudiante e in a)
            {
                if (p == e.Id)
                {
                    Console.WriteLine("\t-----------------------------Opciones--------------------------------");
                    Console.WriteLine("\t\t1. Modificar ID");
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
                        e.Id = Console.ReadLine();
                    }
                    else if (m == 2)
                    {
                        Console.Write("                                                 Ingrese el nuevo Sexo : ");
                        e.Sexo = Console.ReadLine();
                    }
                    else if (m == 3)
                    {
                        Console.Write("                                                 Ingrese el nuevo nombre : ");
                        e.Nombre = Console.ReadLine();

                    }
                    else if (m == 4)
                    {
                        Console.Write("                                                 Ingrese el nuevo Grado : ");
                        e.GradoAcursar = Console.ReadLine();

                    }
                    else if (m == 5)
                    {
                        Console.Write("                                                 Ingrese el nuevo Promedio : ");
                        e.Promedio = Console.ReadLine();

                    }
                    else if (m == 6)
                    {
                        Console.Write("                                                 Ingrese el nuevo Direccion :");
                        e.Direccion = Console.ReadLine();

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
                
                if (e.Id == c)
                {
                    Console.WriteLine("\nLa información del estudiante con el ID " + e.Id + " es: \nnombre: " +
                            e.Nombre + " \nsexo: " + e.Sexo + "\ngrado a cursar: " + e.GradoAcursar + "\nPromedio: " + e.Promedio + "\ndireccion: " + e.Direccion);
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
                if (e.Id == c)
                {
                    return e;
                }
            }return N;
        }
            
                
            
    }
}
