namespace _01_Singleton;

public class Program
{
    public static void Main(string[] args)
    {
        var logger = SynchronousLogger.GetInstance();
        logger.Log("Hello World!");
        var logger2 = SynchronousLogger.GetInstance();
        logger2.Log("Hello world again!");

        if (!logger.Equals(logger2))
        {
            throw new System.Exception("Loggers should be the same");
        }
    }
}