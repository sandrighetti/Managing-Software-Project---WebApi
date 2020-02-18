using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManagingApp.WebApi.Data
{
    public class ManagingAppWebApiContext : DbContext
    {
        public ManagingAppWebApiContext(DbContextOptions<ManagingAppWebApiContext> options)
            : base(options)
        {
        }
    }
}
