using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tornado14.Task;
using System.Text.RegularExpressions;
using Tornado14Lab.Utils.DataGridViewHelper;

namespace Tornado14.TrayApp.Controls.Task
{
    public partial class AddTasks : UserControl, IStandardPanel
    {
        public ProjectExplorer parentPanel { get; set; }

        public AddTasks()
        {
            InitializeComponent();
        }

        internal void SetBindingSources(object projectDataSource, object sprintDataSource, object taskDataSource)
        {
            this.todoBindingSource.DataSource = taskDataSource;
            this.sprintBindingSource.DataSource = sprintDataSource;
            this.projectBindingSource.DataSource = projectDataSource;

            AddTasksEditor.CustomEditor.HeaderText = "New Tasks";
            SortableBindingList<Project> allProjects = (SortableBindingList<Project>)projectBindingSource.List;


            List<CompletionItem> comletionList = new List<CompletionItem>();

            foreach (object obj in todoBindingSource.List)
            {
                Todo task = (Todo)obj;
                Project taskProject = allProjects.First(p => p.pId == task.ProjectPid);
                CompletionItem completionItem2 = new CompletionItem()
                {
                    DisplayText = string.Format("{0} ({1})", task.Id, task.ShortDescription),
                    PopUpText = string.Format("{3}\n{2}\n-----\n{1}\n-----\n{0}", task.Description, task.ShortDescription, task.Id, taskProject.Description),
                    ReplacementText = task.Id
                };
                comletionList.Add(completionItem2);

                CompletionItem completionItem = new CompletionItem()
                {
                    DisplayText = string.Format("{1} ({0})", task.Id, task.ShortDescription),
                    PopUpText = string.Format("{3}\n{2}\n-----\n{1}\n-----\n{0}", task.Description, task.ShortDescription, task.Id, taskProject.Description),
                    ReplacementText = task.Description
                };
                comletionList.Add(completionItem);

            }

            foreach (object obj in projectBindingSource.List)
            {
                Project project = (Project)obj;
                CompletionItem completionItem2 = new CompletionItem() { DisplayText = project.ShortDescription, PopUpText = project.Description, ReplacementText = project.Id };
                comletionList.Add(completionItem2);

            }

            foreach (object obj in sprintBindingSource.List)
            {
                Sprint sprint = (Sprint)obj;
                CompletionItem completionItem2 = new CompletionItem() { DisplayText = sprint.ShortDescription, PopUpText = sprint.Description, ReplacementText = sprint.Id };
                comletionList.Add(completionItem2);

            }

            AddTasksEditor.FillComletionList(comletionList);
        }

        private void buttonAddTasks_Click(object sender, EventArgs e)
        {
            string parsedText = AddTasksEditor.Text;
            List<Todo> newTodos = new List<Todo>();

            try
            {
                Regex regexObj = new Regex("//([^}]*).*{([^}]*)}");
                Match searchTasks = regexObj.Match(parsedText);
                while (searchTasks.Success)
                {
                    string taskProperties = string.Empty;
                    string taskName = string.Empty;
                    string taskDescription = string.Empty;
                    string step1 = string.Empty;
                    // //.*
                    // .*{

                    // matched text: matchResults.Value
                    // match start: matchResults.Index
                    // match length: matchResults.Length


                    string searchProperties = searchTasks.Value;
                    try
                    {
                        Match result = Regex.Match(parsedText, "//.*");
                        taskProperties = result.Value.Replace("//", string.Empty).Trim();
                        step1 = searchTasks.Value.Remove(result.Index, result.Length);
                        
                        try
                        {
                            Match searchTaskDescription = Regex.Match(step1, "{([^}]*)}");
                            taskName = step1.Remove(searchTaskDescription.Index, searchTaskDescription.Length).Trim();
                            taskDescription = searchTaskDescription.Value.TrimStart('{').TrimEnd('}');




                        }
                        catch (ArgumentException ex)
                        {
                            // Syntax error in the regular expression
                        }


                        int a = 0;
                    }
                    catch (ArgumentException ex)
                    {
                        // Syntax error in the regular expression
                    }
                    searchTasks = searchTasks.NextMatch();
                }
            }
            catch (ArgumentException ex)
            {
                // Syntax error in the regular expression
            }

        }
    }
}
