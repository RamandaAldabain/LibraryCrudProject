using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CrudProject.EntityFrameworkCore
{
    public static class CrudProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CrudProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
            builder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

		}

        public static void Configure(DbContextOptionsBuilder<CrudProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
			builder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

		}
	}
}
