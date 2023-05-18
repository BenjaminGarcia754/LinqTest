using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConexion
{
    internal class Alumno
    {

        public int idAlumno { get; set; }
        public string? nombre { get; set; }
        public string? matricula { get; set;}
        public double? promedio { get; set;}
        public int idCarrera { get; set; }
        public string? nombreCarrera { get; set; }

        public void GetDatosAlumno()
        {
            if (String.IsNullOrEmpty(nombreCarrera))
            {
                Console.WriteLine("Alumno: {0}\n con matricula: {1}\n y promedio: {2}\n " +
                    "en la carrera con ID: {3}", nombre, matricula, promedio, idCarrera);
            }
            else
            {
                Console.WriteLine("Alumno: {0}\n con matricula: {1}\n y promedio: {2}\n " +
                    "en la carrera con nombre: {3}", nombre, matricula, promedio, nombreCarrera);
            }
        }
   
    }
}
