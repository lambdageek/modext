using System.Runtime.CompilerServices;

namespace ModExt;
internal static class Initializer
{
    [ModuleInitializer]
    public static void LoadExtra()
    {
        Extra.Extra.Load();
    }
}