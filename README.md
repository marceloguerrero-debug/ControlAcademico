[README.md](https://github.com/user-attachments/files/31201305/README.md)
# Sistema de Control Académico

Proyecto de Cátedra — Fase 1 (DSP404, Universidad Don Bosco)

## Descripción

Sistema para el registro y control de estudiantes, docentes, cursos, matrículas y
calificaciones de una institución educativa. En esta primera fase se modelan las
clases principales del sistema en C# aplicando Programación Orientada a Objetos
(herencia, encapsulamiento, clase abstracta e interfaces), junto con un prototipo
funcional en consola. Más adelante, en la Fase 2, este mismo proyecto se ampliará
a una aplicación web completa en ASP.NET conectada a una base de datos.

## Tecnologías utilizadas

- C# (.NET Framework)
- Consola (prototipo Fase 1)
- Colecciones genéricas (`List<T>`)
- Git / GitHub

## Estructura del proyecto

```
ControlAcademico/
├── README.md
├── src/
│   ├── Program.cs
│   └── Modelos/
│       ├── Persona.cs        (clase abstracta base)
│       ├── Estudiante.cs     (hereda de Persona)
│       ├── Docente.cs        (hereda de Persona)
│       ├── Curso.cs          (implementa IRegistrable)
│       ├── IRegistrable.cs
│       ├── Matricula.cs      (relación Estudiante-Curso)
│       └── Calificacion.cs   (implementa IEvaluable)
├── wireframes/
│   ├── pantalla-principal-dashboard.html
│   ├── pantalla-detalle-curso.html
│   ├── pantalla-matriculas.html
│   └── pantalla-calificaciones.html
└── docs/
    └── diagrama_clases_matricula.png
```

## Instrucciones de instalación y ejecución

1. Clonar el repositorio:
   ```
   git clone https://github.com/marceloguerrero-debug/ControlAcademico.git
   ```
2. Abrir la carpeta `src/` en Visual Studio como proyecto de consola (.NET Framework 4.8),
   o compilar desde la terminal:
   ```
   csc Program.cs Modelos/*.cs -out:ControlAcademico.exe
   ```
3. Ejecutar el archivo generado (`ControlAcademico.exe`) o presionar F5 en Visual Studio.

## Integrantes del equipo

| # | Integrante | Clase en C# | Pantalla UI/UX |
|---|------------|--------------|-----------------|
| 1 | Marcelo Eduardo Guerrero Rodriguez - GR241968  | Persona (clase abstracta base) | Pantalla Principal / Dashboard |
| 2 | Persona 2 (Daniela Ramos) | Estudiante (hereda de Persona) | Pantalla de Listado |
| 3 | José Miguel Sosa Ayala - SA251597  | Docente (hereda de Persona) | Pantalla de Formulario |
| 4 | Persona 4  | Curso | Pantalla de Detalle |
| 5 | Alessandra Guadalupe González Burgos - GB253116  | Matrícula (relación Estudiante–Curso) | Pantalla de Matrículas |
| 6 | Alessandra Guadalupe González Burgos - GB253116  | Calificación (implementa IEvaluable) | Pantalla de Calificaciones |
