using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAcademico.Modelos
{
    /// <summary>
    /// Representa a un Estudiante dentro del sistema de Control Académico.
    /// Hereda de la clase abstracta base Persona (creada por Persona 1).
    /// Desarrollado por: Persona 2
    /// </summary>
    public class Estudiante : Persona
    {
        // ==========================================
        // PROPIEDADES ESPECÍFICAS DE ESTUDIANTE
        // ==========================================

        /// <summary>
        /// Código único o número de carnet del estudiante (ej. DR22001).
        /// </summary>
        public string Carnet { get; set; }

        /// <summary>
        /// Nombre de la carrera universitaria que cursa el estudiante.
        /// </summary>
        public string Carrera { get; set; }

        /// <summary>
        /// Facultad a la que pertenece la carrera.
        /// </summary>
        public string Facultad { get; set; }

        /// <summary>
        /// Ciclo o semestre académico actual (1 al 10+).
        /// </summary>
        public int CicloActual { get; set; }

        /// <summary>
        /// Coeficiente de Unidades de Mérito (CUM) o Promedio Ponderado (0.0 - 10.0).
        /// </summary>
        public double CUM { get; set; }

        /// <summary>
        /// Estado académico ("Activo", "Inactivo", "Egresado", "En Riesgo").
        /// </summary>
        public string EstadoAcademico { get; set; }

        /// <summary>
        /// Cantidad de créditos académicos aprobados.
        /// </summary>
        public int CreditosAprobados { get; set; }

        /// <summary>
        /// Lista de materias/asignaturas inscritas en el ciclo en curso.
        /// </summary>
        public List<string> MateriasInscritas { get; set; }

        // ==========================================
        // CONSTRUCTORES
        // ==========================================

        public Estudiante() : base()
        {
            MateriasInscritas = new List<string>();
            EstadoAcademico = "Activo";
            CicloActual = 1;
            CUM = 0.0;
            CreditosAprobados = 0;
        }

        public Estudiante(
            int id,
            string nombres,
            string apellidos,
            string email,
            string telefono,
            DateTime fechaNacimiento,
            string carnet,
            string carrera,
            string facultad,
            int cicloActual = 1,
            double cum = 0.0)
            : base(id, nombres, apellidos, email, telefono, fechaNacimiento)
        {
            if (string.IsNullOrWhiteSpace(carnet))
                throw new ArgumentException("El carnet del estudiante no puede estar vacío.", nameof(carnet));

            Carnet = carnet.Trim().ToUpper();
            Carrera = carrera;
            Facultad = facultad;
            CicloActual = cicloActual > 0 ? cicloActual : 1;
            CUM = Math.Max(0.0, Math.Min(10.0, cum));
            EstadoAcademico = CUM < 6.0 && CUM > 0 ? "En Riesgo" : "Activo";
            CreditosAprobados = 0;
            MateriasInscritas = new List<string>();
        }

        // ==========================================
        // MÉTODOS DE LA CLASE ESTUDIANTE
        // ==========================================

        public bool InscribirMateria(string codigoMateria)
        {
            if (string.IsNullOrWhiteSpace(codigoMateria))
                return false;

            string materia = codigoMateria.Trim();
            if (!MateriasInscritas.Contains(materia))
            {
                MateriasInscritas.Add(materia);
                return true;
            }
            return false;
        }

        public bool RetirarMateria(string codigoMateria)
        {
            return MateriasInscritas.Remove(codigoMateria.Trim());
        }

        public void ActualizarCUM(double nuevoCum)
        {
            CUM = Math.Max(0.0, Math.Min(10.0, nuevoCum));
            if (CUM < 6.0 && EstadoAcademico == "Activo")
                EstadoAcademico = "En Riesgo";
            else if (CUM >= 6.0 && EstadoAcademico == "En Riesgo")
                EstadoAcademico = "Activo";
        }

        public bool VerificarEgresado(int creditosTotalesCarrera = 160)
        {
            if (CreditosAprobados >= creditosTotalesCarrera)
            {
                EstadoAcademico = "Egresado";
                return true;
            }
            return false;
        }

        // ==========================================
        // POLIMORFISMO: SOBRESCRITURA DE MÉTODOS
        // ==========================================

        public override void MostrarInformacion()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"🎓 FICHA DE ESTUDIANTE - {Carnet}");
            Console.WriteLine("==================================================");
            Console.WriteLine($"Nombre Completo : {ObtenerNombreCompleto()}");
            Console.WriteLine($"Carnet          : {Carnet}");
            Console.WriteLine($"Carrera         : {Carrera}");
            Console.WriteLine($"Facultad        : {Facultad}");
            Console.WriteLine($"Ciclo Actual    : {CicloActual}");
            Console.WriteLine($"CUM / Promedio  : {CUM:F2} / 10.00");
            Console.WriteLine($"Estado Académico: {EstadoAcademico}");
            Console.WriteLine($"Correo Inst.    : {Email}");
            Console.WriteLine($"Teléfono        : {Telefono}");
            Console.WriteLine($"Materias ({MateriasInscritas.Count}): {(MateriasInscritas.Count > 0 ? string.Join(", ", MateriasInscritas) : "Ninguna inscrita")}");
            Console.WriteLine("==================================================");
        }

        public override string ToString()
        {
            return $"[{Carnet}] {ObtenerNombreCompleto()} - {Carrera} (CUM: {CUM:F2} | {EstadoAcademico})";
        }
    }
}