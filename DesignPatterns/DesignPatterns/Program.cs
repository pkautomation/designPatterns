namespace _01_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = SynchronousLogger.GetInstance();
            logger.Log("Hello World!");
            var logger2 = SynchronousLogger.GetInstance();
            
            logger2.Log("Hello world again!");

            if (logger == logger2)
                System.Console.WriteLine("I am the same logger");
        }
    }
}