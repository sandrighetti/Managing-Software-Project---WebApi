using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagingApp.WebApi.Enums;

namespace ManagingApp.WebApi.Entities.Interfaces
{
    interface IProduto
    {
        string Descricao { get; set; }
        double Valor { get; set; }
        AgrupamentoProduto Grupo { get; set; }
        UnidadeMedida UnidadeMedida { get; set; }
    }
}
