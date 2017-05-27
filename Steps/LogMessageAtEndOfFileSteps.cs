using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace com.mdemena.katas.fileLogger.Steps
{
    [Binding]
    public class LogMessageAtEndOfFileSteps
    {
        private Entities.FileLogger _fileLogger;
        private Entities.File _file;
        private string _message;

        [Given(@"I have a log file"),Scope(Tag = "LogMessageAtEndOfFile")]
        public void GivenIHaveALogFile()
        {
            _file = new Entities.File("log.txt");
            _fileLogger = new Entities.FileLogger(_file);
        }
        
        [When(@"I put a message to it"), Scope(Tag = "LogMessageAtEndOfFile")]
        public void WhenIPutAMessageToIt()
        {
            _message = "Test Message";
            _fileLogger.Log(_message);
        }
        
        [Then(@"I write message at the end of it"), Scope(Tag = "LogMessageAtEndOfFile")]
        public void ThenIWriteMessageAtTheEndOfIt()
        {
            Assert.IsTrue(_file.Lines[_file.Lines.Count-1].Equals(_message));
        }
    }
}
