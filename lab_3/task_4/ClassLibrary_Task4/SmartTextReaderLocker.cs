using System;
using System.Text.RegularExpressions;

namespace ClassLibrary_Task4
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private SmartTextReader _reader = new SmartTextReader();
        private Regex _regex { get; set; }

        public SmartTextReaderLocker(string denyPattern)
        {
            _regex = new Regex (denyPattern);
        }

        public char[][] ReadText(string filePath)
        {
            if (_regex.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return Array.Empty<char[]>();
            }

            return _reader.ReadText(filePath);
        }
    }
}
