namespace ManagingApp.WebApi.Entities
{
    public class Fornecedor : BaseEntity
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Fone { get; set; }
        public string Contato { get; set; }

        protected Fornecedor()
        {
        }

        public Fornecedor(long id, string nome, string endereco, string fone, string contato)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Fone = fone;
            Contato = contato;
        }
    }
}
