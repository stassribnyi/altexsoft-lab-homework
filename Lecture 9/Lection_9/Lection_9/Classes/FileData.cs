using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_9.Classes
{
    class FileData : Data, IDisposable
    {
        private FileStream _fs;
        public void Read(string path)
        {
            StringBuilder str = new StringBuilder();

            _fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
            
                byte[] b = new byte[1024];

                UTF8Encoding temp = new UTF8Encoding(true);

                while (_fs.Read(b, 0, b.Length) > 0)
                {
                    str.Append(temp.GetString(b));
                }
         
            FData = str.ToString();
        }

        public void Dispose()
        {
            _fs.Close();
        }
    }
}
