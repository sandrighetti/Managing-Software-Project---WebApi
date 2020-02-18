using ManagingApp.WebApi.Data.Interfaces;
using ManagingApp.WebApi.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagingApp.WebApi.Repositories.Interfaces
{
    // Essa interface é responsável pelos repositórios, onde irá buscar, salvar, atualizar os dados no banco de dados.
    // É um repositorio genérico que irá funcionar para qualquer Entidade
    public interface IRepository<T> where T : IEntity
    {
        IUnitOfWork UnitOfWork { get; }
        void Save(T entity);
        void Delete(T entity);
        void Delete(long id);
        Task<T> FindById(long id);
        IEnumerable<T> FindAll();
    }
}
