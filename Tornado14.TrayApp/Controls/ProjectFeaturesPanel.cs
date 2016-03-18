using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14Lab.Utils.Text;

namespace Tornado14.TrayApp.Controls
{
    public partial class ProjectFeaturesPanel : UserControl
    {

        public BindingSource ProjectFeaturesBindingSource
        {
            get
            {
                return projectFeaturesBindingSource;
            }
            set
            {
                projectFeaturesBindingSource = value;
            }
        }
        public ProjectFeaturesPanel()
        {
            InitializeComponent();
        }

        private void dataGridViewProjects_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow lastRow = null;
            if (e.Row.DataGridView.Rows.Count > 1)
            {
                lastRow = e.Row.DataGridView.Rows[e.Row.Index - 1];
            }
            e.Row.Cells[pIdDataGridViewTextBoxColumn.Name].Value = Guid.NewGuid();

            if (lastRow != null)
            {
                e.Row.Cells[idDataGridViewTextBoxColumn.Name].Value = IdGeneration.NextAutoincrementValue(lastRow.Cells[idDataGridViewTextBoxColumn.Name].Value.ToString());
            }
        }
    }
}
