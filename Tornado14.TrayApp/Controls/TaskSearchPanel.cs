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

namespace Tornado14.TrayApp.Controls
{
    public partial class TaskSearchPanel : UserControl
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


        public TaskSearchPanel()
        {
            InitializeComponent();

            // Fix Grid Columns
            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dataGridViewTodos.Columns[statusDataGridViewTextBoxColumn.Name];
            col.DataSource = Enum.GetValues(typeof(Status));
            col.ValueType = typeof(Status);

        }

        private void todoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            // Check if the data source has been updated, and that no error has occured.
            if (e.BindingCompleteContext ==
                BindingCompleteContext.DataSourceUpdate && e.Exception == null)

                // If not, end the current edit.
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selectedProject = (ComboBox)sender;
            todoBindingSource.Filter = string.Format("{0} = '{1}'", projectPidDataGridViewTextBoxColumn.HeaderText, selectedProject.SelectedValue);
            SortableBindingList<Todo> source1 = (SortableBindingList<Todo>)todoBindingSource.DataSource;
            SortableBindingList<Todo> filteredList = new SortableBindingList<Todo>(source1.Where(t => t.ProjectPid == (Guid)selectedProject.SelectedValue));

            dataGridViewTodos.DataSource = filteredList;
        }
    }
}
