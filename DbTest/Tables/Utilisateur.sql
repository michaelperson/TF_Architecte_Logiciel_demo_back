﻿CREATE TABLE [dbo].[Utilisateur]
(
	[Id] INT NOT NULL IDENTITY,
	[Nom] NVARCHAR(80) NOT NULL,
	[Prenom] NVARCHAR(80) NOT NULL,
	[Email] NVARCHAR(100) NOT NULL,
	[DateNaissance] DATE NOT NULL

	CONSTRAINT [PK_Utilisateur] PRIMARY KEY ([Id])
)
