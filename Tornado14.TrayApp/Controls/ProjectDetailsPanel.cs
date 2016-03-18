using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Tornado14.TrayApp.Controls
{
    public partial class ProjectDetailsPanel : UserControl
    {
        public ProjectDetailsPanel()
        {
            InitializeComponent();
            spelledMultilineTextbox1.Textbox.DataBindings.Add("Text", projectBindingSource, "Description", true);
            label2.DataBindings.Add("Text", projectBindingSource, "ShortDescription", true);
            label3.DataBindings.Add("Text", projectBindingSource, "id", true);
            
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

        private void label2_TextChanged(object sender, EventArgs e)
        {
            label1.Text = string.Format("\"{0}\" details",label2.Text);
        }

        private void projectBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            // Check if the data source has been updated, and that no error has occured.
            if (e.BindingCompleteContext ==
                BindingCompleteContext.DataSourceUpdate && e.Exception == null)

                // If not, end the current edit.
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
