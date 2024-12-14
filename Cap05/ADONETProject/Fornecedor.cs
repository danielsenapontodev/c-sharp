namespace ADONETProject
{
    public class Fornecedor
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public Fornecedor()
        {
            this.Id = null;
        }
    }
}
