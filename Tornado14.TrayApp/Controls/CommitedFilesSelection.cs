using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14Lab.Utils.NativeTheme;

namespace Tornado14.TrayApp.Controls
{
    public partial class CommitedFilesSelection : Form
    {
        public CommitedFilesSelection()
        {
            InitializeComponent();
            BlackTheme.ApplyTheme(this);
        }

        public CommitedFilesSelection(List<CommitInfo> commits)
        {
            InitializeComponent();
            BlackTheme.ApplyTheme(this);
            dataGridView1.DataSource = commits;
        }
    }
}
