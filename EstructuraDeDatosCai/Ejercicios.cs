using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosCai
{
    class Ejercicios
    {

        /*1. Personas:

· Documento (requerido, 7-8 dígitos),

· Nombre (requerido, max. 30),

· Apellido (requerido, max. 30),

· Fecha de nacimiento (menor a la actual).*/
        
        

        
        public List<Persona> Personas = new List<Persona>();

        public void Crearpersonas()
        {
            int DNI;
            string Nombre;
            string Apellido;
            DateTime FechaNacimiento;
            string msj = "";

            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Por favor ingrese un documento: ");
                    DNI = Convert.ToInt32(Console.ReadLine());
                    if (DNI.ToString().Length > 8)
                    {
                        Console.WriteLine("Ingrese un numero menos a 8 digitos");
                        continue;
                    }
                    
                    if (DNI.ToString().Length < 7)
                    {
                        Console.WriteLine("Ingrese un numero mayor a 7 digitos");
                        continue;
                    }
                    break;                  
                }
                while (true)
                {
                    Console.WriteLine("Por favor ingrese un Nombre: ");
                    Nombre = Console.ReadLine();
                    if (Nombre.Length > 30)
                    {
                        Console.WriteLine("Ingrese un nombre con menos de 30 letras");
                        continue;
                    }
                    break ;
                    
                }
                while (true)
                {
                    Console.WriteLine("Por favor ingrese un Apellido: ");
                    Apellido = Console.ReadLine();
                    if (Apellido.Length > 30)
                    {
                        Console.WriteLine("Ingrese un apellido con menos de 30 letras");
                        continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("Por favor ingrese una fecha de nacimiento: ");
                    FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                    if (FechaNacimiento > DateTime.Today)
                    {
                        Console.WriteLine("debe ingresar una fecha menor a hoy");
                        continue;
                    }
                    break;
                    
                }

                Persona P = new Persona(DNI, Nombre, Apellido, FechaNacimiento);
                Personas.Add(P);
                break;
            }     

        }
    }
}
