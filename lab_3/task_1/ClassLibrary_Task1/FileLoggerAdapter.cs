namespace ClassLibrary_Task1
{
    public class FileLoggerAdapter : ILogger
    {
        private FileWriter _fileWriter;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public void Error(string msg)
        {
            _fileWriter.WriteLine("ERROR => " + msg);
        }

        public void Log(string msg)
        {
            _fileWriter.WriteLine("LOG => " + msg);
        }

        public void Warn(string msg)
        {
            _fileWriter.WriteLine("WARNING => " + msg);
        }
    }
}
