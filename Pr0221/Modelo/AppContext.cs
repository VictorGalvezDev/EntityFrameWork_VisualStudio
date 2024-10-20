using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr0221.Modelo
{
    public class AppContext:DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(Localdb)\MSSQLLocalDB;Database=AppDB");
        }
    }
}
