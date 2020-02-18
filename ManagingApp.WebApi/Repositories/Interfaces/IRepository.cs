using System.Collections.Generic;
using System.Threading.Tasks;
using ManagingApp.WebApi.Data.Interfaces;
using ManagingApp.WebApi.Entities.Interfaces;

namespace ManagingApp.WebApi.Repositories.Interfaces
{
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
