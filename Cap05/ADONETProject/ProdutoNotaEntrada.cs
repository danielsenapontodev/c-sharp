using System;

namespace ADONETProject
{
    public class ProdutoNotaEntrada
    {
        public long? Id { get; set; }
        public Produto ProdutoNota { get; set; }
        public double PrecoCustoCompra { get; set; }
        public double QuantidadeComprada { get; set; }

        public ProdutoNotaEntrada()
        {
            this.Id = null;
        }
    }
}
