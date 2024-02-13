CREATE TABLE [dbo].[Visita] (
    [id]          INT           NOT NULL IDENTITY,
    [fechaHora]   DATETIME      NULL,
    [clienteDni]  VARCHAR (255) NULL,
    [inmuebleId]  INT           NULL,
    [empleadoDni] VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([clienteDni]) REFERENCES [dbo].[Cliente] ([dni]),
    FOREIGN KEY ([empleadoDni]) REFERENCES [dbo].[Empleado] ([dni]),
    FOREIGN KEY ([inmuebleId]) REFERENCES [dbo].[Inmueble] ([id])
);

