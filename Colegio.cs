using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEstudiantil
{
    internal class Colegio
    {

        public string id;
        public string name;
        public string fechaDeNacimiento;
        public void menu()
        {
            Console.Write("----------Bienbenido al sistema de informacion de la institucion educativa Santa Pepita----------");
            Console.WriteLine("");
        
        }

        public void guardarDatos(string id,string name, string fechaDeNacimiento)
        {
               
            Console.
            this.id = Console.ReadLine();
            this.name = name;
            this.fechaDeNacimiento = fechaDeNacimiento;

        }


        public void consultarDatos(string id, string name, string fechaDeNacimiento) 
        { 
            
        
        }

        
    }
}
