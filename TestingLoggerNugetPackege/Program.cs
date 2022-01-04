using LoggerNugetPackege;
using System;

namespace TestingLoggerNugetPackege
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Log("this is test dude");
                Console.WriteLine("Hello World!");
        }
    }
}
