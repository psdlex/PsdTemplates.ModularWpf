using System.IO;
using System.Runtime.InteropServices;

namespace PsdTemplates.ModularWpf.Utils;

public static class ConsoleUtils
{
    [DllImport("kernel32.dll")]
    private static extern bool AllocConsole();

    [DllImport("kernel32.dll", EntryPoint = "FreeConsole")]
    public static extern bool Hide();

    public static bool Show()
    {
        var res = AllocConsole();
        var stdOut = Console.OpenStandardOutput();
        var writer = new StreamWriter(stdOut) { AutoFlush = true };

        Console.SetOut(writer);
        Console.SetError(writer);

        return res;
    }
}