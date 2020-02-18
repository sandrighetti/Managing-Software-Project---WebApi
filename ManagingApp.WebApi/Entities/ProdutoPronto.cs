using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagingApp.WebApi.Enums;
using ManagingApp.WebApi.Entities.Interfaces;

namespace ManagingApp.WebApi.Entities
{
    public class ProdutoPronto : BaseEntity, IProduto
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Estoque { get; set; }
        public AgrupamentoProduto Grupo { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }

        protected ProdutoPronto() { }
        public ProdutoPronto(int id, string descricao, double valor, int estoque, AgrupamentoProduto grupo, UnidadeMedida unidadeMedida)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            Estoque = estoque;
            Grupo = grupo;
            UnidadeMedida = unidadeMedida;
            
        }
    }
}
