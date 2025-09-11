
using Microsoft.Extensions.Logging;

using PsdFramework.ModularWpf.ExceptionHandling.Models;

namespace ModularWpf.Application;

public sealed class GlobalExceptionHandler : IExceptionHandler
{
    private readonly ILogger<GlobalExceptionHandler> _logger;

    public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(ModularContext context)
    {
        _logger.LogError("An unhandled exception occurred: {Message}", context.Exception.Message);
        _logger.LogTrace("Unhandled exception trace: {Exception}", context.Exception);
        context.IsHandled = true;

        return Task.CompletedTask;
    }
}