﻿CREATE TABLE [dbo].Fornecedores
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Cnpj] NCHAR(14) NOT NULL, 
    [Nome] NVARCHAR(50) NULL
)
