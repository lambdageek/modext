using System;
using System.Runtime.CompilerServices;

namespace ModExt.Extra;

public static class Extra
{
    public static void Load()
    {
        Console.WriteLine ("Extra initialized");
        Registry.AddConfigure(things =>
        {
            things.Add(new Thing2());
        });
    }
}