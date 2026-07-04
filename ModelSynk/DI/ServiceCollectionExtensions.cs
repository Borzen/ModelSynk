using Microsoft.Extensions.DependencyInjection;
using ModelSynk.Core.DI;
using ModelSynk.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.DI
{
    public static class ServiceCollectionExtensions
    {
        public static void AddModelSyncUIServices(this IServiceCollection services)
        {
            services.AddCoreModelSyncServices();

            services.AddTransient<MainWindowViewModel>();
        }
    }
}
