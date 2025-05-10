
# API de Biblioteca - ASP.NET Core Web API

Este proyecto es una API RESTful desarrollada con **ASP.NET Core** que permite gestionar una biblioteca de libros y autores.

---

## Tecnologias usadas

- ASP.NET Core 7
- Entity Framework Core
- SQL Server (LocalDB)
- Postman
- Visual Studio 2022

---

## Estructura del Proyecto

```
BibloitecaAPI/
├── Controllers/
│   ├── AutoresController.cs
│   └── LibrosController.cs
├── Datos/
│   └── AplicationDbContext.cs
├── Entidades/
│   ├── Autor.cs
│   └── Libro.cs
├── Program.cs
└── appsettings.json
```

---

## Endpoints principales

### Autores

- `GET /api/autores` - Lista todos los autores
- `GET /api/autores/{id}` - Obtiene autor por ID (incluye libros)
- `POST /api/autores` - Crea un nuevo autor
- `PUT /api/autores/{id}` - Actualiza un autor existente
- `DELETE /api/autores/{id}` - Elimina un autor

### Libros

- `GET /api/libros` - Lista todos los libros
- `GET /api/libros/{id}` - Obtiene libro por ID (incluye autor)
- `POST /api/libros` - Crea un nuevo libro
- `PUT /api/libros/{id}` - Actualiza un libro existente
- `DELETE /api/libros/{id}` - Elimina un libro

---

## Configuración

1. Clonar el repositorio:
```bash
git clone https://github.com/jdabid/BibloitecaAPI_net.git
```

2. Crear la base de datos usando migraciones:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

3. Ejecutar el proyecto desde Visual Studio o terminal:
```bash
dotnet run
```

4. Probar la API Postman

---

## Conceptos aplicados

- Patrón REST
- Relación uno a muchos (Autor - Libros)
- Inyección de dependencias
- Uso de DbContext con EF Core
- Serialización JSON

---

## Estado del proyecto

Completado para CRUD básico  
Futuras mejoras: autenticación, validaciones, AutoMapper

---

## Contribuciones

Este proyecto fue realizado como parte de un portafolio de desarrollador .NET junior.  
¡Se aceptan sugerencias y mejoras!

