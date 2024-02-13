CREATE TABLE [dbo].[Inmueble] (
    [id]              INT           NOT NULL IDENTITY,
    [direccion]       VARCHAR (255) NULL,
    [habitaciones]    INT           NULL,
    [banos]           INT           NULL,
    [metrosCuadrados] INT           NULL,
    [antiguedad]      INT           NULL,
    [disponible]      BIT           NULL,
    [propietarioDni]  VARCHAR (255) NULL,
    [localidad]       VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([propietarioDni]) REFERENCES [dbo].[Cliente] ([dni])
);

