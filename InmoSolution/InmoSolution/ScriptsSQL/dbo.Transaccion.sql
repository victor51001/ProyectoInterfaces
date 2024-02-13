CREATE TABLE [dbo].[Transaccion] (
    [id]          INT           NOT NULL IDENTITY,
    [fecha]       DATE          NULL,
    [empleadoDni] VARCHAR (255) NULL,
    [clienteDni]  VARCHAR (255) NULL,
    [inmuebleId]  INT           NULL,
    [precio]      INT           NULL,
    [beneficio]   REAL          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([empleadoDni]) REFERENCES [dbo].[Empleado] ([dni]),
    FOREIGN KEY ([clienteDni]) REFERENCES [dbo].[Cliente] ([dni]),
    FOREIGN KEY ([inmuebleId]) REFERENCES [dbo].[Inmueble] ([id])
);

