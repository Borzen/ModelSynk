using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using ModelSynk.Core.Actions.Abstractions;
using ModelSynk.DI;
using ModelSynk.ViewModels;
using ModelSynk.Views;
using System.Linq;

namespace ModelSynk
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            var collection = new ServiceCollection();
            collection.AddModelSyncUIServices();

            var services = collection.BuildServiceProvider();

            var settingsManagementServices = services.GetRequiredService<IManageSettingsDatabase>();

            settingsManagementServices.RunDatabaseManagementScripts();

            var mainVM = services.GetRequiredService<MainWindowViewModel>();

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = mainVM,
                };
            }
            else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
            {
                singleViewPlatform.MainView = new MainWindow
                {
                    DataContext = mainVM
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}