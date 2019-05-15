using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NimbleCalandar.EntityFrameworkCore
{
    public static class NimbleCalandarDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NimbleCalandarDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NimbleCalandarDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
