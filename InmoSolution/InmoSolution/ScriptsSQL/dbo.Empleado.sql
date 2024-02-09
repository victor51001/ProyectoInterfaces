CREATE TABLE Empleado (
    dni VARCHAR(255) PRIMARY KEY,
    nombre VARCHAR(255),
    apellidos VARCHAR(255),
    telefono INT,
    email VARCHAR(255),
    usuarioId INT,
    puestoId INT,
    sueldo REAL,
    FOREIGN KEY (usuarioId) REFERENCES Usuario(id),
    FOREIGN KEY (puestoId) REFERENCES Puestos(id)
);