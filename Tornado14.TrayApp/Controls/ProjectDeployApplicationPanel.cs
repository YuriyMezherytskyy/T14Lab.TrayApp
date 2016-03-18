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
    public partial class ProjectDeployApplicationPanel : UserControl
    {
        public object SprintBindingSourceDataSource
        {
            get
            {

                return sprintBindingSource;
            }
            set
            {
                sprintBindingSource.DataSource = value;
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


        public ProjectDeployApplicationPanel()
        {
            InitializeComponent();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0} details", label1.Text);
        }
      
    }
}
