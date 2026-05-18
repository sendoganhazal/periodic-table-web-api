using Microsoft.EntityFrameworkCore;
using PeriodicTableApi.Models;
namespace PeriodicTableApi.Repositories
{
    public class RepositoryContext :DbContext
    {
        public RepositoryContext ( DbContextOptions<RepositoryContext> options ) : base ( options )
        {
        }
        public DbSet<Element> Elements { get; set; }
        public DbSet<ElementImage> ElementImages { get; set; }

        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            base.OnModelCreating ( modelBuilder );
        }
    }
}
