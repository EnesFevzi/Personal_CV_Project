using Core_Proje_Enes_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_Enes_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=CoreProjeDBApi;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
