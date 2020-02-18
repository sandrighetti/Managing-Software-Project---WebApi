using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManagingApp.WebApi.Entities;
using ManagingApp.WebApi.Data.Interfaces;

namespace ManagingApp.WebApi.Data
{
    public class ManagingAppWebApiContext : DbContext, IUnitOfWork
    {
        public ManagingAppWebApiContext(DbContextOptions<ManagingAppWebApiContext> options)
            : base(options)
        {
        }
        public DbSet<ProdutoPronto> ProdutosProntos { get; set; }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
