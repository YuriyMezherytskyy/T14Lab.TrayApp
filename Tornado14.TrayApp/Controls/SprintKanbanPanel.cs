using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14Lab.Utils.NativeTheme;
using Tornado14.Task;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14Lab.Utils.DateHelper;

namespace Tornado14.TrayApp.Controls
{
  public partial class SprintKanbanPanel : StandardGridPanel, IStandardPanel
  {
    internal void SetTodoBindingSource(object dataSource)
    {
      this.todoBindingSource.DataSource = dataSource;
      taskSearchPanel1.SetTodoBindingSource(dataSource);
    }


    internal void SetSprintBindingSource(object dataSource)
    {
      this.sprintBindingSource.DataSource = dataSource;
      taskSearchPanel1.SetSprintBindingSource(dataSource);

      foreach (Sprint sprint in sprintBindingSource.List)
      {
        DateTime now = DateTime.Now;
        TimeSpan ts = new TimeSpan(0, 0, 0);
        now = now.Date + ts;
        if (sprint.StartDate <= now && sprint.EndDate >= now)
        {
          ShowSprintKanban(sprint);
          comboBoxCurrentSprint.SelectedItem = sprint;
          //ShowKanban.PerformClick();
          int daysLeft = DateTimeHelper.GetBusinessDays(DateTime.Now, sprint.EndDate);
          if (daysLeft > 1)
          {
            labelDaysLeft.Text = string.Format("{0} day left", daysLeft);
          }
          else
          {
            labelDaysLeft.Text = string.Format("{0} days left", daysLeft);
          }
          break;
        }
      }
    }

    internal void SetProjectBindingSource(object dataSource)
    {
      this.projectBindingSource.DataSource = dataSource;
      taskSearchPanel1.SetProjectBindingSource(dataSource);

    }

    public SprintKanbanPanel()
    {
      InitializeComponent();

      //DataGridViewComboBoxColumn col1 = (DataGridViewComboBoxColumn)dataGridViewKanbanTasks.Columns[projectPidDataGridViewTextBoxColumn.Name];
      //col1.DataSource = projectBindingSource;
      //col1.ValueType = typeof(Project);

      taskSearchPanel1.Grid.CellClick += dataGridViewKanbanTasks_CellClick;


      ApplyTheme();
      splitContainerKanban.SplitterDistance = 0;
      checkBox4.Checked = false;
    }

    List<Panel> panels = new List<Panel>();

    private void ApplyTheme()
    {
      // Kanban
      panelColumn1.BackColor = BlackTheme.ColorDarkGray;
      panelColumn1.Tag = Status.Planned;
      panelColumn2.BackColor = BlackTheme.ColorDarkGray;
      panelColumn2.Tag = Status.Today;
      panelColumn3.BackColor = BlackTheme.ColorDarkGray;
      panelColumn3.Tag = Status.Progress;
      panelColumn4.BackColor = BlackTheme.ColorDarkGray;
      panelColumn4.Tag = Status.Test;
      panelColumn5.BackColor = BlackTheme.ColorDarkGray;
      panelColumn5.Tag = Status.Done;

      labelColumn1.ForeColor = BlackTheme.ColorTextNotifyBlue;
      labelColumn2.ForeColor = BlackTheme.ColorTextNotifyBlue;
      labelColumn3.ForeColor = BlackTheme.ColorTextNotifyBlue;
      labelColumn4.ForeColor = BlackTheme.ColorTextNotifyBlue;
      labelColumn5.ForeColor = BlackTheme.ColorTextNotifyBlue;

      labelColumn1.Text = Status.Planned.ToString();
      labelColumn2.Text = Status.Today.ToString();
      labelColumn3.Text = Status.Progress.ToString();
      labelColumn4.Text = Status.Test.ToString();
      labelColumn5.Text = Status.Done.ToString();


      buttonKanBanTasksSeparator.BackColor = BlackTheme.ColorLightGray2;
      label4.ForeColor = BlackTheme.ColorText;

      splitter1.BackColor = BlackTheme.ColorDarkGray2;
      splitter2.BackColor = BlackTheme.ColorDarkGray2;
      splitter3.BackColor = BlackTheme.ColorDarkGray2;
      splitter4.BackColor = BlackTheme.ColorDarkGray2;

      panels.Add(panelColumn1);
      panels.Add(panelColumn2);
      panels.Add(panelColumn3);
      panels.Add(panelColumn4);
      panels.Add(panelColumn5);
    }

    #region Events

    private void toolStripButtonSaveKanban_Click(object sender, EventArgs e)
    {
    }

