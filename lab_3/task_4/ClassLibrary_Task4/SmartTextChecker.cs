using System;
using System.Linq;

namespace ClassLibrary_Task4
{
    public class SmartTextChecker : ISmartTextReader
    {
        private SmartTextReader _reader = new SmartTextReader();

        public char[][] ReadText(string filePath)
        {
            try
            {
                Console.WriteLine("Opening file: " + filePath);
                char[][] result = _reader.ReadText(filePath);
                Console.WriteLine("File read successfully");

                int linesCount = result.Length;
                int symbolsCount = result.Sum(x => x.Length);

                Console.WriteLine("Total lines: " + linesCount);
                Console.WriteLine("Total symbols: " + symbolsCount);

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading file: " + e.Message);
                return Array.Empty<char[]>();
            }
            finally
            {
                Console.WriteLine("File close");
            }
        }
    }
}
