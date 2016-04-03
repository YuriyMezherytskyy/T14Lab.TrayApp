using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14.Task;
using Tornado14Lab.Utils.NativeTheme;

namespace Tornado14.TrayApp.Controls.Task
{
    public partial class EditTaskDialog : Form
    {
        public EditTaskDialog()
        {
            InitializeComponent();
        }

        public EditTaskDialog(object projectDataSource, object sprintDataSource, object taskDataSource)
        {
            InitializeComponent();
            taskEditor1.SetBindingSources(projectDataSource, sprintDataSource, taskDataSource);
            this.BackColor = BlackTheme.ColorDarkGray;
            this.ForeColor = BlackTheme.ColorText;
            BlackTheme.ApplyTheme(this);
        }

    }
}
