using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ShamiCafe.EntityFrameworkCore
{
    public static class ShamiCafeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ShamiCafeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ShamiCafeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