    private void buttonSplitter_Click(object sender, EventArgs e)
    {
      if (splitContainerKanban.SplitterDistance < 40)
      {
        splitContainerKanban.SplitterDistance = 800;
        buttonKanBanTasksSeparator.Text = "<";
      }
      else
      {
        splitContainerKanban.SplitterDistance = 10;
        buttonKanBanTasksSeparator.Text = ">";
      }
    }

    private void comboBoxCurrentSprint_SelectedIndexChanged(object sender, EventArgs e)
    {
      Sprint sprint = (Sprint)comboBoxCurrentSprint.SelectedItem;

      ShowSprintKanban(sprint);
    }

    #endregion

    #region Drag and Drop Events

    void flowLayoutPanel_DragDrop(object sender, DragEventArgs e)
    {
      TaskItem data = (TaskItem)e.Data.GetData(typeof(TaskItem));
      Panel _destination = (Panel)sender;
      VScrollProperties lastScrollPosition = _destination.VerticalScroll;
      Control _source = (Panel)data.Parent;

      SortedDictionary<int, Control> list = new SortedDictionary<int, Control>();
      int currentIndex = -1;
      foreach (Control control in _destination.Controls)
      {
        int i = _destination.Controls.GetChildIndex(control, false);
        if (control != data)
        {
          list.Add(i * 10, control);
        }
        else
        {
          currentIndex = i * 10;
        }
      }

      if (_source != _destination)
      {
        // Add control to panel
        _destination.Controls.Add(data);
        data.Width = _destination.Width - 14;

        // Reorder
        Point p = _destination.PointToClient(new Point(e.X, e.Y));
        var item = _destination.GetChildAtPoint(p);
        int index = _destination.Controls.GetChildIndex(item, false);

        list.Add(((index * 10)) - 5, data);

        _destination.Invalidate();
        _source.Invalidate();
      }
      else
      {
        Point p = _destination.PointToClient(new Point(e.X, e.Y));
        var item = _destination.GetChildAtPoint(p);
        int index = _destination.Controls.GetChildIndex(item, false);
        if (index * 10 < currentIndex)
        {
          list.Add(((index * 10)) - 5, data);
        }
        else
        {
          list.Add(((index * 10)) + 5, data);
        }

        _destination.Invalidate();
      }

      int newIndex = list.Count;
      _destination.Controls.Clear();
      foreach (KeyValuePair<int, Control> co in list)
      {
        _destination.Controls.Add(co.Value);
        ((KanbanPosition)co.Value.Tag).Position = newIndex;
        newIndex--;
      }

      foreach (Control control in _destination.Controls)
      {
        int i = _destination.Controls.GetChildIndex(control, false);
        ((KanbanPosition)control.Tag).Position = i;
      }

      if (data.Tag != null && data.Tag.GetType() == typeof(KanbanPosition))
      {
        //((KanbanPosition)data.Tag).Position = _destination.Controls.GetChildIndex(data, false);
        ((KanbanPosition)data.Tag).Status = (Status)_destination.Tag;


        SortableBindingList<Todo> todos = (SortableBindingList<Todo>)todoBindingSource.DataSource;
        var task = from todo in todos
                   where todo.pId == ((KanbanPosition)data.Tag).TaskPid
                   select todo;



        if (task.Count() > 0)
        {
          Todo todo = (Todo)task.First();
          todo.Status = (Status)_destination.Tag;
          //dataGridViewKanbanTasks.DataSource = new object();
          //dataGridViewKanbanTasks.DataSource = todoBindingSource;
        }
      }
      HasChanges = true;
      _destination.ScrollControlIntoView(data);
    }

    void flowLayoutPanel_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.Move;
    }

    #endregion

    private void sprintBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
    {
      // Check if the data source has been updated, and that no error has occured.
      if (e.BindingCompleteContext ==
          BindingCompleteContext.DataSourceUpdate && e.Exception == null)

        // If not, end the current edit.
        e.Binding.BindingManagerBase.EndCurrentEdit();
    }

    #region Methods
    #endregion

    public void SaveToXMLFile()
    {
      throw new NotImplementedException();
    }

    private void toolStripButtonSaveKanban_Click_1(object sender, EventArgs e)
    {
      parentPanel.Save();
    }

