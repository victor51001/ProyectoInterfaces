CREATE TABLE [dbo].[EnVenta] (
    [id]                  INT NOT NULL,
    [precioMetroCuadrado] INT NULL,
    [precio]              INT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id]) REFERENCES [dbo].[Inmueble] ([id])
);

