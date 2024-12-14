CREATE TABLE [dbo].[Produtos]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Descricao] NVARCHAR(50) NOT NULL, 
    [PrecoDeCusto] NUMERIC(18, 2) NOT NULL, 
    [PrecoDeVenda] NUMERIC(18, 2) NOT NULL, 
    [Estoque] NUMERIC(18, 3) NOT NULL
)
