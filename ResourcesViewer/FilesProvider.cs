using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ResourcesViewer.Model
{
    static class FilesProvider
    {
        public static List<FileBase> GetFilesTree(string path)
        {
            Options options = Options.GetInstance();
            List<FileBase> tree = new List<FileBase>();            
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            foreach (DirectoryInfo directory in dirInfo.GetDirectories())
            {
                FileBase dir = new DirectoryItem
                {
                    Name = directory.Name,
                    Path = directory.FullName,
                    Child = GetFilesTree(directory.FullName)
                };

                tree.Add(dir);
            }

            if (options.isMapFile)
            {
                foreach (FileInfo file in dirInfo.GetFiles("*.map", SearchOption.TopDirectoryOnly))
                {
                    FileBase item = new MapFile
                    {
                        Name = file.Name,
                        Path = file.FullName
                    };

                    tree.Add(item);
                }
            }

            if (options.isResFile)
            {
                foreach (FileInfo file in dirInfo.GetFiles("*.res", SearchOption.TopDirectoryOnly))
                {
                    FileBase item = new ResFile
                    {
                        Name = file.Name,
                        Path = file.FullName
                    };

                    tree.Add(item);
                }
            }

            if (options.isXmlFile)
            {
                foreach (FileInfo file in dirInfo.GetFiles("*.xml", SearchOption.TopDirectoryOnly))
                {
                    FileBase item = new XMLFile
                    {
                        Name = file.Name,
                        Path = file.FullName
                    };

                    tree.Add(item);
                }
            }

            return tree;
        }
      
    }
}

