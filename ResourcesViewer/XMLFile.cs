using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ResourcesViewer
{
    class XMLFile : FileBase
    {
        public FileInfo file { get; set; }
        public XMLFile(string name, string path, FileInfo file) : base(name, path)
        {
            this.file = file;           
        }
    }
}
