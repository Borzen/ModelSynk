using Microsoft.Extensions.DependencyInjection;
using ModelSynk.Core.Actions;
using ModelSynk.Core.Actions.Abstractions;
using ModelSynk.DataAccess.Sqlite.DI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Core.DI
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCoreModelSyncServices(this IServiceCollection services)
        {
            services.AddSqliteDataAccessServices();

            services.AddSingleton<IManageSettingsDatabase, ManageSettingsDatabase>();
        }
    }
}
