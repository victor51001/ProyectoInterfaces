CREATE TABLE Transaccion (
    id INT PRIMARY KEY,
    fecha DATE,
    empleadoDni VARCHAR(255),
    clienteDni VARCHAR(255),
    inmuebleId INT,
    precio INT,
    beneficio REAL,
    FOREIGN KEY (empleadoDni) REFERENCES Empleado(dni),
    FOREIGN KEY (clienteDni) REFERENCES Cliente(dni),
    FOREIGN KEY (inmuebleId) REFERENCES Inmueble(id)
);