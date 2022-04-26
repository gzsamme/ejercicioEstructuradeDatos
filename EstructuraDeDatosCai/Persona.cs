using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosCai
{
    internal class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        

        public Persona(int dni, string nombre, string apellido, DateTime fechanacimiento)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechanacimiento;
        }


    }
}
