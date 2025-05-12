using ClassLibrary_Task4;
using System;
using System.Linq;

namespace ConsoleApp_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";

            ISmartTextReader loggerProxy = new SmartTextChecker();
            char[][] loggedText = loggerProxy.ReadText(filePath);

            Console.WriteLine("Preview:");
            foreach (var line in loggedText.Take(2))
            {
                Console.WriteLine(new string(line));
            }

            Console.WriteLine();

            ISmartTextReader lockerProxy = new SmartTextReaderLocker(@".*secret.*");
            lockerProxy.ReadText("secret-file.txt");
            lockerProxy.ReadText("public-file.txt");
        }
    }
}
