using CommunityToolkit.Mvvm.Input;
using PsdFramework.ModularWpf.Navigations.Abstract;
using PsdFramework.ModularWpf.Navigations.Models.Navigation;
using PsdFramework.ModularWpf.Navigations.Service;
using PsdFramework.ModularWpf.Views.Models;
using PsdTemplates.ModularWpf.Modules.HomePage;
using PsdTemplates.ModularWpf.Modules.Shared.Models;

namespace PsdTemplates.ModularWpf.Modules.Main;

[NavigationComponentModel(NavigationCategory.Main)]
public sealed partial class MainViewModel : ObservableNavigationComponentModel, IViewComponentModel<MainWindow>
{
    private readonly INavigatorService _navigatorService;

    public MainViewModel(INavigatorService navigatorService)
    {
        _navigatorService = navigatorService;
    }

    [RelayCommand]
    private async Task OnNavigateToHomePage()
    {
        await _navigatorService.NavigateTo<HomePageViewModel>(this);
    }
}