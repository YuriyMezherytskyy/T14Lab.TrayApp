using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Tornado14Lab.Utils;
using Tornado14.Task;
using System.Text.RegularExpressions;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14.TrayApp.Properties;
using Tornado14Lab.Utils.NativeTheme;
using Tornado14.TrayApp.Controls;

namespace Tornado14.TrayApp
{
    public partial class AddNewTasks : UserControl, IStandardPanel
    {
        public ProjectExplorer parentPanel { get; set; }

        private List<string> projectIdList;
        private List<string> sprintIdList;
        private DirectoryInfo dataFolder;
        private string sprintXmlFile;
        private string todoXmlFile;
        private string projectXmlFile;

        internal void SetTodoBindingSource(object dataSource)
        {
            this.todoBindingSource.DataSource = dataSource;
        }


        internal void SetSprintBindingSource(object dataSource)
        {
            this.sprintBindingSource.DataSource = dataSource;
        }

        internal void SetProjectBindingSource(object dataSource)
        {
            this.projectBindingSource.DataSource = dataSource;
        }

        public AddNewTasks()
        {
            InitializeComponent();

            projectIdList = new List<string>();
            foreach (object obj in projectBindingSource.List)
            {
                projectIdList.Add(((Project)obj).Id);
            }
            sprintIdList = new List<string>();
            foreach (object obj in sprintBindingSource.List)
            {
                sprintIdList.Add(((Sprint)obj).Id);
            }
            spelledMultilineTextbox1.AddKeywords(projectIdList, sprintIdList);
            this.BackColor = BlackTheme.ColorDarkGray;
            this.ForeColor = BlackTheme.ColorText;
            BlackTheme.ApplyTheme(this);
        }


        public List<Todo> ParseTasks(out string summary)
        {
            summary = string.Empty;
            int lastPosition = spelledMultilineTextbox1.Textbox.SelectionStart;
            List<Todo> result = new List<Todo>();
            List<string> tasks = new List<string>();
            string task = string.Empty;
            string text = spelledMultilineTextbox1.Textbox.Text;
            using (StringReader reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("--"))
                    {
                        if (task != string.Empty)
                        {
                            tasks.Add(task);
                            task = string.Empty;
                        }
                        task = string.Format("{0}{1}{2}", task, "\n", line).Replace("--", string.Empty);
                    }
                    else
                    {
                        task = string.Format("{0}{1}{2}", task, "\n", line);
                    }
                }
            }

            if (task != string.Empty)
            {
                tasks.Add(task);
                task = string.Empty;
            }
            spelledMultilineTextbox1.Textbox.Select(0, spelledMultilineTextbox1.Textbox.TextLength);
            spelledMultilineTextbox1.Textbox.SelectionColor = BlackTheme.ColorText;
            string projectsRegex = string.Empty;
            for (int i = 0; i < projectIdList.Count; i++)
            {
                string strKeyword = projectIdList[i];

                if (i == projectIdList.Count - 1)
                    projectsRegex += "\\b" + strKeyword + "\\b";
                else
                    projectsRegex += "\\b" + strKeyword + "\\b|";
            }

            string sptintsRegex = string.Empty;
            for (int i = 0; i < sprintIdList.Count; i++)
            {
                string strKeyword = sprintIdList[i];

                if (i == sprintIdList.Count - 1)
                    sptintsRegex += "\\b" + strKeyword + "\\b";
                else
                    sptintsRegex += "\\b" + strKeyword + "\\b|";
            }

            foreach (string newTask in tasks)
            {
                string text1 = newTask.Trim();
                string projectId = string.Empty;
                string sprintId = string.Empty;
                string shortDescription = string.Empty;
                string description = string.Empty;
                string currentState = string.Empty;
                Regex regKeywords = new Regex(projectsRegex, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                Match regMatch;

                for (regMatch = regKeywords.Match(text1); regMatch.Success; regMatch = regMatch.NextMatch())
                {
                    // Process the words
                    int nStart = regMatch.Index;
                    int nLenght = regMatch.Length;
                    projectId = text1.Substring(nStart, nLenght);
                    text1 = text1.Remove(nStart, nLenght);
                }
                Regex regKeywords2 = new Regex(sptintsRegex, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                for (regMatch = regKeywords2.Match(text1); regMatch.Success; regMatch = regMatch.NextMatch())
                {
                    // Process the words
                    int nStart = regMatch.Index;
                    int nLenght = regMatch.Length;
                    sprintId = text1.Substring(nStart, nLenght);
                    text1 = text1.Remove(nStart, nLenght);
                }
                int firstBrake = text1.IndexOf("\n");
                if (firstBrake < 0)
                {
                    firstBrake = shortDescription.Trim().Length;
                }
                shortDescription = text1.Substring(0, firstBrake).Trim();

                description = text1.Trim().Remove(0, firstBrake).Trim();
                if (description.Contains("**"))
                {
                    int firstBrake2 = description.Trim().IndexOf("\n");
                    currentState = description.Substring(0, firstBrake2 + 1).Trim();
                    currentState = currentState.Replace("**", string.Empty).Trim();
                    description = description.Substring((firstBrake2 + 1), description.Length - (firstBrake2 + 1)).Trim();
                }

                Todo todo = new Todo();
                todo.pId = Guid.NewGuid();
                todo.ShortDescription = shortDescription;
                todo.Description = description;
                todo.CurrentState = currentState;
                SortableBindingList<Project> projects = (SortableBindingList<Project>)projectBindingSource.DataSource;
                var projects1 = from p in projects where p.Id == projectId.ToUpper() select p;
                Project project = null;
                summary += string.Format("\r\n- {0}", todo.ShortDescription);
                if (projects1.Count() > 0)
                {
                    project = (Project)projects1.First();
                    todo.ProjectPid = project.pId;
                    summary += string.Format("[{0}{1}]", project.Id, project.ShortDescription);
                }

                SortableBindingList<Sprint> sprints = (SortableBindingList<Sprint>)sprintBindingSource.DataSource;
                var sprints1 = from s in sprints where s.Id == sprintId.ToUpper() select s;
                if (sprints1.Count() > 0)
                {
                    Sprint sprint = (Sprint)sprints1.First();
                    int lastPosition2 = 0;
                    foreach (KanbanPosition kanbanPosition in sprint.Kanban)
                    {
                        if (kanbanPosition.Status == Status.Todo)
                        {
                            if (kanbanPosition.Position > lastPosition2)
                            {
                                lastPosition2 = kanbanPosition.Position;
                            }
                        }
                    }
                    KanbanPosition newPosition = new KanbanPosition();
                    newPosition.TaskPid = todo.pId;
                    newPosition.Position = lastPosition2 + 1;
                    newPosition.Status = Status.Planned;
                    sprint.Kanban.Add(newPosition);
                    //todo.SprintPid = sprint.pId;
                    summary += string.Format(" - {0} {1} {2}", sprint.Id, sprint.ShortDescription, newPosition.Status);
                }
                result.Add(todo);
                summary += "\r\n";
            }
            spelledMultilineTextbox1.Textbox.SelectionStart = lastPosition;
            return result;
        }


    }
}
