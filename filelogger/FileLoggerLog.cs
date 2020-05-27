using System;
using System.IO;
using Xunit;

namespace FileLoggerKata
{
    public class FileLoggerLog
    {
        [Fact]
        public void WritesMessageToLogTxtFile()
        {
            var logger = new FileLogger();
            var msg = Guid.NewGuid().ToString();

            logger.Log(msg);

            var logfile = File.ReadAllText("log.txt");
            Assert.Contains(msg, logfile);
        }
    }
}
