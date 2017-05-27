using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.mdemena.katas.fileLogger.Entities
{
    public static class Files
    {
        private static System.Collections.Generic.Dictionary<string,File> _files = new Dictionary<string, File>();

        public static bool Exist(File _file)
        {
            return _files.ContainsKey(_file.Name);
        }

        public static void Add(File _file)
        {
            _files.Add(_file.Name, _file);
        }
    }
}
