# ⚽ Sistema de Gestión de Liga de Fútbol - C#

## 📌 Descripción

Este proyecto es una aplicación de consola desarrollada en **C#**, enfocada en la gestión integral de una liga de fútbol. Incluye funcionalidades completas como la creación de torneos, registro de equipos y jugadores, control de transferencias y generación de estadísticas.

El sistema ha sido diseñado con un enfoque **modular, mantenible y escalable**, aplicando:

- ✅ **Principios SOLID**
- ✅ **LINQ** para consultas y transformaciones de datos.
- ✅ **Arquitectura Hexagonal (puertos y adaptadores)**
- ✅ **Vertical Slicing** (estructura por funcionalidad/feature)

Esto garantiza una separación clara de responsabilidades, independencia entre capas y facilidad para pruebas y mantenimiento.

---

## 📋 Funcionalidades Principales

- **🏆 Torneos**
  - Crear, buscar, actualizar y eliminar torneos.

- **👤 Jugadores**
  - Registrar, buscar, editar y eliminar jugadores.

- **🏟️ Equipos y Personal**
  - Registrar equipos, cuerpo técnico y cuota médica.
  - Inscribir equipos en torneos.
  - Gestionar notificaciones de transferencia.

- **🔁 Transferencias**
  - Soporte para compra y préstamo de jugadores.

- **📊 Estadísticas**
  - Consultar jugadores con más asistencias.
  - Ver equipos con más goles en contra.
  - Listar jugadores más costosos.
  - Evaluar efectividad de jugadores por equipo.

- **🧭 Navegación**
  - Todos los módulos permiten regresar al menú principal.

---

## 🛠️ Tecnologías y Principios

- **Lenguaje**: C#
- **Plataforma**: .NET Console Application
- **Paradigmas y prácticas utilizadas**:
  - Principios **SOLID**
  - **LINQ**
  - **Arquitectura Hexagonal**
  - **Vertical Slicing** por módulos (features)

---

## 🚀 Cómo Ejecutar

1. Clona este repositorio:

   ```bash
   https://github.com/AndresFForeroP/Liga-Futbol.git
   
2. Abre el proyecto en tu IDE preferido.

3. Ejecuta en el terminal: dotnet run

4. Navega a través del menú de consola.

## 📂 Estructura del Proyecto (opcional)

```
/Liga-Futbol
├── Program.cs
├── Features/
│   └── Torneos/
│       ├── Domain/
│       ├── Application/
│       ├── Infrastructure/
│   └── Jugadores/
│       └── Domain/
│       └── ...
├── bin/
├── obj/
├── Liga-Fut.csproj
└── Liga-Fut.sln
```

## 👥 Autor

- **Andrés Felipe Forero Perez**
- Campuslands bucaramanga
- Curso: C#
- Año: 2025

## 📄 Licencia

Este proyecto es de uso académico.