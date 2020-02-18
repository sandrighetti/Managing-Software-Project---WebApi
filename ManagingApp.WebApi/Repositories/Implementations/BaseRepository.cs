using ManagingApp.WebApi.Data;
using ManagingApp.WebApi.Data.Interfaces;
using ManagingApp.WebApi.Entities.Interfaces;
using ManagingApp.WebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagingApp.WebApi.Repositories.Implementations
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly ManagingAppWebApiContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;

        public BaseRepository(ManagingAppWebApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual void Save(T entity)
        {
            if (entity.Id == 0)
                _dbContext.Add(entity);
            else
                _dbContext.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            _dbContext.Remove(entity);
        }

        public async void Delete(long id)
        {
            var entity = (await FindById(id));

            if (entity == null)
                return;

            Delete(entity);
        }

        public virtual async Task<T> FindById(long id)
        {
            return await _dbContext.FindAsync<T>(id);
        }

        public virtual IEnumerable<T> FindAll()
        {
            return _dbContext.Set<T>();
        }
    }
}
