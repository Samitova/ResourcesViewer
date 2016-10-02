using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ResourcesViewer
{
    class FilesTree
    {
        private Directory rootDir;
        public void MakeFileTree(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);            
            if (dir.Exists)
            {
                rootDir = new Directory(dir.Name, dir.FullName, dir);
                GetFiles(rootDir);
                GetDirectories(rootDir);                                                             
            }
            else
            {
                
            }            
        }

        private void GetDirectories(Directory dirToAdd)
        {
            Directory myDir;            
            DirectoryInfo[] dirs = dirToAdd.directory.GetDirectories();
            foreach (DirectoryInfo curDir in dirs)
            {
                myDir = new Directory(curDir.Name, curDir.FullName, curDir);
                GetFiles(myDir);
                if (curDir.GetDirectories().Length != 0)
                {
                    GetDirectories(myDir);
                }
                dirToAdd.Child.Add(myDir);
            }           
        }

        private void GetFiles(Directory dir)
        {
            GetXMLFile(dir);
            GetMapFile(dir);
            GetResFile(dir);
        }

        private void GetXMLFile(Directory dir)
        {
            XMLFile xmlFile;
            foreach (FileInfo file in dir.directory.GetFiles("*.xml", SearchOption.TopDirectoryOnly))
            {
                xmlFile = new XMLFile(file.Name, file.FullName, file);
                dir.Child.Add(xmlFile);
            }
        }

        private void GetResFile(Directory dir)
        {
            ResFile resFile;
            foreach (FileInfo file in dir.directory.GetFiles("*.res", SearchOption.TopDirectoryOnly))
            {
                resFile = new ResFile(file.Name, file.FullName, file);
                dir.Child.Add(resFile);
            }
        }

        private void GetMapFile(Directory dir)
        {
            MapFile mapFile;
            foreach (FileInfo file in dir.directory.GetFiles("*.map", SearchOption.TopDirectoryOnly))
            {
                mapFile = new MapFile(file.Name, file.FullName, file);
                dir.Child.Add(mapFile);
            }
        }

       /* public void DrawFileTree(ref TreeView tree) {
            TreeNode node;
            node = new TreeNode(rootDir.Name);
            node.Tag = rootDir;

            if (rootDir.Child.Count > 0) {

                DrawDirNode(rootDir.Child, node);
            }            
            tree.Nodes.Add(node);
        }

        private void DrawDirNode(List<FileBase> children, TreeNode nodeToAdd) {
            TreeNode node;
            foreach (FileBase file in children)
            {
                node = new TreeNode(file.Name);
                node.Tag = file;
               
                if (file.Child.Count > 0)
                {
                    DrawDirNode(file.Child, node);
                }
                nodeToAdd.Nodes.Add(node);
            }
        }  */     
    }
}
