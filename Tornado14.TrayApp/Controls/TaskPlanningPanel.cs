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
            taskSearchPanel1.TodoBindingSource.DataSource = dataSource;
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
            taskSearchPanel1.SprintBindingSource.DataSource = dataSource;
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
            taskSearchPanel1.ProjectBindingSource.DataSource = dataSource;
        }

        public TaskPlanningPanel()
        {
            InitializeComponent();
            taskSearchPanel1.Grid.CellDoubleClick += Grid_CellDoubleClick;
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
                    startTime = calendar1.SelectedElementStart.Date;
                    if (calendar1.SelectedElementEnd != null)
                    {
                        endTime = calendar1.SelectedElementEnd.Date.AddMinutes(30);
                    } else
                    {
                        endTime = startTime.AddHours(2);
                    }
                } else
                {
                    startTime = calendar1.ViewStart;
                    endTime = startTime.AddHours(2);
                }

                CalendarItem calendarItem = new CalendarItem(calendar1, startTime, endTime, selectedTodo.ShortDescription + DateTime.Now.ToString());
                calendarItem.Tag = selectedTodo;
                calendar1.Items.Add(calendarItem);
            }
        }

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
        }

        private void toolStripButtonSaveKanban_Click(object sender, EventArgs e)
        {
            parentPanel.Save();
        }
    }
}