    private void dataGridViewKanbanTasks_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex > -1)
      {
        object boundItem = taskSearchPanel1.Grid.Rows[e.RowIndex].DataBoundItem;
        if (boundItem != null && boundItem.GetType() == typeof(Todo))
        {
          AddTaskToPlanned((Todo)boundItem);
        }
      }
    }

    private void AddTaskToPlanned(Todo boundItem)
    {
      KanbanPosition newPosition = new KanbanPosition();
      newPosition.TaskPid = boundItem.pId;
      newPosition.Status = Status.Planned;
      newPosition.Position = panelColumn1.Controls.Count;
      Sprint sprint = (Sprint)comboBoxCurrentSprint.SelectedItem;
      sprint.Kanban.Add(newPosition);
      HasChanges = true;

      TaskItem kanbanItem = new TaskItem();
      kanbanItem.Tag = newPosition;
      kanbanItem.DeleteButtonClicked += new DeleteButtonClickedEventHandler(kanbanItem_DeleteButtonClicked);
      panelColumn1.Controls.Add(kanbanItem);
      kanbanItem.Dock = DockStyle.Top;
      kanbanItem.Width = panelColumn1.Width - 14;
      panelColumn1.Controls.SetChildIndex(kanbanItem, newPosition.Position);


      kanbanItem.Task = boundItem;
      kanbanItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
      SortableBindingList<Project> projects = (SortableBindingList<Project>)projectBindingSource.DataSource;
      var projectResult = from project in projects
                          where project.pId == kanbanItem.Task.ProjectPid
                          select project;
      if (projectResult.Count() > 0)
      {
        kanbanItem.Project = (Project)projectResult.First();
      }
    }

    void kanbanItem_DeleteButtonClicked(object sender, DeleteButtonClickedEventArgs e)
    {
      DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Remove task from kanban", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      if (dialogResult == DialogResult.Yes)
      {
        Sprint sprint = (Sprint)comboBoxCurrentSprint.SelectedItem;
        sprint.Kanban.Remove(e.KanbanPosition);
        e.TaskItem.Dispose();
      }
    }

    private void buttonShowKanban_Click(object sender, EventArgs e)
    {
      Sprint sprint = (Sprint)comboBoxCurrentSprint.SelectedItem;

      ShowSprintKanban(sprint);
    }

    private void ShowSprintKanban(Sprint sprint)
    {
      panelColumn1.Visible = false;
      panelColumn2.Visible = false;
      panelColumn3.Visible = false;
      panelColumn4.Visible = false;
      panelColumn5.Visible = false;

      flowLayoutPanelProjectList.Controls.Clear();
      panelColumn1.Controls.Clear();
      panelColumn2.Controls.Clear();
      panelColumn3.Controls.Clear();
      panelColumn4.Controls.Clear();
      panelColumn5.Controls.Clear();

      Dictionary<int, Color> colorPool = new Dictionary<int, Color>();
      colorPool.Add(0, BlackTheme.mBlueDark2);
      colorPool.Add(1, BlackTheme.mGrayDark2);
      colorPool.Add(2, BlackTheme.mGreenLight2);
      colorPool.Add(3, BlackTheme.mGreenDark2);
      colorPool.Add(4, BlackTheme.mViolett2);
      colorPool.Add(5, BlackTheme.mBraun2);
      colorPool.Add(6, BlackTheme.mPink2);
      colorPool.Add(7, BlackTheme.mYellow2);
      colorPool.Add(8, BlackTheme.mGreenLight1);
      colorPool.Add(9, BlackTheme.mGreenDark1);
      colorPool.Add(10, BlackTheme.mBraun1);
      colorPool.Add(11, BlackTheme.mBlueDark1);
      colorPool.Add(12, BlackTheme.mBlue1);
      Dictionary<Guid, int> projectPool = new Dictionary<Guid, int>();
      int colorCount = 0;
      if (sprint != null)
      {
        List<KanbanPosition> kanbanItems = sprint.Kanban.OrderBy(x => x.Position).ToList();
        foreach (KanbanPosition item in kanbanItems)
        {

          TaskItem kanbanItem = new TaskItem();

          kanbanItem.Tag = item;
          kanbanItem.SetBlackTheme();
          kanbanItem.DeleteButtonClicked += new DeleteButtonClickedEventHandler(kanbanItem_DeleteButtonClicked);
          Panel panel = null;
          switch (item.Status)
          {
            case Status.Unknown:
            case Status.Backlog:
            case Status.Planned:
              panel = panelColumn1;
              break;
            case Status.Today:
              panel = panelColumn2;
              break;
            case Status.Progress:
              panel = panelColumn3;
              break;
            case Status.Test:
              panel = panelColumn4;
              break;
            case Status.Done:
              panel = panelColumn5;
              break;
            default:
              break;
          }
          if (panel != null)
          {
            panel.Controls.Add(kanbanItem);
            kanbanItem.Dock = DockStyle.Top;
            kanbanItem.Width = panel.Width - 14;
            panel.Controls.SetChildIndex(kanbanItem, item.Position);
            SortableBindingList<Todo> todos = (SortableBindingList<Todo>)todoBindingSource.DataSource;
            var task = from todo in todos
                       where todo.pId == item.TaskPid
                       select todo;



            if (task.Count() > 0)
            {
              kanbanItem.Task = (Todo)task.First();
              kanbanItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
              SortableBindingList<Project> projects = (SortableBindingList<Project>)projectBindingSource.DataSource;
              var projectResult = from project in projects
                                  where project.pId == kanbanItem.Task.ProjectPid
                                  select project;

              if (projectResult.Count() > 0)
              {
                kanbanItem.Project = (Project)projectResult.First();
                if (!projectPool.ContainsKey(kanbanItem.Project.pId))
                {
                  Label project = new Label();
                  project.AutoSize = true;
                  project.BackColor = colorPool[colorCount];
                  project.ForeColor = BlackTheme.ColorText;
                  project.Text = kanbanItem.Project.ShortDescription;
                  project.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  flowLayoutPanelProjectList.Controls.Add(project);
                  projectPool.Add(kanbanItem.Project.pId, colorCount);
                  colorCount++;
                }
                kanbanItem.TaskColor = colorPool[projectPool[kanbanItem.Project.pId]];
                kanbanItem.SetBlackTheme();
              }
            }
          }
        }
      }
      panelColumn1.Visible = true;
      panelColumn2.Visible = true;
      panelColumn3.Visible = true;
      panelColumn4.Visible = true;
      panelColumn5.Visible = true;
    }



    private void sprintBindingSource_ListChanged(object sender, ListChangedEventArgs e)
    {
      HasChanges = true;
    }

    private void projectBindingSource_ListChanged(object sender, ListChangedEventArgs e)
    {
      HasChanges = true;
    }

    private void todoBindingSource_ListChanged(object sender, ListChangedEventArgs e)
    {
      HasChanges = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {

      List<Todo> todoList = new List<Todo>();
      foreach (Panel panel in panels)
      {
        foreach (Control control in panel.Controls)
        {
          if (control.GetType() == typeof(TaskItem))
          {

            TaskItem taskItem = (TaskItem)control;
            if (taskItem.Checked)
            {
              todoList.Add(taskItem.Task);
            }
          }
        }
      }
      SortableBindingList<Project> projects = (SortableBindingList<Project>)projectBindingSource.DataSource;
      ReportScreen repostScreen = new ReportScreen(todoList, projects);
      repostScreen.Show();
    }

    List<Todo> todoList = new List<Todo>();
    private void button2_Click(object sender, EventArgs e)
    {
      foreach (Panel panel in panels)
      {
        foreach (Control control in panel.Controls)
        {
          if (control.GetType() == typeof(TaskItem))
          {

            TaskItem taskItem = (TaskItem)control;
            if (taskItem.Checked)
            {
              todoList.Add(taskItem.Task);
            }
          }
        }
      }
      string end = "";
      if (todoList.Count > 0)
      {
        end = "s";
      }
      button3.Text = string.Format("Paste {0} Task{1}", todoList.Count, end);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      foreach (Todo todo in todoList)
      {
        AddTaskToPlanned(todo);
      }
      todoList = new List<Todo>();
      button3.Text = "Paste";
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (!checkBox1.Checked)
      {
        panel1.Visible = false;
        splitter1.Visible = false;
      }
      else
      {
        panel1.Visible = true;
        splitter1.Visible = true;
      }
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      if (!checkBox2.Checked)
      {
        panel2.Visible = false;
        splitter2.Visible = false;
      }
      else
      {
        panel2.Visible = true;
        splitter2.Visible = true;
      }
    }

    private void panel6_Paint(object sender, PaintEventArgs e)
    {

    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
      if (!checkBox3.Checked)
      {
        panel3.Visible = false;
        splitter3.Visible = false;
      }
      else
      {
        panel3.Visible = true;
        splitter3.Visible = true;
      }
    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e)
    {
      if (!checkBox4.Checked)
      {
        splitter4.Visible = false;
        panel4.Visible = false;
      }
      else
      {
        splitter4.Visible = true;
        panel4.Visible = true;
      }
    }

    private void checkBox6_CheckedChanged(object sender, EventArgs e)
    {
      if (!checkBox6.Checked)
      {
        panel9.Visible = false;
      }
      else
      {
        panel9.Visible = true;
      }
    }

    private void splitContainerKanban_SplitterMoved(object sender, SplitterEventArgs e)
    {

    }

    private void checkBox5_CheckedChanged(object sender, EventArgs e)
    {
      if (!checkBox5.Checked)
      {
        splitContainerKanban.SplitterDistance = 0;
      }
      else
      {
        splitContainerKanban.SplitterDistance = 770;
      }
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {

    }
  }
}
