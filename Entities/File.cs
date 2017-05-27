using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.mdemena.katas.fileLogger.Entities
{
    public class File
    {
        public System.Collections.Specialized.StringCollection Lines { get; private set; }
        public string Name { get; private set; }

        public File(string _fileName)
        {
            this.Name = _fileName;
            this.Lines = new System.Collections.Specialized.StringCollection();
        }

        public void Save()
        {

        }
    }
}
