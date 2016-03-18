using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tornado14.Task
{
    public class ChecklistFile
    {
        private string displayName { get; set; }
        public string DisplayName { get { return (isPrivate) ? "local " + displayName : "" + displayName; } set { displayName = value; } }

        private string name;
        public string Name { 
            get {
                return name;
            } 
            set { 
                name = value;
                displayName = name;//.Substring(0, name.IndexOf("."));
            }
        }
        private FileInfo file;
        public FileInfo File { 
            get { return file; } 
            set {
                file = value;
                directoryWithFiles = new DirectoryInfo(file.DirectoryName + @"\" + file.Name.Substring(0, file.Name.IndexOf(".")));
            } 
        }
        private DirectoryInfo directoryWithFiles;
        public DirectoryInfo DirectoryWithFiles { get { return directoryWithFiles;} }
        public bool isPrivate { get; set; }

        public ChecklistFile()
        {

        }

        public ChecklistFile(string name, FileInfo file, bool isPrivate)
        {
            Name = name;
            File = file;
            this.isPrivate = isPrivate;
        }

        public string HappyPathTemplateName = "template1.txt";

        public FileInfo GetHappyPathTemplate()
        {
            FileInfo[] templates = this.directoryWithFiles.GetFiles(HappyPathTemplateName);
            if (templates.Length > 0)
            {
                return templates[0];
            }
            return null;
        }



        public override string ToString()
        {
            return DisplayName;
        }
    }
}
