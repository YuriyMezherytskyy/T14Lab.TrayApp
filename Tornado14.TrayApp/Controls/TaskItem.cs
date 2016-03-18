using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14.Task;
using Tornado14Lab.Utils.NativeTheme;
using System.Diagnostics;
using Tornado14.TrayApp.Properties;
using Tornado14.TrayApp.Controls;
using Tornado14Lab.Utils.DataGridViewHelper;
using System.IO;
using System.Text.RegularExpressions;

namespace Tornado14.TrayApp
{

    public partial class TaskItem : UserControl
    {
        public Color TaskColor { get; set; }
        public void SetA(int no)
        {
            labelTaskId.Text = no.ToString();
        }
        private Todo task;
        public Todo Task {
            get
            {
                return task;
            }
            set {
                task = value;
                labelTaskId.Text = value.Id;
                //textBox1.Text = value.ShortDescription;
                textBoxShortDescription.DataBindings.Add("Text", value, "ShortDescription", true);
                string toolTipText = string.Format("{0}\r\n\r\nResult:\r\n{1}", value.Description, value.Result);
                toolTip1.SetToolTip(pictureBox1, toolTipText);
            } 
        }
        private Project project;
        public Project Project {
            get
            {
                return this.project;
            }
            set
            {
                this.project = value;
                labelProjectName.Text = value.ShortDescription;
            }
        }
        public Sprint Sprint { get; set; } 

        //Check radius for begin drag n drop
        public bool AllowDrag { get; set; }
        private bool _isDragging = false;
        private int _DDradius = 40;
        private int _mX = 0;
        private int _mY = 0;

        public TaskItem()
        {
            InitializeComponent();
            TaskColor = BlackTheme.ColorLightGray;
            AllowDrag = true;
            
            SetBlackTheme();
        }

        #region TaskGridPanel Events

        // Declare an event 
        public event DeleteButtonClickedEventHandler DeleteButtonClicked;

        protected virtual void OnDeleteButtonClicked(DeleteButtonClickedEventArgs e)
        {
            if (DeleteButtonClicked != null)
                DeleteButtonClicked(this, e);
        }

        #endregion

        public void SetBlackTheme()
        {
            this.BackColor = TaskColor;
            this.ForeColor = BlackTheme.ColorText;
            labelProjectName.ForeColor = BlackTheme.ColorDarkGray;
            linkLabelFiles.LinkColor = BlackTheme.ColorDarkGray;
            panel1.BackColor = BlackTheme.ColorDarkGray;
            textBoxShortDescription.BackColor = TaskColor;
            textBoxShortDescription.ForeColor = BlackTheme.ColorText;
            textBoxShortDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            labelTaskId.ForeColor = BlackTheme.ColorDarkGray;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            this.BackColor = BlackTheme.ColorLightGray2;
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = TaskColor;
            
            base.OnLostFocus(e);
        }

        protected override void OnClick(EventArgs e)
        {
            this.Focus();
            base.OnClick(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.Focus();
            base.OnMouseDown(e);
            _mX = e.X;
            _mY = e.Y;
            this._isDragging = false;
            
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            this.BackColor = BlackTheme.ColorDarkGray2;
            this.textBoxShortDescription.BackColor = BlackTheme.ColorDarkGray2;
            if (!_isDragging)
            {
                //this.BackColor = BlackTheme.ColorHeaders2;
                // This is a check to see if the mouse is moving while pressed.
                // Without this, the DragDrop is fired directly when the control is clicked, now you have to drag a few pixels first.
                if (e.Button == MouseButtons.Left && _DDradius > 0 && this.AllowDrag)
                {
                    int num1 = _mX - e.X;
                    int num2 = _mY - e.Y;
                    if (((num1 * num1) + (num2 * num2)) > _DDradius)
                    {
                        DoDragDrop(this, DragDropEffects.All);
                        _isDragging = true;
                        return;
                    }
                }
                base.OnMouseMove(e);
            }
            
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.textBoxShortDescription.BackColor = TaskColor;
            this.BackColor = TaskColor;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _isDragging = false;
            base.OnMouseUp(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DeleteButtonClickedEventArgs args = new DeleteButtonClickedEventArgs();
            args.KanbanPosition = (KanbanPosition)this.Tag;
            args.TaskItem = this;

            OnDeleteButtonClicked(args);
        }

        private void linkLabelFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Task.OpenFilesFolder(Settings.Default.DataFolder))
            {
                // TODO Do something with that
                //HasChanges = true;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);
        }

        private void textBoxShortDescription_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        private void textBoxShortDescription_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }
        public bool Checked { get; set; }
        
