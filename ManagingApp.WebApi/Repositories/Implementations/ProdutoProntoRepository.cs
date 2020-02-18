using Microsoft.EntityFrameworkCore;
using ManagingApp.WebApi.Data;
using ManagingApp.WebApi.Entities;
using ManagingApp.WebApi.Repositories.Interfaces;

namespace ManagingApp.WebApi.Repositories.Implementations
{
    public class ProdutoProntoRepository : BaseRepository<ProdutoPronto>, IProdutoProntoRepository
    {
        public ProdutoProntoRepository(ManagingAppWebApiContext dbContext) : base(dbContext)
        {
        }
    }
}
