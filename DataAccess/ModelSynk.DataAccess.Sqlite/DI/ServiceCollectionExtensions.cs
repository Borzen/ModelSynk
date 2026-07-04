using Microsoft.Extensions.DependencyInjection;
using ModelSynk.DataAccess.DataServices;
using ModelSynk.DataAccess.Repositories.Settings;
using ModelSynk.DataAccess.Sqlite.DataServices;
using ModelSynk.DataAccess.Sqlite.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.DataAccess.Sqlite.DI
{
    public static class ServiceCollectionExtensions
    {
        public static void AddSqliteDataAccessServices(this IServiceCollection services)
        {
            services.AddSingleton<DbContext, SqliteDbContext>(serviceProvider =>
            {
                return new SqliteDbContext();
            });

            services.AddSingleton<IManagementDataService, ManagementDataService>();

            services.AddSingleton<IDataSourceConnectionRepository, DataSourceConnectionRepository>();
        }
    }
}
