CREATE TABLE EnVenta (
    id INT PRIMARY KEY,
    precioMetroCuadrado INT,
    precio INT,
    FOREIGN KEY (id) REFERENCES Inmueble(id)
);