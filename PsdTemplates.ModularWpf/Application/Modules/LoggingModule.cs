using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using PsdFramework.ModularWpf.Logging.Extensions;

using PsdUtilities.ApplicationModules.Models;
using PsdUtilities.ApplicationModules.Models.Parameters;

namespace PsdTemplates.ModularWpf.Application.Modules;

public sealed class LoggingModule : ApplicationModule
{
    public override void Register(IServiceCollection services, ApplicationModuleParameters parameters)
    {
        services.AddLogging(builder =>
        {
            builder.SetMinimumLevel(LogLevel.Trace);
            builder.AddPsdFramework(parameters.GetParameter<IConfiguration>("configuration"));
        });
    }
}