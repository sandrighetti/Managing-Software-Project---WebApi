using ManagingApp.WebApi.Enums;

namespace ManagingApp.WebApi.Entities.Interfaces
{
    interface IProduto
    {
        string Descricao { get; set; }
        double Valor { get; set; }
        int Estoque { get; set; }
        AgrupamentoProduto Grupo { get; set; }
        UnidadeMedida UnidadeMedida { get; set; }

        public void AddStock(int quantidade)
        {
            Estoque += quantidade;
        }

        public void SubtractStock (int quantidade)
        {
            Estoque -= quantidade;
        }
    }
}
