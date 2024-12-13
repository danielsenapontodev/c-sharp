using System;
using System.Collections.Generic;
using ModelProject;
using PersistenceProject;

namespace ControllerProject
{
    public class ProdutoController
    {
        public ProdutoController()
        {
            this.Insert(new Produto
            {
                Id = Guid.NewGuid(),
                Descricao = "Cerveja Lata",
                Estoque = 100,
                PrecoDeCusto = 3.50,
                PrecoDeVenda = 5.00
            });

            this.Insert(new Produto
            {
                Id = Guid.NewGuid(),
                Descricao = "Cerveja Long Neck",
                Estoque = 50,
                PrecoDeCusto = 4.50,
                PrecoDeVenda = 6.00
            });
        }

        private Repository repository = new Repository();

        public Produto Insert(Produto produto)
        {
            return this.repository.InsertProduto(produto);
        }

        public void Remove(Produto produto)
        {
            this.repository.RemoveProduto(produto);
        }

        public IList<Produto> GetAll()
        {
            return this.repository.GetAllProdutos();
        }

        public Produto Update(Produto produto)
        {
            return this.repository.UpdateProduto(produto);
        }
    }
}
