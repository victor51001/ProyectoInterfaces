CREATE TABLE Inmueble (
    id INT PRIMARY KEY,
    direccion VARCHAR(255),
    habitaciones INT,
    banos INT,
    metrosCuadrados INT,
    antiguedad INT,
    disponible BIT,
    propietarioDni VARCHAR(255),
    localidad VARCHAR(255),
    FOREIGN KEY (propietarioDni) REFERENCES Cliente(dni)
);