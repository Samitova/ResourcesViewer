using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ResourcesViewer.Model
{
    class DirectoryItem:FileBase
    {
        public List<FileBase> Child { get; set; }
        public DirectoryInfo directory { get; set; }
               
        public DirectoryItem()
        {
            Child = new List<FileBase>();
        }
    }
}
