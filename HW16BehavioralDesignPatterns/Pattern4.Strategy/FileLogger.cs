using System;
using System.Collections.Generic;
using System.IO;

namespace Pattern4.Strategy
{
    public class FileLogger : ILogger
    {
        private readonly string filePath;

        

        public FileLogger(string filepath)
        {
            this.filePath = filepath;
        }

        public void Log(string message)
        {
            File.AppendAllLines(filePath, new List<string> { string.Format("[{0}] : {1}", DateTime.Now, message) });
        }
    }
}
