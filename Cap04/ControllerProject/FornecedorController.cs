using System;
using System.Collections.Generic;
using ModelProject;
using PersistenceProject;

namespace ControllerProject
{
    public class FornecedorController
    {
        public FornecedorController()
        {
            this.Insert(new Fornecedor
            {
                Id = Guid.NewGuid(),
                Nome = "Ambev",
                CNPJ = "12345678901234"
            });

            this.Insert(new Fornecedor
            {
                Id = Guid.NewGuid(),
                Nome = "Schin",
                CNPJ = "23456789012345"
            });
        }

        private Repository repository = new Repository();

        public Fornecedor Insert(Fornecedor fornecedor)
        {
            return this.repository.InsertFornecedor(fornecedor);
        }

        public void Remove(Fornecedor fornecedor)
        {
            this.repository.RemoveFornecedor(fornecedor);
        }

        public IList<Fornecedor> GetAll()
        {
            return this.repository.GetAllFornecedores();
        }

        public Fornecedor Update(Fornecedor fornecedor)
        {
            return this.repository.UpdateFornecedor(fornecedor);
        }
    }
}
