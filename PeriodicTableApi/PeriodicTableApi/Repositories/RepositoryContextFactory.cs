using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PeriodicTableApi.Repositories
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext ( string[] args )
        {
            var optionsBuilder = new DbContextOptionsBuilder<RepositoryContext>();

            // Veritabanı dosyanızın adını buraya tanımlıyoruz
            optionsBuilder.UseSqlite ( "Data Source=main.db" );

            return new RepositoryContext ( optionsBuilder.Options );
        }
    }
}
