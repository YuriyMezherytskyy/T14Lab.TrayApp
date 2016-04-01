using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14.Task;
using System.Windows.Forms.Calendar;
using Tornado14.TrayApp.Properties;
using System.IO;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14Lab.Utils;

namespace Tornado14.TrayApp.Controls
{
  public partial class TaskPlanningPanel : StandardGridPanel, IStandardPanel
  {

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

    internal void TodoBindingSourceDataSource(object dataSource)
    {
      this.TodoBindingSource.DataSource = dataSource;
      taskSearchPanel1.SetTodoBindingSource(dataSource);
    }

    public BindingSource SprintBindingSource
    {
      get
      {
        return sprintBindingSource;
      }
      set
      {
        sprintBindingSource = value;

      }
    }

    internal void SprintBindingSourceDataSource(object dataSource)
    {
      this.SprintBindingSource.DataSource = dataSource;
      taskSearchPanel1.SetSprintBindingSource(dataSource);
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

    internal void ProjectBindingSourceDataSource(object dataSource)
    {
      this.ProjectBindingSource.DataSource = dataSource;
      taskSearchPanel1.SetProjectBindingSource(dataSource);
    }
    private Dictionary<string, SortableBindingList<TodoCalendarPosition>> calendars = new Dictionary<string, SortableBindingList<TodoCalendarPosition>>();
    DirectoryInfo dataFolder = new DirectoryInfo(Path.Combine(Settings.Default.DataFolder, @"ProjectExplorer\"));
    public TaskPlanningPanel()
    {
      InitializeComponent();
      taskSearchPanel1.Grid.CellDoubleClick += Grid_CellDoubleClick;

            if (dataFolder.Exists)
            {
                foreach (FileInfo calendarFile in dataFolder.GetFiles("calendar*.xml"))
                {
                    if (!calendars.ContainsKey(calendarFile.Name))
                    {
                        calendars.Add(calendarFile.Name, null);
                    }
                    checkedListBox1.Items.Add(calendarFile.Name);
                }
            }
            calendar1.TimeUnitsOffset = -15;
    }

    internal void SaveCalendars()
    {
      foreach (KeyValuePair<string, SortableBindingList<TodoCalendarPosition>> calendar in calendars)
      {
        if (calendar.Value != null && calendar.Value.Count > 0)
        {
          StreamWriter calendarXMLFile = new StreamWriter(dataFolder.FullName + "\\" + calendar.Key);
          calendarXMLFile.WriteLine(XmlSerializationHelper.Serialize(calendar.Value));
          calendarXMLFile.Close();
        }
      }
    }

    private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
    {
      ReloadCalendar();
    }

    private void ReloadCalendar()
    {
      calendar1.Items.Clear();
      foreach (string selectedCalendar in checkedListBox1.CheckedItems)
      {
        string calendarFilePath = Path.Combine(dataFolder.FullName, selectedCalendar);
        SortableBindingList<TodoCalendarPosition> calendarItems = SortableBindingListHelper.GetBindingListFromXmlFile<TodoCalendarPosition>(calendarFilePath);
        calendars[selectedCalendar] = calendarItems;

        foreach (TodoCalendarPosition calendarPosition in calendarItems)
        {
          CalendarItem calendarItem = new CalendarItem(calendar1, calendarPosition.StartTime, calendarPosition.EndTime, calendarPosition.Text);
          calendarItem.Tag = calendarPosition;
          calendar1.Items.Add(calendarItem);
        }
      }
    }

    private void calendar1_ItemCreated(object sender, CalendarItemCancelEventArgs e)
    {
      //CalendarItem currentItem = (CalendarItem)e.Item;
      //currentItem.Tag = AddCalendarItemToCalendar(currentItem);
    }


    private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      object boundItem = taskSearchPanel1.Grid.Rows[e.RowIndex].DataBoundItem;
      if (boundItem != null && boundItem.GetType() == typeof(Todo))
      {
        Todo selectedTodo = (Todo)boundItem;
        DateTime startTime;
        DateTime endTime;
        if (calendar1.SelectedElementStart != null)
        {
          startTime = (calendar1.SelectedElementStart.Date < calendar1.SelectedElementEnd.Date) ? calendar1.SelectedElementStart.Date : calendar1.SelectedElementEnd.Date;
          if (calendar1.SelectedElementEnd != null)
          {
            endTime = (calendar1.SelectedElementStart.Date < calendar1.SelectedElementEnd.Date) ? calendar1.SelectedElementEnd.Date : calendar1.SelectedElementStart.Date;
            endTime = endTime.AddMinutes(30);
          }
          else
          {
            endTime = startTime.AddHours(2);
          }
        }
        else
        {
          startTime = calendar1.ViewStart;
          endTime = startTime.AddHours(2);
        }
        if (checkedListBox1.SelectedItem != null)
        {
          CalendarItem calendarItem = new CalendarItem(calendar1, startTime, endTime, selectedTodo.ShortDescription + DateTime.Now.ToString());
          calendar1.Items.Add(calendarItem);

          TodoCalendarPosition newTodoCalendarPosition = null;
          if (checkedListBox1.SelectedItem != null)
          {
            newTodoCalendarPosition = new TodoCalendarPosition()
            {
              pId = Guid.NewGuid(),
              StartTime = calendarItem.StartDate,
              EndTime = calendarItem.EndDate,
              Text = calendarItem.Text,
              TodopId = selectedTodo.pId,
              CalendarName = (string)checkedListBox1.SelectedItem
          };
          calendars[(string)checkedListBox1.SelectedItem].Add(newTodoCalendarPosition);
          calendarItem.Tag = newTodoCalendarPosition;
        }
      }
      else
      {
        MessageBox.Show("Select Calendar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }

  private void monthView1_SelectionChanged(object sender, EventArgs e)
  {
    calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
    ReloadCalendar();
  }

  private void toolStripButtonSaveKanban_Click(object sender, EventArgs e)
  {
    parentPanel.Save();
  }


  private void calendar1_ItemDatesChanged(object sender, CalendarItemEventArgs e)
  {
    CalendarItem currentItem = (CalendarItem)e.Item;
    TodoCalendarPosition position = (TodoCalendarPosition)currentItem.Tag;
    position.StartTime = currentItem.StartDate;
    position.EndTime = currentItem.EndDate;
  }

  private void calendar1_ItemDeleted(object sender, CalendarItemEventArgs e)
  {
    TodoCalendarPosition currentPosition = (TodoCalendarPosition)e.Item.Tag;
    TodoCalendarPosition position = calendars[currentPosition.CalendarName].Where(cp => cp.pId == currentPosition.pId).Single();
    calendars[currentPosition.CalendarName].Remove(position);
  }

  private void calendar1_ItemTextEdited(object sender, CalendarItemCancelEventArgs e)
  {
    CalendarItem currentItem = (CalendarItem)e.Item;
    TodoCalendarPosition position = (TodoCalendarPosition)currentItem.Tag;
    position.Text = currentItem.Text;
  }


}
}
