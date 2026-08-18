namespace ControlAcademico.Modelos
{
    public class Docente : Persona
    {
        public string CodigoEmpleado { get; set; }
        public string Especialidad { get; set; }

        public Docente()
        {
        }

        public Docente(int id, string nombre, string apellido, string codigoEmpleado, string especialidad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            CodigoEmpleado = codigoEmpleado;
            Especialidad = especialidad;
        }
    }
}