        private void TaskItem_Load(object sender, EventArgs e)
        {

        }

        private void TaskItem_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
            if (Checked)
            {
                pictureBox1.BackColor = BlackTheme.ColorTextNotifyBlue;
            }
            else
            {
                pictureBox1.BackColor = Color.Transparent;
            }
        }

        private void labeEdit_Click(object sender, EventArgs e)
        {
            SortableBindingList<Todo> todos = new SortableBindingList<Todo>();
            todos.Add(Task);
            EditTaskDialog editTaskDialog = new EditTaskDialog(todos);
            editTaskDialog.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            bool test = true;
            Process compiler = new Process();
            compiler.StartInfo.FileName = "svn";
            compiler.StartInfo.Arguments = "log";
            compiler.StartInfo.UseShellExecute = false;
            compiler.StartInfo.RedirectStandardOutput = true;
            compiler.Start();

            string output = compiler.StandardOutput.ReadToEnd();

            FileInfo testOutput = new FileInfo(@"c:\temp\output.txt");
            StreamReader projectsXmlFileReader = new StreamReader(testOutput.FullName);
            output = projectsXmlFileReader.ReadToEnd();
            string[] splitArray = null;
            try
            {
                splitArray = Regex.Split(output, @"-{72}", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Multiline);
            }
            catch (ArgumentException ex)
            {
                // Syntax error in the regular expression
            }


            List<CommitInfo> commits = new List<CommitInfo>();
            foreach (string commit in splitArray)
            {
                if (commit.Length > 3)
                {
                    string header = commit.Trim();
                    string coHeader = "";
                    if (header.IndexOf("\r\n", 0) < 0)
                    {
                        coHeader = header;
                    }
                    else
                    {
                        coHeader = header.Substring(0, header.IndexOf("\r\n", 0));
                    }
                    string[] headers = coHeader.Split('|');
                    string id = headers[0].Trim();
                    string name = headers[1].Trim();
                    string date = headers[2].Trim();
                    string lineCount = headers[3].Trim();
                    if (test)
                    {
                        FileInfo cmdOutput = new FileInfo(@"c:\temp\logwithfiles.txt");
                        StreamReader reader = new StreamReader(cmdOutput.FullName);
                        string commitFiles = reader.ReadToEnd();

                        List<string> resultList = new List<string>();
                        try
                        {
                            Regex regexObj = new Regex(@"([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                            Match matchResult = regexObj.Match(commitFiles);
                            while (matchResult.Success)
                            {
                                resultList.Add(matchResult.Value);
                                matchResult = matchResult.NextMatch();
                            }
                        }
                        catch (ArgumentException ex)
                        {
                            // Syntax error in the regular expression
                        }

                        
                        foreach (string commit2 in resultList)
                        {
                            CommitInfo co = new CommitInfo();
                            co.Id = id;
                            co.Who = name;
                            co.Date = date;
                            co.LineCount = lineCount;
                            co.Path = commit2;
                            commits.Add(co);
                        }
                        test = false;
                    }
                }
            }
            CommitedFilesSelection selectionDialog = new CommitedFilesSelection(commits);
            selectionDialog.Show();
        }

        private void textBoxShortDescription_TextChanged(object sender, EventArgs e)
        {
            int a = 0;
        }        

    }

    public class DeleteButtonClickedEventArgs
    {
        public TaskItem TaskItem { get; set; }
        public KanbanPosition KanbanPosition { get; set; }
    }
    public delegate void DeleteButtonClickedEventHandler(object sender, DeleteButtonClickedEventArgs e);

}
