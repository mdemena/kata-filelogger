using System;

namespace com.mdemena.katas.fileLogger.Entities
{
    public class FileLogger
    {
        public File LogFile { get; private set; }

        public FileLogger(File _file)
        {
            this.LogFile = _file;
        }

        internal void Log(string message)
        {
            this.LogFile.Lines.Add(message);
        }
    }
}