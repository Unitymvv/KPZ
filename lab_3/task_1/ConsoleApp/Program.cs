using ClassLibrary_Task1;
using System;

namespace ConsoleApp_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger consoleLogger = new Logger();
            consoleLogger.Log("Інформаційне повідомлення");
            consoleLogger.Error("Повідомлення про помилку");
            consoleLogger.Warn("Попередження");

            FileWriter fileWriter = new FileWriter("log.txt");
            FileLoggerAdapter fileLogger = new FileLoggerAdapter(fileWriter);
            fileLogger.Log("Записано у файл: інформація");
            fileLogger.Error("Записано у файл: критична помилка");
            fileLogger.Warn("Записано у файл: попередження");

            Console.WriteLine("Перевірте файл log.txt для перегляду файлових логів.");
        }
    }
}
