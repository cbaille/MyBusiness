using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyBusiness.EntityFrameworkCore
{
    public static class MyBusinessDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyBusinessDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyBusinessDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
