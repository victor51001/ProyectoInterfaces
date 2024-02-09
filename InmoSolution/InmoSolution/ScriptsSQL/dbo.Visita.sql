CREATE TABLE Visita (
    id INT PRIMARY KEY,
    fechaHora DATETIME,
    clienteDni VARCHAR(255),
    inmuebleId INT,
    empleadoDni VARCHAR(255),
    FOREIGN KEY (clienteDni) REFERENCES Cliente(dni),
    FOREIGN KEY (inmuebleId) REFERENCES Inmueble(id),
    FOREIGN KEY (empleadoDni) REFERENCES Empleado(dni)
);