using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14.Task;
using Tornado14Lab.Utils.NativeTheme;
using Tornado14Lab.Utils.DataGridViewHelper;

namespace Tornado14.TrayApp.Controls
{
    public partial class ReportScreen : Form
    {
        public ReportScreen()
        {
            InitializeComponent();
        }
        SortableBindingList<Project> projects = new SortableBindingList<Project>();

        public ReportScreen(List<Todo> tasks, SortableBindingList<Project> projects)
        {
            InitializeComponent();
            this.projects = projects;
            CheckedListBox checkedListBox = new CheckedListBox();
            checkedListBox.BorderStyle = BorderStyle.None;
            checkedListBox.BackColor = BlackTheme.ColorDarkGray;
            checkedListBox.ForeColor = BlackTheme.ColorText;
            checkedListBox.Dock = DockStyle.Fill;

            checkedListBox.DataSource = tasks;
            checkedListBox.DisplayMember = "ShortDescription";
            splitContainer1.Panel2.Controls.Clear();
            Button selectAllButton = new Button();
            selectAllButton.Text = "Select All";
            selectAllButton.Height = 29;
            selectAllButton.FlatStyle = FlatStyle.Flat;
            selectAllButton.Click += selectAllButton_Click;
            selectAllButton.Dock = DockStyle.Top;
            selectAllButton.ForeColor = Color.White;
            Button deselectAllButton = new Button();
            deselectAllButton.Text = "Deselect All";
            deselectAllButton.Height = 29;
            deselectAllButton.FlatStyle = FlatStyle.Flat;
            deselectAllButton.Click += deselectAllButton_Click;
            deselectAllButton.Dock = DockStyle.Top;
            deselectAllButton.ForeColor = Color.White;

            splitContainer1.Panel2.Controls.Add(selectAllButton);
            splitContainer1.Panel2.Controls.Add(deselectAllButton);
            splitContainer1.Panel2.Controls.Add(checkedListBox);
            BlackTheme.ApplyTheme(this);
        }

        void deselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                if (control.GetType() == typeof(CheckedListBox))
                {
                    CheckedListBox checkedlistBox = (CheckedListBox)control;
                    for (int i = 1; i < checkedlistBox.Items.Count; i++)
                        checkedlistBox.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                if (control.GetType() == typeof(CheckedListBox))
                {
                    CheckedListBox checkedlistBox = (CheckedListBox)control;
                    for (int i = 1; i < checkedlistBox.Items.Count; i++)
                        checkedlistBox.SetItemChecked(i, true);
                }
            }
        }

        Dictionary<Sprint, List<Todo>> sprintTaskList = new Dictionary<Sprint, List<Todo>>();

        public ReportScreen(Dictionary<Sprint, List<Todo>> sprintTaskList, SortableBindingList<Project> projects)
        {
            InitializeComponent();

            this.sprintTaskList = sprintTaskList;

            this.projects = projects;
            //this.checkedListBoxFilteredTasksInStatus.DataSource = tasks;
            //this.checkedListBoxFilteredTasksInStatus.DisplayMember = "ShortDescription";

            splitContainer1.Panel2.Controls.Clear();

            Button selectAllButton = new Button();
            selectAllButton.Text = "Select All";
            selectAllButton.Height = 29;
            selectAllButton.FlatStyle = FlatStyle.Flat;
            selectAllButton.Click += selectAllButton_Click;
            selectAllButton.Dock = DockStyle.Top;
            selectAllButton.ForeColor = Color.White;
            Button deselectAllButton = new Button();
            deselectAllButton.Text = "Deselect All";
            deselectAllButton.Height = 29;
            deselectAllButton.FlatStyle = FlatStyle.Flat;
            deselectAllButton.Click += deselectAllButton_Click;
            deselectAllButton.Dock = DockStyle.Top;
            deselectAllButton.ForeColor = Color.White;

            splitContainer1.Panel2.Controls.Add(selectAllButton);
            splitContainer1.Panel2.Controls.Add(deselectAllButton);
            foreach (KeyValuePair<Sprint, List<Todo>> st in sprintTaskList)
            {
                CheckedListBox checkedListBox = new CheckedListBox();
                checkedListBox.BorderStyle = BorderStyle.None;
                checkedListBox.BackColor = BlackTheme.ColorDarkGray;
                checkedListBox.ForeColor = BlackTheme.ColorText;
                checkedListBox.Dock = DockStyle.Top;
                checkedListBox.Height = 300;

                checkedListBox.DataSource = st.Value;
                checkedListBox.Tag = st.Key;
                checkedListBox.DisplayMember = "ShortDescription";
                Label sprintLabel = new Label();
                sprintLabel.Text = st.Key.ShortDescription;
                sprintLabel.ForeColor = BlackTheme.ColorTextNotifyBlue;
                sprintLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
                sprintLabel.AutoSize = false;
                sprintLabel.Height = 40;
                sprintLabel.Dock = DockStyle.Top;
                splitContainer1.Panel2.Controls.Add(sprintLabel);
                sprintLabel.BringToFront();
                splitContainer1.Panel2.Controls.Add(checkedListBox);
                checkedListBox.BringToFront();
            }

            RenderSprintTodoList(sprintTaskList);
            BlackTheme.ApplyTheme(this);
        }

