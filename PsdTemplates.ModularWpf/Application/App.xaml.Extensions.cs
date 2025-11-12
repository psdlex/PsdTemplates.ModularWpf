using System.IO;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PsdTemplates.ModularWpf.Utils;

using PsdUtilities.ApplicationModules.Extensions;
using PsdUtilities.ApplicationModules.Models.Parameters;

namespace PsdTemplates.ModularWpf.Application;

partial class App
{
    public static IServiceProvider BuildServices()
    {
        IServiceCollection services = new ServiceCollection();
        var configuration = BuildConfiguration();

        services.AddSingleton<IConfiguration>(configuration);
        services.AddModules(AssemblyUtils.DefaultAssemblyFilter, new ApplicationModuleParameter("configuration", configuration));

        return services.BuildServiceProvider();
    }

    private static IConfigurationRoot BuildConfiguration() => new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile("appsettings.Logging.json", optional: false, reloadOnChange: true)
        .Build();
}