using System.Threading.Tasks;

namespace ManagingApp.WebApi.Data.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
