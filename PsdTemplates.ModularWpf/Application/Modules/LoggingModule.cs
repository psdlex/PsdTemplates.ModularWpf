using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using PsdFramework.ModularWpf.Logging.Extensions;

using PsdUtilities.ApplicationModules.Models;

namespace ModularWpf.Application.Modules;

public sealed class LoggingModule : IApplicationModule
{
    private readonly IConfiguration _configuration;

    public LoggingModule(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public ApplicationModuleOrder Order { get; } = ApplicationModuleOrder.Default;

    public void Register(IServiceCollection services)
    {
        services.AddLogging(builder =>
        {
            builder.SetMinimumLevel(LogLevel.Trace);
            builder.AddPsdFramework(_configuration);
        });
    }
}