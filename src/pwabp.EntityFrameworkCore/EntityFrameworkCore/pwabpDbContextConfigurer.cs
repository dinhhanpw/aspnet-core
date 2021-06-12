using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace pwabp.EntityFrameworkCore
{
    public static class pwabpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<pwabpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<pwabpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
