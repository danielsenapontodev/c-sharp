using System;

namespace ADONETProject
{
    public class Produto
    {
        public long? Id { get; set; }
        public string Descricao { get; set; }
        public double PrecoDeCusto { get; set; }
        public double PrecoDeVenda { get; set; }
        public double Estoque { get; set; }

        public Produto()
        {
            Id = null;
        }
    }
}
