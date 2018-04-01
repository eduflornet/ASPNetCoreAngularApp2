using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreAngularApp2.EntityFrameworkCore
{
    public static class ASPNetCoreAngularApp2DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ASPNetCoreAngularApp2DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ASPNetCoreAngularApp2DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
