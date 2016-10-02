using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ResourcesViewer
{
    class Directory:FileBase
    {
        public DirectoryInfo directory { get; set; }
        public Directory(string name, string path, DirectoryInfo dir): base (name, path) {
            directory = dir;           
        }
    }
}
