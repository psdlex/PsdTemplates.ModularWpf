using Microsoft.Extensions.DependencyInjection;

using PsdFramework.ModularWpf.ExceptionHandling.Extensions;

using PsdUtilities.ApplicationModules.Models;
using PsdUtilities.ApplicationModules.Models.Parameters;

namespace PsdTemplates.ModularWpf.Application.Modules;

public sealed class DevelopmentModule : ApplicationModule
{
    public override void Register(IServiceCollection services, ApplicationModuleParameters parameters)
    {
        services.AddExceptionHandlersController();
        services.AddExceptionHandler<GlobalExceptionHandler>();
    }
}