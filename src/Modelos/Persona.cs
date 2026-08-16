using System;

namespace ControlAcademico.Modelos
{
    /// <summary>
    /// Clase abstracta base del sistema de Control Académico.
    /// Representa los datos y comportamientos comunes a cualquier
    /// persona dentro del sistema (Estudiante, Docente, etc.).
    /// Al ser abstracta, no se puede instanciar directamente:
    /// solo sirve como "molde" para que otras clases hereden de ella.
    /// </summary>
    public abstract class Persona
    {
        // ---------- Atributos (encapsulados con propiedades) ----------

        // Identificador único de la persona (carnet, DUI, código, etc.)
        public string Identificacion { get; set; }

        // Nombre completo de la persona
        public string Nombre { get; set; }

        // Correo electrónico de contacto
        public string Correo { get; set; }

        // Fecha de nacimiento, usada por ejemplo para calcular la edad
        public DateTime FechaNacimiento { get; set; }

        // ---------- Constructor ----------

        /// <summary>
        /// Constructor base: inicializa los atributos comunes.
        /// Las clases hijas (Estudiante, Docente) deben llamarlo
        /// usando ": base(...)" en su propio constructor.
        /// </summary>
        protected Persona(string identificacion, string nombre, string correo, DateTime fechaNacimiento)
        {
            // Validación básica de datos obligatorios (manejo de errores)
            if (string.IsNullOrWhiteSpace(identificacion))
                throw new ArgumentException("La identificación no puede estar vacía.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            Identificacion = identificacion;
            Nombre = nombre;
            Correo = correo;
            FechaNacimiento = fechaNacimiento;
        }

        // ---------- Métodos ----------

        /// <summary>
        /// Calcula la edad actual de la persona a partir de su fecha de nacimiento.
        /// Es un método común, por eso está implementado aquí y no es abstracto.
        /// </summary>
        public int ObtenerEdad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;

            // Si todavía no ha cumplido años este año, se resta 1
            if (FechaNacimiento.Date > DateTime.Now.AddYears(-edad))
                edad--;

            return edad;
        }

        /// <summary>
        /// Método abstracto: NO tiene cuerpo aquí porque cada tipo de
        /// persona (Estudiante, Docente) lo implementa de forma distinta.
        /// Esto es lo que obliga a las clases hijas a definir su propio
        /// comportamiento, cumpliendo con el principio de polimorfismo.
        /// </summary>
        public abstract string ObtenerRol();

        /// <summary>
        /// Devuelve un resumen en texto con la información básica.
        /// Las clases hijas pueden usar "override" para agregar más datos
        /// llamando a base.MostrarInformacion() y concatenando lo suyo.
        /// </summary>
        public virtual string MostrarInformacion()
        {
            return $"ID: {Identificacion} | Nombre: {Nombre} | Rol: {ObtenerRol()} | Edad: {ObtenerEdad()} años | Correo: {Correo}";
        }
    }
}
