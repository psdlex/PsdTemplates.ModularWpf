using System.Reflection;

namespace PsdTemplates.ModularWpf.Utils;

public static class AssemblyUtils
{
    public static readonly Func<Assembly, bool> DefaultAssemblyFilter = (a) => a.FullName?.StartsWith($"{nameof(PsdTemplates)}.{nameof(ModularWpf)}") ?? false;
}