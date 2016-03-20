using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14Lab.Utils.NativeTheme;
using System.IO;
using Tornado14Lab.Utils;
using Tornado14.Task;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14Lab.Utils.Text;

namespace Tornado14.TrayApp.Controls
{
    public partial class SprintGridPanel : StandardGridPanel, IStandardPanel
    {
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

        public SprintGridPanel()
        {
            InitializeComponent();

            // Init Base panel
        }

        #region Events

        private void dataGridViewSprints_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow lastRow = null;
            if (e.Row.DataGridView.Rows.Count > 1)
            {
                lastRow = e.Row.DataGridView.Rows[e.Row.Index - 1];
            }
            e.Row.Cells[pIdDataGridViewTextBoxColumn.Name].Value = Guid.NewGuid();

            if (lastRow != null)
            {
                DateTime newStartDate = (DateTime)lastRow.Cells[endDateDataGridViewTextBoxColumn.Name].Value;
                newStartDate = newStartDate.AddDays(1);
                if (newStartDate.DayOfWeek == DayOfWeek.Saturday || newStartDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    do
                    {
                        newStartDate = newStartDate.AddDays(1);
                    } while (newStartDate.DayOfWeek == DayOfWeek.Saturday || newStartDate.DayOfWeek == DayOfWeek.Sunday);
                }
                e.Row.Cells[startDateDataGridViewTextBoxColumn.Name].Value = newStartDate;
                e.Row.Cells[endDateDataGridViewTextBoxColumn.Name].Value = newStartDate.AddDays(14);
                e.Row.Cells[idDataGridViewTextBoxColumn.Name].Value = IdGeneration.NextAutoincrementValue(lastRow.Cells[idDataGridViewTextBoxColumn.Name].Value.ToString());
            }
        }

        private void toolStripButtonRestoreSprints_Click(object sender, EventArgs e)
        {
            SprintBindingSource.DataSource = SortableBindingListHelper.GetBindingListFromXmlFile<Sprint>(DataFilePath);
            HasChanges = false;
        }

        private void dataGridViewSprints_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            HasChanges = true;
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
    }
}
