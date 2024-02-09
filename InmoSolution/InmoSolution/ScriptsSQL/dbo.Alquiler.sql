CREATE TABLE Alquiler (
    id INT PRIMARY KEY,
    precioMensual INT,
    FOREIGN KEY (id) REFERENCES Inmueble(id)
);