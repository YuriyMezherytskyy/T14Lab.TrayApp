using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14.Task;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14Lab.Utils.NativeTheme;

namespace Tornado14.TrayApp.Controls
{
    public partial class ReportPanel : UserControl
    {
        public object SprintBindingSourceDataSource
        {
            get
            {

                return sprintBindingSource;
            }
            set
            {
                sprintBindingSource.DataSource = value;
                this.checkedListBoxSprintFilter.DataSource = sprintBindingSource;
                this.checkedListBoxSprintFilter.DisplayMember = "ShortDescription";
            }
        }

        public BindingSource ProjectBindingSource
        {
            get
            {
                return projectBindingSource;
            }
            set
            {
                projectBindingSource = value;
            }
        }

        public BindingSource TodoBindingSource
        {
            get
            {
                return todoBindingSource;
            }
            set
            {
                todoBindingSource = value;
            }
        }
        public ReportPanel()
        {
            InitializeComponent();
        }

        private List<Todo> GetTasksInStatus()
        {
            Project project = (Project)ProjectBindingSource.Current;

            List<Sprint> sprints = new List<Sprint>();
            foreach (Object sprint in this.checkedListBoxSprintFilter.CheckedItems)
            {
                sprints.Add((Sprint)sprint);
            }

            List<Status> statusList = new List<Status>();
            foreach (Object item in checkedListBoxStatus.CheckedItems)
            {
                statusList.Add((Status)Enum.Parse(typeof(Status), item.ToString()));
            }

            List<Todo> tasksInStatus = new List<Todo>();
            SortableBindingList<Todo> todos = (SortableBindingList<Todo>)todoBindingSource.DataSource;
            foreach (Sprint sprint in sprints)
            {
                if (sprint.Kanban != null)
                {
                    var tasks = from task in sprint.Kanban
                                where statusList.Contains(task.Status)
                                select task.TaskPid;
                    if (tasks.Count() > 0)
                    {
                        foreach (Guid todoPid in tasks.ToList())
                        {

                            var task = from todo in todos
                                       where todo.pId == todoPid
                                       select todo;

                            if (task.Count() > 0)
                            {
                                Todo todo = (Todo)task.First();
                                tasksInStatus.Add(todo);
                            }
                        }
                    }
                }
            }
            return tasksInStatus;
        }


        private void GetSprintReport()
        {
            SortableBindingList<Project> projects = (SortableBindingList<Project>)projectBindingSource.DataSource;

            if (this.checkedListBoxSprintFilter.CheckedItems.Count > 0)
            {
                if (checkedListBoxStatus.CheckedItems.Count > 0)
                {
                    List<Todo> todoList = GetTasksInStatus();
                    ReportScreen repostScreen = new ReportScreen(todoList, projects);
                    repostScreen.Show();
                }
                else
                {
                    Dictionary<Sprint, List<Todo>> sprintTodoList = new Dictionary<Sprint, List<Todo>>();
                    foreach (Object sprint in this.checkedListBoxSprintFilter.CheckedItems)
                    {
                        sprintTodoList.Add((Sprint)sprint, new List<Todo>());
                    }
                    Project project = (Project)ProjectBindingSource.Current;

                    SortableBindingList<Todo> todos = (SortableBindingList<Todo>)todoBindingSource.DataSource;


                    StringBuilder report = new StringBuilder();
                    foreach (KeyValuePair<Sprint, List<Todo>> sprint in sprintTodoList)
                    {
                        Dictionary<Status, int> tasksInStatus = new Dictionary<Status, int>();
                        if (sprint.Key.Kanban != null)
                        {
                            var tasks = from task in sprint.Key.Kanban
                                        orderby task.Status
                                        select task.TaskPid;
                            if (tasks.Count() > 0)
                            {
                                foreach (Guid todoPid in tasks.ToList())
                                {
                                    var task = from todo in todos
                                               where todo.pId == todoPid
                                               select todo;

                                    if (task.Count() > 0)
                                    {
                                        Todo todo = (Todo)task.First();
                                        sprint.Value.Add(todo);
                                    }
                                }
                            }
                        }
                    }
                    ReportScreen repostScreen = new ReportScreen(sprintTodoList, projects);
                    repostScreen.Show();

                }

            }
            else
            {
                MessageBox.Show("Select Sprint or Sprint Done Tasks", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        private void buttonReport_Click(object sender, EventArgs e)
        {
            GetSprintReport();
        }

        private void buttonGetDoneTask_Click(object sender, EventArgs e)
        {
            GetTasksInStatus();
        }

        private void checkedListBoxSprintFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
