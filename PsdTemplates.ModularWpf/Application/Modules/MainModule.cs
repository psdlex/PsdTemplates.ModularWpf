using Microsoft.Extensions.DependencyInjection;

using PsdUtilities.ApplicationModules.Models;

using ModularWpf.Modules.Main;
using PsdFramework.ModularWpf.Vvm;

namespace ModularWpf.Application.Modules;

public sealed class MainModule : IApplicationModule
{
    public ApplicationModuleOrder Order { get; } = ApplicationModuleOrder.Default;

    public void Register(IServiceCollection services)
    {
        services.AddView<MainWindow, MainViewModel>();
    }
}