﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ResourcesViewer.Model
{
    class FileItem:FileBase
    {
        public FileInfo file { set; get; }
    }
}
