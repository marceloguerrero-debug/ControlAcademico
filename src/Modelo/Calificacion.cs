using System;

namespace ControlAcademico.src.Modelo
{
    // Interfaz IEvaluable
    public interface IEvaluable
    {
        bool IsAprobado();
        string ObtenerEstado();
    }

    // Clase Calificación que implementa la interfaz
    public class Calificacion : IEvaluable
    {
        
        public int Id { get; set; }
        public Estudiante Alumno { get; set; }  
        public Curso Asignatura { get; set; }    
        public double Nota { get; set; }

        
        public Calificacion(int id, Estudiante alumno, Curso asignatura, double nota)
        {
            Id = id;
            Alumno = alumno;
            Asignatura = asignatura;
            
           
            if (nota < 0.0 || nota > 10.0)
            {
                throw new ArgumentException("La nota debe estar estrictamente entre 0.0 y 10.0");
            }
            Nota = nota;
        }

        // Métodos de la interfaz IEvaluable
        public bool IsAprobado()
        {
            return Nota >= 6.0; // Nota mínima de aprobación
        }

        public string ObtenerEstado()
        {
            return IsAprobado() ? "Aprobado" : "Reprobado";
        }

    
        public void MostrarDetalle()
        {
            Console.WriteLine($"ID: {Id} | Estudiante: {Alumno.Nombre} | Curso: {Asignatura.Nombre} | Nota: {Nota} [{ObtenerEstado()}]");
        }
    }
}
