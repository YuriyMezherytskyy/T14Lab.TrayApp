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
using Tornado14Lab.Utils.NativeTheme;

namespace Tornado14.TrayApp.Controls.Task
{
    public partial class AddTasks : UserControl, IStandardPanel
    {
        public ProjectExplorer parentPanel { get; set; }

        private List<string> projectIdList;
        private List<string> sprintIdList;

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



            List<CompletionItem> comletionList = new List<CompletionItem>();

            foreach (object obj in todoBindingSource.List)
            {
                Todo task = (Todo)obj;
                CompletionItem completionItem2 = new CompletionItem()
                {
                    DisplayText = string.Format("{0} ({1})", task.Id, task.ShortDescription),
                    PopUpText = string.Format("{3}\n{2}\n-----\n{1}\n-----\n{0}", task.Description, task.ShortDescription, task.Id, task.Description),
                    ReplacementText = task.Id
                };
                comletionList.Add(completionItem2);

                CompletionItem completionItem = new CompletionItem()
                {
                    DisplayText = string.Format("{1} ({0})", task.Id, task.ShortDescription),
                    PopUpText = string.Format("{3}\n{2}\n-----\n{1}\n-----\n{0}", task.Description, task.ShortDescription, task.Id, task.Description),
                    ReplacementText = task.Description
                };
                comletionList.Add(completionItem);

            }

            foreach (object obj in projectBindingSource.List)
            {
                Project project = (Project)obj;
                CompletionItem completionItem2 = new CompletionItem()
                {
                    DisplayText = string.Format("{0} ({1})", project.Id, project.ShortDescription),
                    PopUpText = string.Format("{3}\n{2}\n-----\n{1}\n-----\n{0}", project.Description, project.ShortDescription, project.Id, project.Description),
                    ReplacementText = project.Id
                };
                comletionList.Add(completionItem2);

                CompletionItem completionItem = new CompletionItem()
                {
                    DisplayText = string.Format("{1} ({0})", project.Id, project.ShortDescription),
                    PopUpText = string.Format("{3}\n{2}\n-----\n{1}\n-----\n{0}", project.Description, project.ShortDescription, project.Id, project.Description),
                    ReplacementText = project.Description
                };
                comletionList.Add(completionItem2);

            }

            foreach (object obj in sprintBindingSource.List)
            {
                Sprint sprint = (Sprint)obj;
                CompletionItem completionItem2 = new CompletionItem()
                {
                    DisplayText = string.Format("{0} ({1})", sprint.Id, sprint.ShortDescription),
                    PopUpText = string.Format("{3}\n{2}\n-----\n{1}\n-----\n{0}", sprint.Description, sprint.ShortDescription, sprint.Id, sprint.Description),
                    ReplacementText = sprint.Id
                };
                comletionList.Add(completionItem2);

                CompletionItem completionItem = new CompletionItem()
                {
                    DisplayText = string.Format("{1} ({0})", sprint.Id, sprint.ShortDescription),
                    PopUpText = string.Format("{3}\n{2}\n-----\n{1}\n-----\n{0}", sprint.Description, sprint.ShortDescription, sprint.Id, sprint.Description),
                    ReplacementText = sprint.Description
                };
                comletionList.Add(completionItem2);

            }

            AddTasksEditor.FillComletionList(comletionList);
        }

        private void buttonAddTasks_Click(object sender, EventArgs e)
        {
            string parsedText = AddTasksEditor.Text;
            SortableBindingList<Todo> newTodos = new SortableBindingList<Todo>();

            sprintIdList = new List<string>();
            foreach (object obj in sprintBindingSource.List)
            {
                sprintIdList.Add(((Sprint)obj).Id);
            }
            projectIdList = new List<string>();
            foreach (object obj in projectBindingSource.List)
            {
                projectIdList.Add(((Project)obj).Id);
            }

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

            SortableBindingList<Project> projects = (SortableBindingList<Project>)projectBindingSource.DataSource;

            // generate id,s
            List<string> ids = new List<string>();
            foreach (Todo t in todoBindingSource.List)
            {
                ids.Add(t.Id);
            }
            ids.Sort();
            string lastId = ids.Last();
            int count = int.Parse(lastId.Split('-')[1]) + 1;

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
                            string[] descriptionItems = taskDescription.Split(new[] { "-----" }, StringSplitOptions.None);
                            string istZustand = string.Empty;
                            string sollZustand = string.Empty;
                            string recherche = string.Empty;
                            string resultat = string.Empty;
                            if (descriptionItems.Length >= 1)
                            {
                                List<string> words = new List<string>() {
                                    "Ist Zustand:",
                                    "Ist:",
                                    "Soll Zustand:",
                                    "Recherche:",
                                    "Resultat:",
                                    "Soll:"
                                };
                                foreach (string item in descriptionItems)
                                {
                                    string found = string.Empty;
                                    words.ForEach(delegate (String word)
                                    {
                                        if (item.Contains(word))
                                        {
                                            found = word;
                                        }
                                    });
                                    switch (found)
                                    {
                                        case "Ist Zustand:":
                                            istZustand = item.Replace("Ist Zustand:", string.Empty).Trim();
                                            break;
                                        case "Ist:":
                                            istZustand = item.Replace("Ist:", string.Empty).Trim();
                                            break;
                                        case "Soll:":
                                            sollZustand = item.Replace("Soll:", string.Empty).Trim();
                                            break;
                                        case "Soll Zustand:":
                                            sollZustand = item.Replace("Soll Zustand:", string.Empty).Trim();
                                            break;
                                        case "Recherche:":
                                            recherche = item.Replace("Recherche:", string.Empty).Trim();
                                            break;
                                        case "Resultat:":
                                            resultat = item.Replace("Resultat:", string.Empty).Trim();
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                            else if (descriptionItems.Length <= 1)
                            {
                                sollZustand = descriptionItems[0];
                            }

                            Todo newTodo = new Todo()
                            {
                                Id = string.Format("{0}-{1}", lastId.Split('-')[0], count++),
                                pId = Guid.NewGuid(),
                                ShortDescription = taskName,
                                Description = sollZustand,
                                CurrentState = istZustand,
                                PublicText = recherche,
                                Result = resultat,
                            };
                            string projectId = string.Empty;
                            string sprintId = string.Empty;

                            string text1 = taskProperties.Trim();
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


                            var projects1 = from p in projects where p.Id.ToLower() == projectId.ToLower() select p;
                            Project project = null;
                            if (projects1.Count() > 0)
                            {
                                project = (Project)projects1.First();
                                newTodo.ProjectPid = project.pId;
                            }
                            else
                            {
                                newTodo.ProjectPid = Guid.Empty;
                            }

                            SortableBindingList<Sprint> sprints = (SortableBindingList<Sprint>)sprintBindingSource.DataSource;
                            var sprints1 = from s in sprints where s.Id.ToLower() == sprintId.ToLower() select s;
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
                                newPosition.TaskPid = newTodo.pId;
                                newPosition.Position = lastPosition2 + 1;
                                newPosition.Status = Status.Planned;
                                sprint.Kanban.Add(newPosition);
                                newTodo.SprintPid = sprint.pId;
                                newTodos.Add(newTodo);
                            }
                            int ggg = 0;


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

                ConfirmTasks confirmationForm = new ConfirmTasks();
                confirmationForm.SetBindingSources(projectBindingSource.DataSource, sprintBindingSource.DataSource, newTodos);
                if (confirmationForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (Todo todo in confirmationForm.Todos)
                    {
                        todoBindingSource.Add(todo);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                // Syntax error in the regular expression
            }

        }
    }
}
