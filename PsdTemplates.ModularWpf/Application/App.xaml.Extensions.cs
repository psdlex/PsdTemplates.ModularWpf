using System.IO;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using PsdTemplates.ModularWpf.Utils;

using PsdUtilities.ApplicationModules;

namespace PsdTemplates.ModularWpf.Application;

partial class App
{
    public static IServiceProvider BuildServices()
    {
        IServiceCollection services = new ServiceCollection();
        var configuration = BuildConfiguration();

        services.AddSingleton<IConfiguration>(configuration);
        services.RegisterModules(AssemblyUtils.DefaultAssemblyFilter, new Dictionary<string, object>()
        {
            { "configuration", configuration }
        });

        return services.BuildServiceProvider();
    }

    private static IConfigurationRoot BuildConfiguration() => new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("Metadata/appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile("Metadata/appsettings.Logging.json", optional: false, reloadOnChange: true)
        .Build();
}