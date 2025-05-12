using System.IO;

namespace ClassLibrary_Task1
{
    public class FileWriter
    {
        private string _filePath;

        public FileWriter(string filePath)
        {
            _filePath = filePath;
        }

        public void Write(string text)
        {
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                writer.Write(text);
            }
        }

        public void WriteLine(string text)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine(text);
            }
        }
    }
}
