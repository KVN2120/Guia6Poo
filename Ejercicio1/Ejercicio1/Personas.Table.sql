CREATE TABLE [dbo].[Personas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombres] VARCHAR(50) NULL, 
    [Apellidos] VARCHAR(50) NULL, 
    [Edad] VARCHAR(20) NULL, 
    [Direccion] VARCHAR(50) NULL
)
