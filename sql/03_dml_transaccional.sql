-- =============================================================================
-- CONSULTAS TRANSACCIONALES (DML) UTILIZADAS EN WINDOWS FORMS
-- =============================================================================

-- 1. INSERCIÓN: Registrar un nuevo usuario (Alumno o Profesor)
INSERT INTO USUARIOS (Nombre, Correo, Contraseña, IdGrupo, FechaRegistro, Rol)
VALUES ('Nombre Ejemplo', 'correo@ejemplo.com', 'password123', 1, GETDATE(), 'Alumno');

-- 2. CONSULTA/LOGIN: Validar credenciales de usuario y obtener datos del grupo
SELECT 
    u.IdUsuario, 
    u.Nombre, 
    u.IdGrupo, 
    u.FotoPerfil, 
    u.Rol,
    g.Nombre AS NombreGrupo,
    g.Carrera AS NombreCarrera
FROM USUARIOS u
LEFT JOIN Grupos g ON u.IdGrupo = g.IdGrupo
WHERE u.Correo = 'correo@ejemplo.com' AND u.Contraseña = 'password123';

-- 3. CONSULTA: Cargar/Refrescar datos del perfil de usuario por ID
SELECT 
    u.IdUsuario, 
    u.Nombre, 
    u.IdGrupo, 
    u.FotoPerfil, 
    u.Rol,
    g.Nombre AS NombreGrupo,
    g.Carrera AS NombreCarrera
FROM USUARIOS u
LEFT JOIN Grupos g ON u.IdGrupo = g.IdGrupo
WHERE u.IdUsuario = 1;

-- 4. CONSULTA: Obtener el catálogo de grupos existentes
SELECT IdGrupo, Nombre 
FROM Grupos 
ORDER BY Nombre ASC;

-- 5. CONSULTA: Consultar tareas filtradas por materia y grupo
SELECT IdTarea, IdMateria, IdGrupo, Titulo, Descripcion, FechaEntrega, Estado 
FROM Tareas 
WHERE IdMateria = 1 AND IdGrupo = 1 
ORDER BY IdTarea ASC;

-- 6. CONSULTA: Obtener la última tarea pendiente
SELECT TOP 1 Titulo, Descripcion 
FROM Tareas 
WHERE IdMateria = 1 AND IdGrupo = 1 
ORDER BY IdTarea DESC;

-- 7. INSERCIÓN: Registrar la entrega de una tarea
INSERT INTO Tareas (IdMateria, Titulo, Descripcion, FechaEntrega, Estado, IdGrupo)
VALUES (1, 'Título Tarea', 'Descripción de la tarea', GETDATE(), 'Entregado', 1);

-- 8. CONSULTA: Cargar el catálogo de materias de la aplicación
SELECT IdMateria, Nombre, Imagen 
FROM MATERIAS 
ORDER BY IdMateria ASC;