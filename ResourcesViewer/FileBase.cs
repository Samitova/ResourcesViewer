using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ResourcesViewer
{
    abstract class FileBase
    {            
        public string Name { get; set; }
        public string Path { get; set; }
        public List<FileBase> Child;

        public FileBase(string name, string path) {
            Child = new List<FileBase>();
            Name = name;
            Path = path;      
        }
    }
}
