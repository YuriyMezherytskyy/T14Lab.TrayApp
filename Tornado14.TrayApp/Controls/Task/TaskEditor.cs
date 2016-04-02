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

namespace Tornado14.TrayApp.Controls.Task
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

            //spelledMultilineTextboxDescription.Textbox.DataBindings.Add("Text", todoBindingSource, "Description", true);
            //spelledMultilineTextboxShortDescription.Textbox.DataBindings.Add("Text", todoBindingSource, "CurrentState", true);
            //spelledMultilineTextboxResult.Textbox.DataBindings.Add("Text", todoBindingSource, "Result", true);
            //spelledMultilineTextboxPublicText.Textbox.DataBindings.Add("Text", todoBindingSource, "PublicText", true);

            CurrentStateField.SetDataBinding(todoBindingSource.Current, "CurrentState");
            DescriptionField.SetDataBinding(todoBindingSource.Current, "Description");
            ResultField.SetDataBinding(todoBindingSource.Current, "Result");
            PublicTextField.SetDataBinding(todoBindingSource.Current, "PublicText");

            List<CompletionItem> comletionList = new List<CompletionItem>();

            foreach (Todo task in sortableBindingList)
            {
                CompletionItem completionItem2 = new CompletionItem() { DisplayText = task.ShortDescription, PopUpText = task.Description, ReplacementText = task.Id };
                comletionList.Add(completionItem2);
            }

            foreach (Todo task in sortableBindingList)
            {
                CompletionItem completionItem = new CompletionItem() { DisplayText = task.Id, PopUpText = task.ShortDescription };
                comletionList.Add(completionItem);
            }
            
            todoBindingSource.CurrentChanged += TodoBindingSource_CurrentChanged;

            CurrentStateField.FillComletionList(comletionList);
        }

        private void TodoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CurrentStateField.SetDataBinding(todoBindingSource.Current, "CurrentState");
            DescriptionField.SetDataBinding(todoBindingSource.Current, "Description");
            ResultField.SetDataBinding(todoBindingSource.Current, "Result");
            PublicTextField.SetDataBinding(todoBindingSource.Current, "PublicText");
        }

        public TaskEditor()
        {
            InitializeComponent();


        }
    }
}
