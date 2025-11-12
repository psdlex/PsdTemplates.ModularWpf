using Microsoft.Extensions.DependencyInjection;
using PsdFramework.ModularWpf.General.Registration;
using PsdUtilities.ApplicationModules.Models;
using PsdUtilities.ApplicationModules.Models.Parameters;

namespace PsdTemplates.ModularWpf.Application.Modules;

public sealed class MainModule : ApplicationModule
{
    public override void Register(IServiceCollection services, ApplicationModuleParameters parameters)
    {
        services.AddComponentModels();
    }
}