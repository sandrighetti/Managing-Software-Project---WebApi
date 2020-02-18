using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagingApp.WebApi.Data.Interfaces
{
    // Isso é uma interface responsável por gerenciar o meu contexto, ele acompanha as mudanças no meu banco de dados
    // e pode ser usado para salvar as alterações
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
