CREATE TABLE [dbo].[ProdutosNotasDeEntrada]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY,
	[IdNotaDeEntrada] INT NOT NULL,
	[IdProduto] BIGINT NOT NULL,
	[PrecoCustoCompra] NUMERIC(18, 2) NOT NULL,
	[QuantidadeCompra] NUMERIC(18, 3) NOT NULL,
	CONSTRAINT [FK_ProdutosNotasDeEntrada_NotasDeEntrada] FOREIGN KEY([IdNotaDeEntrada]) REFERENCES [NotasDeEntrada]([Id]),
	CONSTRAINT [FK_ProdutosNotasDeEntrada_Produtos] FOREIGN KEY([IdProduto]) REFERENCES [Produtos]([Id])
)
