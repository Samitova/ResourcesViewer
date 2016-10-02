using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResourcesViewer
{
    class MapFile : FileBase
    {
        public FileInfo file { get; set; }
        public MapFile(string name, string path, FileInfo file):base(name, path) 
        {
            this.file = file;
        }
    }
}
