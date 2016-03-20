using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Tornado14Lab.Utils.File;
using System.Diagnostics;

namespace Tornado14.Task
{
    [Serializable]
    public class Todo
    {
        public Guid pId { get; set; }
        public string Id { get; set; }
        private string shortDescription;
        public Guid ProjectPid { get; set; }
        public Status Status { get; set; }
        public Guid SprintPid { get; set; }

        public string AdditionalField1 { get; set; }
        public string AdditionalField2 { get; set; }
        public string AdditionalField3 { get; set; }
        public string AdditionalField4 { get; set; }
        public string AdditionalField5 { get; set; }



        public string CurrentState { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
        public string PublicText { get; set; }

        public int Progress { get; set; }

        public string FilesFolder { get; set; }

        public List<Guid> AlsoForProjects { get; set; }
        public List<Guid> Features { get; set; }

        public string ShortDescription
        {
            get
            {
                if (shortDescription == null)
                {
                    ShortDescription = string.Empty;
                }
                return shortDescription;
            }
            set
            {
                if (shortDescription != null)
                {
                    //CheckFilesFolder(value);
                }

                shortDescription = value;
            }
        }

        public bool PublicTextFilled
        {
            get
            {
                return (this.PublicText != null && this.PublicText.Length > 0);
            }
            set { }
        }
        public bool OpenFilesFolder(string dataFolder)
        {
            bool folderCreated = false;
            string taskFolder = FileHelper.RemoveBadCharactersFromFileName(string.Format("{0} {1}", Id, ShortDescription));
            DirectoryInfo tasksFolder = new DirectoryInfo(Path.Combine(dataFolder, @"ProjectExplorer\Files\Tasks\", taskFolder));
            if (!tasksFolder.Exists)
            {
                tasksFolder.Create();
                FilesFolder = tasksFolder.ToString();
                folderCreated = true;
            }
            Process.Start("explorer", tasksFolder.ToString());
            return folderCreated;
        }

        public void CheckFilesFolder(string newShortDescription)
        {
            /*
             string dataFolder = 
            bool folderCreated = false;
            string taskFolder = FileHelper.RemoveBadCharactersFromFileName(string.Format("{0} {1}", Id, ShortDescription));
            DirectoryInfo tasksFolder = new DirectoryInfo(Path.Combine(dataFolder, @"ProjectExplorer\Files\Tasks\", taskFolder));
            if (tasksFolder.Exists)
            {
                string newTaskFolder = FileHelper.RemoveBadCharactersFromFileName(string.Format("{0} {1}", Id, newShortDescription));
                Directory.Move(taskFolder, newTaskFolder);
            }
             */
        }
    }
}
