using System.Runtime.InteropServices;

namespace ModularWpf.Utils;

public static class ConsoleUtils
{

    [DllImport("kernel32.dll", EntryPoint = "AllocConsole")]
    public static extern bool Show();

    [DllImport("kernel32.dll", EntryPoint = "FreeConsole")]
    private static extern bool Hide();
}