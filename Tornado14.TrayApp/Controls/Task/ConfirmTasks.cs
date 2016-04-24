using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tornado14.Task;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14Lab.Utils.NativeTheme;

namespace Tornado14.TrayApp.Controls.Task
{
    public partial class ConfirmTasks : Form
    {
        public SortableBindingList<Todo> Todos
        {
            get
            {
                return (SortableBindingList<Todo>)todoBindingSource.DataSource;
            }
        }

        public void SetBindingSources(object projectDataSource, object sprintDataSource, object taskDataSource)
        {
            
            projectBindingSource.DataSource = projectDataSource;
            sprintBindingSource.DataSource = sprintDataSource;
            todoBindingSource.DataSource = taskDataSource;
            tasksGridPanel1.SetBindingSources(projectBindingSource.DataSource, sprintBindingSource.DataSource, todoBindingSource.DataSource);
        }
        public ConfirmTasks()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 800;
            this.BackColor = BlackTheme.ColorDarkGray;
            this.ForeColor = BlackTheme.ColorText;


            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 690);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);


            // Apply Black Theme
            BlackTheme.ApplyTheme(this);
        }

        private void toolStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
