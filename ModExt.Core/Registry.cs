using System;
using System.Collections.Generic;

namespace ModExt;

public class Registry
{
    private IEnumerable<IThing> _things;
    private static List<Action<List<IThing>>> _configures = new();

    public Registry()
    {
        List<IThing> things = new()
        {
            new Thing1(),
        };
        foreach (var configure in _configures)
        {
            configure(things);
        }
        _things = things;
    }

    public void RunAll()
    {
        foreach (var t in _things)
        {
            Console.WriteLine (t.DoIt());
        }
    }

    public static void AddConfigure(Action<List<IThing>> configure)
    {
        _configures.Add(configure);
    }
}
