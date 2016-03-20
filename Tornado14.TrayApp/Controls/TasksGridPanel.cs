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

        public TasksGridPanel()
        {
            InitializeComponent();

            // Init base panel

            // Fix Grid Columns
            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dataGridViewTodos.Columns[statusDataGridViewTextBoxColumn.Name];
            col.DataSource = Enum.GetValues(typeof(Status));
            col.ValueType = typeof(Status);


            panelTaskFeatures.Dock = DockStyle.Fill;
            panelTaskDetails.Dock = DockStyle.Fill;
            panelTaskDetails.BringToFront();
        }

        #region Events

        private void dataGridViewTodos_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow lastRow = null;
            if (e.Row.DataGridView.Rows.Count > 1)
            {
                lastRow = e.Row.DataGridView.Rows[e.Row.Index - 1];
            }
            e.Row.Cells[pIdDataGridViewTextBoxColumn.Name].Value = Guid.NewGuid();

            if (lastRow != null)
            {
                e.Row.Cells[statusDataGridViewTextBoxColumn.Name].Value = lastRow.Cells[statusDataGridViewTextBoxColumn.Name].Value;
                e.Row.Cells[projectPidDataGridViewTextBoxColumn.Name].Value = lastRow.Cells[projectPidDataGridViewTextBoxColumn.Name].Value;
                //e.Row.Cells[sprintPidDataGridViewTextBoxColumn.Name].Value = lastRow.Cells[sprintPidDataGridViewTextBoxColumn.Name].Value;

                e.Row.Cells[idDataGridViewTextBoxColumn.Name].Value = IdGeneration.NextAutoincrementValue(lastRow.Cells[idDataGridViewTextBoxColumn.Name].Value.ToString());
            }
        }

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
