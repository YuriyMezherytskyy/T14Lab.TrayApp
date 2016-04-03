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


        internal void SetBindingSources(object projectDataSource, object sprintDataSource, object taskDataSource)
        {
            this.todoBindingSource.DataSource = taskDataSource;
            this.sprintBindingSource.DataSource = sprintDataSource;

            this.projectBindingSource.DataSource = projectDataSource;

            CurrentStateField.CustomEditor.HeaderText = "CurrentState";
            CurrentStateField.SetDataBinding(todoBindingSource.Current, "CurrentState");

            DescriptionField.CustomEditor.HeaderText = "Description";
            DescriptionField.SetDataBinding(todoBindingSource.Current, "Description");

            ResultField.CustomEditor.HeaderText = "Result";
            ResultField.SetDataBinding(todoBindingSource.Current, "Result");

            PublicTextField.CustomEditor.HeaderText = "PublicText";
            PublicTextField.SetDataBinding(todoBindingSource.Current, "PublicText");

            List<CompletionItem> comletionList = new List<CompletionItem>();
            
            foreach (object obj in todoBindingSource.List)
            {
                Todo task = (Todo)obj;
                CompletionItem completionItem2 = new CompletionItem() { DisplayText = task.ShortDescription, PopUpText = task.Description, ReplacementText = task.Id };
                comletionList.Add(completionItem2);

                CompletionItem completionItem = new CompletionItem() { DisplayText = task.Id, PopUpText = task.ShortDescription };
                comletionList.Add(completionItem);

            }

            foreach (object obj in projectBindingSource.List)
            {
                Project project = (Project)obj;
                CompletionItem completionItem2 = new CompletionItem() { DisplayText = project.ShortDescription, PopUpText = project.Description, ReplacementText = project.Id };
                comletionList.Add(completionItem2);

            }

            foreach (object obj in sprintBindingSource.List)
            {
                Sprint sprint = (Sprint)obj;
                CompletionItem completionItem2 = new CompletionItem() { DisplayText = sprint.ShortDescription, PopUpText = sprint.Description, ReplacementText = sprint.Id };
                comletionList.Add(completionItem2);

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
