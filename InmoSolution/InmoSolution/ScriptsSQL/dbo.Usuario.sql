CREATE TABLE [dbo].[Usuario] (
    [id]     INT           NOT NULL IDENTITY,
    [login]  VARCHAR (255) NULL,
    [nombre] VARCHAR (255) NULL,
    [clave]  VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

