using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab05Lib
{
    public class FileWriter : IWriter
    {
        string _filename = Constant.FileName;
        public string FileName { get { return this._filename; } }

        public FileWriter(string filename = null)
        {
            this._filename = filename ?? Constant.FileName;
        }

        public string Save(string message)
        {

            File.Create(_filename).Close();
            using (var fs = new StreamWriter(_filename))
            {
            fs.WriteLine(message);
            }

            return this._filename;
        }
    }
}
