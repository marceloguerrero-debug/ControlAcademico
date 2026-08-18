# Sistema de Control Académico

Proyecto de Cátedra — Fase 1 (DSP404, Universidad Don Bosco)

## Descripción

Sistema para el registro y control de estudiantes, docentes, cursos, matrículas y
calificaciones de una institución educativa. En esta primera fase se modelan las
clases principales del sistema en C# aplicando Programación Orientada a Objetos
(herencia, encapsulamiento y clases abstractas/interfaces), junto con un prototipo
funcional en consola. Más adelante, en la Fase 2, este mismo proyecto se ampliará
a una aplicación web completa en ASP.NET conectada a una base de datos.

## Tecnologías utilizadas

- C# (.NET Framework / .NET)
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
│       └── Persona.cs
├── wireframes/
│   └── pantalla-principal-dashboard.html
└── docs/
```

## Instrucciones de instalación y ejecución

1. Clonar el repositorio:
   ```
   git clone <URL-del-repositorio>
   ```
2. Abrir la carpeta `src/` en Visual Studio, o compilar desde la terminal:
   ```
   csc Program.cs Modelos/Persona.cs -out:ControlAcademico.exe
   ```
3. Ejecutar el archivo generado (`ControlAcademico.exe`) o presionar F5 en Visual Studio.

## Integrantes del equipo

| # | Integrante | Clase en C# | Pantalla UI/UX |
|---|------------|--------------|-----------------|
| 1 | Persona 1  | Persona (clase abstracta base) | Pantalla Principal / Dashboard |
| 2 | Persona 2  | Estudiante (hereda de Persona) | Pantalla de Listado |
| 3 | Persona 3  | Docente (hereda de Persona) | Pantalla de Formulario |
| 4 | Susana Nicole Valle Méndez. VM253306 | Curso | Interfaz IRegistrable| Pantalla de Detalle |
| 5 | Alessandra Guadalupe González Burgos. GB253116 | Matrícula (relación Estudiante–Curso) | Pantalla de Matrículas |
| 6 | Persona 6  | Calificación (implementa IEvaluable) | Pantalla de Calificaciones |

