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

namespace Tornado14.TrayApp.Controls.Task
{
  public partial class AddNewTasks : UserControl, IStandardPanel
  {
    public ProjectExplorer parentPanel { get; set; }

    private List<string> projectIdList;
    private List<string> sprintIdList;


    internal void SetBindingSources(object projectDataSource, object sprintDataSource, object taskDataSource)
    {
      this.todoBindingSource.DataSource = taskDataSource;
      this.sprintBindingSource.DataSource = sprintDataSource;

      sprintIdList = new List<string>();
      foreach (object obj in sprintBindingSource.List)
      {
        sprintIdList.Add(((Sprint)obj).Id);
      }
      this.projectBindingSource.DataSource = projectDataSource;
      projectIdList = new List<string>();
      foreach (object obj in projectBindingSource.List)
      {
        projectIdList.Add(((Project)obj).Id);
      }
      spelledMultilineTextbox1.AddKeywords(projectIdList, sprintIdList);
    }

    public AddNewTasks()
    {
      InitializeComponent();

      this.BackColor = BlackTheme.ColorDarkGray;
      this.ForeColor = BlackTheme.ColorText;
      BlackTheme.ApplyTheme(this);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <example>
    /// --Task1 btmp-1005 btms-1001 
    /// **description 1
    /// description 2 long
    /// long
    /// 
    /// --Task2 btmp-1005 btms-1001 
    /// **description 1
    /// description 2 long
    /// long
    /// </example>
    /// <param name="summary"></param>
    /// <returns></returns>
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
        var projects1 = from p in projects where p.Id == projectId.ToLower() select p;
        Project project = null;
        summary += string.Format("\r\n- {0}", todo.ShortDescription);
        if (projects1.Count() > 0)
        {
          project = (Project)projects1.First();
          todo.ProjectPid = project.pId;
          summary += string.Format("[{0}{1}]", project.Id, project.ShortDescription);
        }
        else
        {
          summary += "[Unknown Project]";
        }

        SortableBindingList<Sprint> sprints = (SortableBindingList<Sprint>)sprintBindingSource.DataSource;
        var sprints1 = from s in sprints where s.Id == sprintId.ToLower() select s;
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
        else
        {
          summary += "[Unknown Sprint]";
        }
        result.Add(todo);
        summary += "\r\n";
      }
      spelledMultilineTextbox1.Textbox.SelectionStart = lastPosition;
      return result;
    }

    private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      object boundItem = ((DataGridView)sender).Rows[e.RowIndex].DataBoundItem;
      if (boundItem != null)
      {
        if (boundItem.GetType() == typeof(Project))
        {
          string text = string.Format("{0} ", ((Project)boundItem).Id);
          int position = spelledMultilineTextbox1.Textbox.SelectionStart;
          spelledMultilineTextbox1.Textbox.Text = spelledMultilineTextbox1.Textbox.Text.Insert(position, text);
          spelledMultilineTextbox1.Textbox.Focus();
          spelledMultilineTextbox1.Textbox.SelectionStart = position + text.Length;

        }
        else if (boundItem.GetType() == typeof(Sprint))
        {
          string text = string.Format("{0} ", ((Sprint)boundItem).Id);
          int position = spelledMultilineTextbox1.Textbox.SelectionStart;
          spelledMultilineTextbox1.Textbox.Text = spelledMultilineTextbox1.Textbox.Text.Insert(position, text);
          spelledMultilineTextbox1.Textbox.Focus();
          spelledMultilineTextbox1.Textbox.SelectionStart = position + text.Length;
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      List<Todo> newTodos = null;
      string summary = string.Empty;
      try
      {
        newTodos = ParseTasks(out summary);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Something wrong.\r\n" + ex.Message, "Parsing tasks", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      if (newTodos != null && newTodos.Count > 0)
      {

        if (MessageBox.Show(string.Format("{0} Tasks found\r\n {1}\r\nAdd them ?", newTodos.Count, summary), "New Tasks", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
        {
          List<string> ids = new List<string>();
          foreach (Todo t in todoBindingSource.List)
          {
            ids.Add(t.Id);
          }
          ids.Sort();
          string lastId = ids.Last();
          int count = int.Parse(lastId.Split('-')[1]) + 1;

          foreach (Todo todo in newTodos)
          {
            todo.Id = string.Format("{0}-{1}", lastId.Split('-')[0], count++);
            todoBindingSource.Add(todo);
          }
        }
      }
      else
      {
        MessageBox.Show("Use -- for new tasks.\r\n", "Parsing tasks", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


    private void todoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
    {
      // Check if the data source has been updated, and that no error has occured.
      if (e.BindingCompleteContext ==
          BindingCompleteContext.DataSourceUpdate && e.Exception == null)

        // If not, end the current edit.
        e.Binding.BindingManagerBase.EndCurrentEdit();
    }
  }
}
