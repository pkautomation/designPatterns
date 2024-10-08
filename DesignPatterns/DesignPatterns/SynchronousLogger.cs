﻿using System;

namespace _01_Singleton;

class SynchronousLogger
{
    private static SynchronousLogger sLogger;
    private SynchronousLogger() { }

    public static SynchronousLogger GetInstance()
    {
        sLogger ??= new SynchronousLogger();

        return sLogger;
    }

    public void Log(string msg)
    {
        Console.WriteLine($"sLogger: {msg}");
    }
}