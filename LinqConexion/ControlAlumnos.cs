using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConexion
{
    
    internal class ControlAlumnos
    {
        List<Carrera> carreras = new List<Carrera>();
        List<Alumno> alumnos = new List<Alumno>();

        public ControlAlumnos()
        {
            carreras.Add (new Carrera { idCarrera = 1, Nombre = "Ingenieria de Software"});
            carreras.Add(new Carrera { idCarrera = 2, Nombre = "Redes y Servicios de Computo" });
            carreras.Add(new Carrera { idCarrera = 3, Nombre = "Tecnologias Computacionales" });

            alumnos.Add(new Alumno { idAlumno = 1, nombre = "Juan Perez Sanchez", matricula = "s099932", promedio = 8.9, idCarrera = 1 });
            alumnos.Add(new Alumno
            {
                idAlumno = 2,
                nombre = "Maria Rodriguez Martinez",
                matricula = "s4324234",
                promedio = 9.2,
                idCarrera = 2
            });

            alumnos.Add(new Alumno
            {
                idAlumno = 3,
                nombre = "Jose Trellez Jimenez",
                matricula = "s2111111",
                promedio = 6.5,
                idCarrera = 2 
            });
        }

        public void ObtenerAlumnosPorCarrera(int idCarrera)
        {
            IEnumerable<Alumno> resultado = from alumno in alumnos
                                            where alumno.idCarrera == idCarrera
                                            select alumno;

            foreach (Alumno alumno in resultado)
            {
                alumno.getDatosAlumno();
            }
        }
        
        public void ObtenerAlumnosPorCarreraJoin(int idCarrera)
        {
            Alumno alumno1 = new Alumno();
            
            var query =
                from alumno in alumnos
                join carrera in carreras
                on alumno.idCarrera equals carrera.idCarrera
                where alumno.idCarrera == idCarrera
                select new
                {
                    nombreAlumno = alumno.nombre,
                    promedioAlumno = alumno.promedio,
                    idAlumno = alumno.idAlumno,
                    matriculaAlumno = alumno.matricula,
                    carreraAlumno = carrera.Nombre
                };

            foreach (var alumno in query)
            {
                alumno1.nombre = alumno.nombreAlumno;
                alumno1.matricula = alumno.matriculaAlumno;
                alumno1.promedio = alumno.promedioAlumno;
                alumno1.nombreCarrera = alumno.carreraAlumno;
                alumno1.getDatosAlumno();        
            }
        }
    }
}
