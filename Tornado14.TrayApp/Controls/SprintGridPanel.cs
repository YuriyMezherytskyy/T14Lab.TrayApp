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
        public BindingSource BindingSource
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
            this.ToolStripButtonSave = toolStripButtonSaveSprints;
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

        private void toolStripButtonSaveSprints_Click(object sender, EventArgs e)
        {
            SaveToXMLFile();
        }

        private void toolStripButtonRestoreSprints_Click(object sender, EventArgs e)
        {
            BindingSource.DataSource = SortableBindingListHelper.GetBindingListFromXmlFile<Sprint>(DataFilePath);
            HasChanges = false;
        }

        private void dataGridViewSprints_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            HasChanges = true;
        }

        #endregion

        #region Methods

        public void SaveToXMLFile()
        {
            BindingSource source = (BindingSource)dataGridViewSprints.DataSource;
            string data = XmlSerializationHelper.Serialize(source.List);
            StreamWriter file = new StreamWriter(DataFilePath);
            file.WriteLine(data);
            file.Close();
            HasChanges = false;
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
