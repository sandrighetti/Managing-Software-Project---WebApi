using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagingApp.WebApi.Enums;
using ManagingApp.WebApi.Entities.Interfaces;

namespace ManagingApp.WebApi.Entities
{
    public class MateriaPrima : IProduto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public AgrupamentoProduto Grupo { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public ICollection<Fornecedor> Fornecedores { get; set; } = new List<Fornecedor>();
    }
}
