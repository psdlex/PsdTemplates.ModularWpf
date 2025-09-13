using System.Reflection;

namespace PsdTemplates.ModularWpf.Utils;

public static class AssemblyUtils
{
    public static readonly Assembly ExecutingAssembly = Assembly.GetExecutingAssembly();

    public static readonly Func<Assembly, bool> DefaultAssemblyFilter = (a) => a == ExecutingAssembly;
}