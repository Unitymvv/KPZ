using System;

namespace ClassLibrary_Task1
{
    public class Logger : ILogger
    {
        public void Log(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("LOG => " + msg);
            Console.ResetColor();
        }

        public void Error(string msg) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR => " + msg);
            Console.ResetColor();
        }

        public void Warn(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WARNING => " + msg);
            Console.ResetColor();
        }
    }
}
