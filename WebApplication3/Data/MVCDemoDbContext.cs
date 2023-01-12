using Microsoft.EntityFrameworkCore;
using CrudAgenda.Models.Domain;

namespace CrudAgenda.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Agenda> Agenda { get; set; }
    }
}
