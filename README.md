# PsdTemplates.ModularWpf

## Features
- `DI`-based infrastructure
- Application module seperation (`Application/Modules/`)
- Global exception handler, with many exception-specific handlers available to set alongside a global handler
- Built-in simple logging system using the `PsdFramework.ModularWpf.Logging`
- `IConfiguration`, `appsettings.json` and `appsettings.Logging.json`
- WPF-specific extensions methods such as `AddView<TView, TViewModel>` and others (check the framework for further help)
- Built-in console utility class that allows you to allocate a console alongside your main window for development
- **Source-generated xaml resources**. Whenever you add new `*.xaml` in the `Resources/` folder, it will be automatically merged into the application without having you to manually enter the path.

### Template is ready to run as soon as you install it! 
