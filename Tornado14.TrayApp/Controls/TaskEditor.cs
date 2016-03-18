using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14.Task;

namespace Tornado14.TrayApp.Controls
{
    public partial class TaskEditor : UserControl
    {
        public BindingSource BindingSource
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

        public void SetDataSource(SortableBindingList<Todo> sortableBindingList)
        {
            todoBindingSource.DataSource = sortableBindingList;
            spelledMultilineTextboxDescription.Textbox.DataBindings.Clear();
            spelledMultilineTextboxShortDescription.Textbox.DataBindings.Clear();
            spelledMultilineTextboxResult.Textbox.DataBindings.Clear();
            spelledMultilineTextboxPublicText.Textbox.DataBindings.Clear();

            spelledMultilineTextboxDescription.Textbox.DataBindings.Add("Text", todoBindingSource, "Description", true);
            spelledMultilineTextboxShortDescription.Textbox.DataBindings.Add("Text", todoBindingSource, "CurrentState", true);
            spelledMultilineTextboxResult.Textbox.DataBindings.Add("Text", todoBindingSource, "Result", true);
            spelledMultilineTextboxPublicText.Textbox.DataBindings.Add("Text", todoBindingSource, "PublicText", true);
        }

        public TaskEditor()
        {
            InitializeComponent();


        }
    }
}
