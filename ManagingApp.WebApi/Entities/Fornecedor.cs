using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagingApp.WebApi.Entities.Interfaces;

namespace ManagingApp.WebApi.Entities
{
    public class Fornecedor : IEntity
    {
        public long Id { get; set; }
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
