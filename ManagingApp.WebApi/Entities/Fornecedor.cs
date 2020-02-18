using ManagingApp.WebApi.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagingApp.WebApi.Entities
{
    public class Fornecedor : BaseEntity
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Fone { get; set; }
        public string Contato { get; set; }

        public Fornecedor(string nome, string endereco, string fone, string contato)
        {
            Nome = nome;
            Endereco = endereco;
            Fone = fone;
            Contato = contato;
        }
    }
}
