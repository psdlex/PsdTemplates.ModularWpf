using Microsoft.Extensions.DependencyInjection;

using PsdFramework.ModularWpf.ExceptionHandling.Extensions;

using PsdUtilities.ApplicationModules.Models;

namespace PsdTemplates.ModularWpf.Application.Modules;

public sealed class DevelopmentModule : IApplicationModule
{
    public ApplicationModuleOrder Order { get; } = ApplicationModuleOrder.Default;

    public void Register(IServiceCollection services)
    {
        services.AddExceptionHandlersController();
        services.AddExceptionHandler<GlobalExceptionHandler>();
    }
}