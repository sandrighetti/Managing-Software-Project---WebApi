using System.Threading.Tasks;

namespace ManagingApp.WebApi.Entities.Interfaces
{
    public interface IEntityRepository<T> where T : IEntity
    {
        Task<bool> Save(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Delete(long id);
        Task<bool> FindById(long Id);
    }
}
