using System;
using System.Collections.Generic;
using ControlAcademico.Modelos;

namespace ControlAcademico
{
    /// <summary>
    /// Clase de ejemplo TEMPORAL, solo para demostrar que "Persona"
    /// funciona correctamente (recordar que es abstracta y no se
    /// puede instanciar directamente).
    ///
    /// IMPORTANTE: Esta clase la deben reemplazar los compañeros que
    /// implementan "Estudiante" y "Docente" (Persona 2 y Persona 3),
    /// ya que ellos heredan de Persona con sus propios atributos.
    /// Se deja aquí únicamente para probar el prototipo de la Fase 1.
    /// </summary>
    internal class PersonaDemo : Persona
    {
        public PersonaDemo(string id, string nombre, string correo, DateTime fechaNacimiento)
            : base(id, nombre, correo, fechaNacimiento)
        {
        }

        // Implementación obligatoria del método abstracto ObtenerRol()
        public override string ObtenerRol() => "Persona (demo)";
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Prototipo Fase 1 - Sistema de Control Académico ===\n");

            // Lista genérica (List<T>) que guarda los objetos en memoria,
            // tal como lo pide la Fase 1 (sin base de datos todavía).
            List<Persona> personas = new List<Persona>();

            try
            {
                // Se crean algunos objetos de prueba usando la clase demo.
                // Cuando el equipo agregue Estudiante y Docente, se agregan
                // aquí de la misma forma: personas.Add(new Estudiante(...));
                personas.Add(new PersonaDemo("CT-0001", "Mario Pérez", "mario@udb.edu.sv", new DateTime(2001, 5, 12)));
                personas.Add(new PersonaDemo("CT-0002", "Ana López", "ana@udb.edu.sv", new DateTime(1999, 11, 3)));

                // Listar todos los objetos creados (comportamiento que
                // luego tendrá la pantalla de Listado en la app web)
                Console.WriteLine("Listado de personas registradas:");
                foreach (Persona p in personas)
                {
                    Console.WriteLine(" - " + p.MostrarInformacion());
                }

                // Buscar una persona por identificación (simula la
                // pantalla de Detalle)
                Console.WriteLine("\nBuscar persona por identificación (ej: CT-0001):");
                string idBuscada = Console.ReadLine();

                Persona encontrada = personas.Find(p => p.Identificacion == idBuscada);

                if (encontrada != null)
                    Console.WriteLine("Encontrado -> " + encontrada.MostrarInformacion());
                else
                    Console.WriteLine("No se encontró ninguna persona con esa identificación.");
            }
            catch (Exception ex)
            {
                // Manejo de errores solicitado en la Fase 1
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
