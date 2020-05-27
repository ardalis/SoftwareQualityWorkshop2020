using System.IO;

namespace FileLoggerKata
{
    public class FileLogger
    {
        public void Log(string message)
        {
            using var writer = File.AppendText("log.txt");
            writer.WriteLine(message);
        }
    }
}
