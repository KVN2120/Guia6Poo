CREATE TABLE [dbo].[Personas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombres] VARCHAR(50) NULL, 
    [Apellidos] VARCHAR(50) NULL, 
    [Edad] VARCHAR(50) NULL, 
    [Direccion] NCHAR(50) NULL
)
