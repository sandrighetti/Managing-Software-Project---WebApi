using System;
using System.Threading.Tasks;
using ManagingApp.WebApi.Data.Interfaces;
using ManagingApp.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManagingApp.WebApi.Data
{
    public class ManagingAppWebApiContext : DbContext, IUnitOfWork
    {
        public ManagingAppWebApiContext(DbContextOptions<ManagingAppWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<ProdutoPronto> ProdutosPronto { get; set; }

        // Implementa o Commit de IUnitOfWork para salvar as alterações
        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
