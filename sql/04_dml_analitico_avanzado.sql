-- =============================================================================
-- CONSULTAS DE REPORTERÍA Y AGREGACIÓN AVANZADA (DML ANALÍTICO)
-- =============================================================================

-- -----------------------------------------------------------------------------
-- CONSULTAS CON INNER JOIN 
-- -----------------------------------------------------------------------------

-- 1. ¿Qué alumnos pertenecen a qué grupo y cuál es la carrera a la que están adscritos?
SELECT 
    u.IdUsuario,
    u.Nombre AS NombreAlumno,
    u.Correo,
    g.Nombre AS NombreGrupo,
    g.Carrera
FROM USUARIOS u
INNER JOIN Grupos g ON u.IdGrupo = g.IdGrupo
WHERE u.Rol = 'Alumno';

-- 2. ¿Qué tareas han sido asignadas a cada grupo y a qué materia corresponden?
SELECT 
    t.IdTarea,
    t.Titulo AS TituloTarea,
    t.Estado,
    m.Nombre AS NombreMateria,
    g.Nombre AS NombreGrupo
FROM Tareas t
INNER JOIN MATERIAS m ON t.IdMateria = m.IdMateria
INNER JOIN Grupos g ON t.IdGrupo = g.IdGrupo;

-- 3. ¿Qué asesorías han sido programadas, qué docente la imparte y a qué alumno atiende?
SELECT 
    a.IdAsesoria,
    a.Fecha,
    a.Tema,
    m.Nombre AS Materia,
    uDocente.Nombre AS NombreDocente,
    uAlumno.Nombre AS NombreAlumno
FROM Asesorias a
INNER JOIN MATERIAS m ON a.IdMateria = m.IdMateria
INNER JOIN USUARIOS uDocente ON a.IdDocente = uDocente.IdUsuario
INNER JOIN USUARIOS uAlumno ON a.IdAlumno = uAlumno.IdUsuario;


-- -----------------------------------------------------------------------------
-- CONSULTAS CON AGREGACIÓN Y AGRUPACIÓN (GROUP BY) 
-- -----------------------------------------------------------------------------

-- 4. ¿Cuántos usuarios (alumnos/profesores) hay registrados en total por cada grupo?
SELECT 
    g.Nombre AS NombreGrupo,
    COUNT(u.IdUsuario) AS TotalUsuarios
FROM Grupos g
LEFT JOIN USUARIOS u ON g.IdGrupo = u.IdGrupo
GROUP BY g.Nombre;

-- 5. ¿Cuántas tareas se han asignado en total por cada materia?
SELECT 
    m.Nombre AS NombreMateria,
    COUNT(t.IdTarea) AS TotalTareasAsignadas
FROM MATERIAS m
LEFT JOIN Tareas t ON m.IdMateria = t.IdMateria
GROUP BY m.Nombre;

-- 6. ¿Cuántas tareas hay agrupadas por cada estado (Completado, Pendiente, Entregado)?
SELECT 
    t.Estado,
    COUNT(t.IdTarea) AS CantidadTareas
FROM Tareas t
GROUP BY t.Estado;


-- -----------------------------------------------------------------------------
-- CONSULTAS CON FILTRO DE GRUPOS (HAVING)
-- -----------------------------------------------------------------------------

-- 7. ¿Cuáles materias tienen más de 3 tareas registradas en el sistema?
SELECT 
    m.Nombre AS NombreMateria,
    COUNT(t.IdTarea) AS TotalTareas
FROM MATERIAS m
INNER JOIN Tareas t ON m.IdMateria = t.IdMateria
GROUP BY m.Nombre
HAVING COUNT(t.IdTarea) > 3;

-- 8. ¿Qué grupos tienen más de 5 alumnos registrados?
SELECT 
    g.Nombre AS NombreGrupo,
    COUNT(u.IdUsuario) AS CantidadAlumnos
FROM Grupos g
INNER JOIN USUARIOS u ON g.IdGrupo = u.IdGrupo
WHERE u.Rol = 'Alumno'
GROUP BY g.Nombre
HAVING COUNT(u.IdUsuario) > 5;