        private void RenderSprintTodoList(Dictionary<Sprint, List<Todo>> sprintTaskList)
        {
            StringBuilder report = new StringBuilder();
            foreach (KeyValuePair<Sprint, List<Todo>> sprintTodos in sprintTaskList)
            {
                Dictionary<Status, int> tasksInStatus = new Dictionary<Status, int>();
                AppendLine(string.Format("Sprint: {0}", sprintTodos.Key.ShortSummary), BlackTheme.mGreenLight1);
                if (sprintTodos.Key.Kanban != null)
                {
                    Status lastStatus = Status.Unknown;
                    foreach (Todo todo in sprintTodos.Value)
                    {
                        if (todo.Status != lastStatus)
                        {
                            lastStatus = todo.Status;
                            if (checkBoxEmptyLines.Checked)
                            {
                                AppendLine("", BlackTheme.ColorDarkGray);
                            }
                            AppendLine(string.Format("Status: {0}", todo.Status.ToString()), BlackTheme.mGreenLight2);
                        }
                        renderTask(todo);
                        if (!tasksInStatus.ContainsKey(todo.Status))
                        {
                            tasksInStatus.Add(todo.Status, 1);
                        }
                        else
                        {
                            tasksInStatus[todo.Status]++;
                        }
                    }

                    if (checkBoxEmptyLines.Checked)
                    {
                        AppendLine(string.Format(""), BlackTheme.ColorDarkGray);
                    }
                    if (checkBoxHeaders.Checked)
                    {
                        AppendLine("Sprint Summary: ", BlackTheme.mGreenLight2);
                    }
                    foreach (KeyValuePair<Status, int> item in tasksInStatus)
                    {
                        AppendLine(string.Format("{0}: {1} Tasks", item.Key.ToString(), item.Value), BlackTheme.mGreenLight2);
                    }
                    if (checkBoxEmptyLines.Checked)
                    {
                        AppendLine(string.Format(""), BlackTheme.ColorDarkGray);
                        AppendLine(string.Format(""), BlackTheme.ColorDarkGray);
                    }
                }
            }
            BlackTheme.ApplyTheme(this);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGetDoneTask_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != null)
            {
                Clipboard.SetText(TextBox1.Text);
            }
        }

        public void AppendText(string text, Color color)
        {
            this.TextBox1.SelectionStart = this.TextBox1.TextLength;
            this.TextBox1.SelectionLength = 0;

            this.TextBox1.SelectionColor = color;
            this.TextBox1.AppendText(text);
            this.TextBox1.SelectionColor = this.TextBox1.ForeColor;
        }

        public void AppendLine(string text, Color color)
        {
            this.TextBox1.SelectionStart = this.TextBox1.TextLength;
            this.TextBox1.SelectionLength = 0;

            this.TextBox1.SelectionColor = color;
            this.TextBox1.AppendText(text + "\r\n");
            this.TextBox1.SelectionColor = this.TextBox1.ForeColor;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            List<Todo> todoList = new List<Todo>();
            Dictionary<Sprint, List<Todo>> sprintTodoList = new Dictionary<Sprint, List<Todo>>();
            if (sprintTaskList.Count > 0)
            {
                sprintTodoList = sprintTaskList;
            }
            else
            {
                int listBoxCount = 0;
                foreach (Control control in splitContainer1.Panel2.Controls)
                {
                    if (control.GetType() == typeof(CheckedListBox))
                    {
                        listBoxCount++;
                        CheckedListBox checkedListbox = (CheckedListBox)control;
                        Sprint sprint = null;
                        if (checkedListbox.Tag != null && checkedListbox.Tag.GetType() == typeof(Sprint))
                        {
                            sprint = (Sprint)checkedListbox.Tag;
                            if (!sprintTodoList.Keys.Contains(sprint))
                            {
                                sprintTodoList.Add(sprint, new List<Todo>());
                            }
                        }
                        foreach (Object obj in checkedListbox.CheckedItems)
                        {
                            Todo task = (Todo)obj;
                            if (sprint != null)
                            {
                                sprintTodoList[sprint].Add(task);
                            }
                            if (!todoList.Contains(task))
                            {
                                todoList.Add(task);
                            }
                        }
                    }
                }
            }

            if (sprintTodoList.Count < 1)
            {
                foreach (Todo task in todoList)
                {
                    renderTask(task);
                }
            }
            else
            {
                RenderSprintTodoList(sprintTodoList);
            }
        }


        private void renderTask(Todo todo)
        {
            var taskProject = from p in projects
                              where p.pId == todo.ProjectPid
                              select p;
            Color textColor = BlackTheme.ColorText;
            if (checkBoxBlackText.Checked)
            {
                textColor = Color.Black;
            }

            if (checkBoxTaskShortDescription.Checked)
            {
                if (checkBoxHeaders.Checked) AppendLine("Task: ", BlackTheme.ColorTextNotifyBlue);
                if (checkBoxTaskId.Checked)
                {
                    AppendText(string.Format("{0} ", todo.Id), textColor);
                }
                if (checkBoxTaskStatus.Checked)
                {
                    AppendText(string.Format("[{0}] ", todo.Status.ToString()), textColor);
                }
                AppendText(string.Format("{0}\r\n", todo.ShortDescription), textColor);
            }
            if (checkBoxProjectName.Checked)
            {
                if (checkBoxHeaders.Checked) AppendText("Project: ", BlackTheme.ColorTextNotifyBlue);
                AppendLine(string.Format("{0}", taskProject.First().ShortDescription), textColor);
            }
            if (checkBoxIstZustand.Checked)
            {
                if (checkBoxHeaders.Checked) AppendLine("Ist Zustand: ", BlackTheme.ColorTextNotifyBlue);
                AppendLine(string.Format("{0}", todo.CurrentState), textColor);
            }
            if (checkBoxTaskSollZustand.Checked)
            {
                if (checkBoxHeaders.Checked) AppendLine("Soll Zustand: ", BlackTheme.ColorTextNotifyBlue);
                AppendLine(string.Format("{0}", todo.Description), textColor);
            }
            if (checkBoxTaskResult.Checked)
            {
                if (checkBoxHeaders.Checked) AppendLine("Resultat: ", BlackTheme.ColorTextNotifyBlue);
                AppendLine(string.Format("{0}", todo.Result), textColor);
            }
            if (checkBoxTaskPublicText.Checked)
            {
                if (checkBoxHeaders.Checked) AppendLine("Public Text: ", BlackTheme.ColorTextNotifyBlue);
                AppendLine(string.Format("{0}", todo.PublicText), textColor);
            }
            if (checkBoxEmptyLines.Checked)
            {
                AppendLine(string.Format(""), BlackTheme.ColorDarkGray);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
        }

    }
}
