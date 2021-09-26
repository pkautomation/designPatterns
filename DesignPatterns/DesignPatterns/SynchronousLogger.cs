using System;

class SynchronousLogger
{
    private static SynchronousLogger sLogger;
    private SynchronousLogger() { }

    public static SynchronousLogger GetInstance()
    {
        if(sLogger == null)
        {
            sLogger = new SynchronousLogger();
        }

        return sLogger;
    }

    public void Log(string msg)
    {
        Console.WriteLine($"sLogger: {msg}");
    }
}
