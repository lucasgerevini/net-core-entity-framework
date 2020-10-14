using NetCore.Entity.Framework.Console.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace NetCore.Entity.Framework.Console.Data
{
    public class Context : DbContext
    {
        public DbSet<BlogEntity> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        }
    }
}