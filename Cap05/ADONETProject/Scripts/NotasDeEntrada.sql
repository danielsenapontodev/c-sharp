CREATE TABLE [dbo].[NotasDeEntrada] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [IdFornecedor] BIGINT           NOT NULL,
    [Numero]       NVARCHAR (20) NOT NULL,
    [DataEmissao]  DATE          NOT NULL,
    [DataEntrada]  DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_NotasDeEntrada_Fornecedores] FOREIGN KEY ([IdFornecedor]) REFERENCES [Fornecedores]([Id])
);

