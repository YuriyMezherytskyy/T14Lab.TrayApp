using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14Lab.Utils.Text;
using Tornado14Lab.Utils.NativeTheme;
using Tornado14.TrayApp.Properties;
using Tornado14Lab.Utils;
using System.IO;
using Tornado14.Task;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14Lab.Utils.File;
using System.Diagnostics;

namespace Tornado14.TrayApp.Controls
{


  public partial class TasksGridPanel : StandardGridPanel, IStandardPanel
  {
    public void SetTodoBindingSource(object source)
    {
      todoBindingSource.DataSource = source;
      taskSearchPanel1.SetTodoBindingSource(source);
    }

    public void SetProjectBindingSource(object source)
    {

      projectBindingSource.DataSource = source;
      taskSearchPanel1.SetProjectBindingSource(source);
    }


    public void SetSprintBindingSource(object source)
    {
      sprintBindingSource.DataSource = source;
      taskSearchPanel1.SetSprintBindingSource(source);
    }

    public TasksGridPanel()
    {
      InitializeComponent();

      // Init base panel
      panelTaskFeatures.Dock = DockStyle.Fill;
      panelTaskDetails.Dock = DockStyle.Fill;
      panelTaskDetails.BringToFront();

      taskSearchPanel1.Grid.CellValueChanged += dataGridViewTodos_CellValueChanged;
    }

    #region Events



    private void dataGridViewTodos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      HasChanges = true;
    }

    private void todoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
    {
      // Check if the data source has been updated, and that no error has occured.
      if (e.BindingCompleteContext ==
          BindingCompleteContext.DataSourceUpdate && e.Exception == null)

        // If not, end the current edit.
        e.Binding.BindingManagerBase.EndCurrentEdit();
    }

    private void toolStripButtonDocumentation_Click(object sender, EventArgs e)
    {
      panelTaskDetails.Dock = DockStyle.Fill;
      panelTaskDetails.BringToFront();
      SetActiveButton((ToolStripButton)sender);
    }

    private void SetActiveButton(ToolStripButton button)
    {
      toolStripButtonDocumentation.Checked = false;
      toolStripButtonFeatures.Checked = false;
      button.Checked = true;
    }

    private void toolStripButtonFeatures_Click(object sender, EventArgs e)
    {
      panelTaskFeatures.Dock = DockStyle.Fill;
      panelTaskFeatures.BringToFront();
      SetActiveButton((ToolStripButton)sender);
    }

    private void todoBindingSource_PositionChanged(object sender, EventArgs e)
    {
      Todo todo = (Todo)todoBindingSource.Current;
      if (todo != null)
      {
        checkedListBox1.DataSource = todo.Features;
        this.checkedListBox1.DisplayMember = "Features";
        taskEditor1.BindingSource.Position = todoBindingSource.Position;
      }
    }

    private void toolStripButtonFiles_Click(object sender, EventArgs e)
    {
      Todo currentTask = (Todo)todoBindingSource.Current;
      if (currentTask.OpenFilesFolder(Settings.Default.DataFolder))
      {
        HasChanges = true;
      }
    }

    #endregion

    #region Methods

    #endregion

  }
}
