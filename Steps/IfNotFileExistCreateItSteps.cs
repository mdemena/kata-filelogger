using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace com.mdemena.katas.fileLogger.Scenarios
{
    [Binding]
    public class IfNotFileExistCreateItSteps
    {
        private Entities.FileLogger _fileLogger;
        private Entities.File _file;
        private string _fileName = string.Format("log{0}.txt", DateTime.Today.ToString("YYYYMMDD"));
        private string _message = "Text Message IfNotExist";

        [Given(@"I have a log file"), Scope(Tag = "IfNotFileExistCreateIt")]
        public void GivenIHaveALogFile()
        {
            _file = new Entities.File(_fileName);
            _fileLogger = new Entities.FileLogger(_file);
        }

        [Given(@"I have a log file"), Scope(Tag = "IfFileExist")]
        public void GivenIHaveALogFileExist()
        {
            _file = new Entities.File(_fileName);
            _fileLogger = new Entities.FileLogger(_file);
        }

        [When(@"File not exist")]
        public void WhenFileNotExist()
        {
            Assert.IsFalse(Entities.Files.Exist(_file));
        }

        [Then(@"I create file")]
        public void ThenICreateFile()
        {
            Entities.Files.Add(_file);
            _file.Lines.Add(_message);
            Assert.IsTrue(Entities.Files.Exist(_file));
        }
        [Then(@"I write message at the end of it"), Scope(Tag = "IfNotFileExistCreateIt")]
        public void ThenIWriteMessageAtTheEndOfIt()
        {
            _file.Lines.Add(_message);
            Assert.IsTrue(_file.Lines[_file.Lines.Count - 1].Equals(_message));
        }

        [When(@"File exist")]
        public void WhenFileExist()
        {
            Assert.IsTrue(Entities.Files.Exist(_file));
        }

        [Then(@"I write message at the end of it"), Scope(Tag = "IfFileExist")]
        public void ThenIWriteMessageAtTheEndOfItExist()
        {
            _file.Lines.Add(_message);
            Assert.IsTrue(_file.Lines[_file.Lines.Count - 1].Equals(_message));
        }
    }
}
