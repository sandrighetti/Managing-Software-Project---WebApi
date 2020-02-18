using ManagingApp.WebApi.Data;
using ManagingApp.WebApi.Entities;
using ManagingApp.WebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ManagingApp.WebApi.Repositories.Implementations
{
    public class ProdutoProntoRepository : BaseRepository<ProdutoPronto>, IProdutoProntoRepository
    {
        public ProdutoProntoRepository(ManagingAppWebApiContext dbContext) : base(dbContext)
        {
        }
    }
}
