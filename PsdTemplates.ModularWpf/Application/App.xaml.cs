using System.Windows;
using Microsoft.Extensions.DependencyInjection;

using PsdTemplates.ModularWpf.Modules.Main;

using PsdFramework.ModularWpf.ExceptionHandling.Extensions;
using PsdFramework.ModularWpf.General.Models;
using PsdFramework.ModularWpf.Vvm;

namespace PsdTemplates.ModularWpf.Application;

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
}