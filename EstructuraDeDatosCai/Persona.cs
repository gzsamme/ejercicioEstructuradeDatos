using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosCai
{
    public class Persona
    {
        int DNI { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        DateTime FechaNac { get; set; }

        public Persona()
        {

        }

        public Persona(int dni, string nombre, string apellido, DateTime fechanacimiento)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechanacimiento;
        }
    }
}
