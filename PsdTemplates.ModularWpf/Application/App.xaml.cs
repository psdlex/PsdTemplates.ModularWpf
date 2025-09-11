using System.IO;
using System.Windows;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ModularWpf.Modules.Main;

using PsdFramework.ModularWpf.ExceptionHandling.Extensions;
using PsdFramework.ModularWpf.General.Models;
using PsdFramework.ModularWpf.Vvm;

using PsdUtilities.ApplicationModules;

namespace ModularWpf.Application;

public sealed partial class App : WinApp, IModularApplication
{
    public IServiceProvider? ServiceProvider { get; private set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        this.AddGlobalExceptionHandler();

        ServiceProvider = BuildServices();

        var mainView = ServiceProvider.GetRequiredService<IView<MainWindow>>();

        MainWindow = mainView.View;
        MainWindow.Show();
    }

    private IServiceProvider BuildServices()
    {
        IServiceCollection services = new ServiceCollection();
        var configuration = BuildConfiguration();

        services.AddSingleton<IConfiguration>(configuration);
        services.RegisterModules(a => a.FullName?.Contains(nameof(ModularWpf)) ?? false, new Dictionary<string, object>()
        {
            { "configuration", configuration },
            { "resourceDictionary", Resources }
        });

        return services.BuildServiceProvider();
    }

    private static IConfigurationRoot BuildConfiguration() => new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("Metadata/appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile("Metadata/appsettings.Logging.json", optional: false, reloadOnChange: true)
        .Build();
}