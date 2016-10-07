using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ResourcesViewer.Model
{
    abstract class FileBase
    {            
        public string Name { get; set; }
        public string Path { get; set; }      
    }
}
