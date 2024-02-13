CREATE TABLE [dbo].[Alquiler] (
    [id]            INT NOT NULL IDENTITY,
    [precioMensual] INT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id]) REFERENCES [dbo].[Inmueble] ([id])
);

