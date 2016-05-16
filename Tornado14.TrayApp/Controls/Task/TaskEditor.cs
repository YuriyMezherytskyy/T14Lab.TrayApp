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
using Tornado14.TrayApp.Properties;

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

            CurrentStateField.CustomEditor.HeaderText = "Ist Zustand";
            CurrentStateField.SetDataBinding(todoBindingSource.Current, "CurrentState");
            CurrentStateField.HeaderClicked += CurrentStateField_HeaderClicked;

            DescriptionField.CustomEditor.HeaderText = "Soll Zustand";
            DescriptionField.SetDataBinding(todoBindingSource.Current, "Description");
            DescriptionField.HeaderClicked += DescriptionField_HeaderClicked;

            ResultField.CustomEditor.HeaderText = "Recherche";
            ResultField.SetDataBinding(todoBindingSource.Current, "Result");
            ResultField.HeaderClicked += ResultField_HeaderClicked;

            PublicTextField.CustomEditor.HeaderText = "Resultat";
            PublicTextField.SetDataBinding(todoBindingSource.Current, "PublicText");
            PublicTextField.HeaderClicked += PublicTextField_HeaderClicked;

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




        private void CurrentStateField_HeaderClicked(object sender, EventArgs e)
        {
            int height = panelTaskDetails.Height - 12;
            int smallSize = (height / 2) / 3;
            int bigSize = height - (smallSize * 3);
            panel1.Height = bigSize;
            panel2.Height = smallSize;
            panel3.Height = smallSize;
            panel4.Height = smallSize;
        }

        private void DescriptionField_HeaderClicked(object sender, EventArgs e)
        {
            int height = panelTaskDetails.Height - 12;
            int smallSize = (height / 2) / 3;
            int bigSize = height - (smallSize * 3);
            panel1.Height = smallSize;
            panel2.Height = bigSize;
            panel3.Height = smallSize;
            panel4.Height = smallSize;
        }

        private void ResultField_HeaderClicked(object sender, EventArgs e)
        {
            int height = panelTaskDetails.Height - 12;
            int smallSize = (height / 2) / 3;
            int bigSize = height - (smallSize * 3);
            panel1.Height = smallSize;
            panel2.Height = smallSize;
            panel3.Height = bigSize;
            panel4.Height = smallSize;
        }

        private void PublicTextField_HeaderClicked(object sender, EventArgs e)
        {
            int height = panelTaskDetails.Height - 12;
            int smallSize = (height / 2) / 3;
            int bigSize = height - (smallSize * 3);
            panel1.Height = smallSize;
            panel2.Height = smallSize;
            panel3.Height = smallSize;
            panel4.Height = bigSize;
        }



        private void TodoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CurrentStateField.SetDataBinding(todoBindingSource.Current, "CurrentState");
            DescriptionField.SetDataBinding(todoBindingSource.Current, "Description");
            ResultField.SetDataBinding(todoBindingSource.Current, "Result");
            PublicTextField.SetDataBinding(todoBindingSource.Current, "PublicText");

            if (todoBindingSource.Current is Todo)
            {
                Todo todo = (Todo)todoBindingSource.Current;
                toolStripLabel1.Text = todo.ShortDescription.Truncate(50);
                if (!string.IsNullOrEmpty(todo.CurrentState)) toolStripButtonIst.ForeColor = Color.White;
                if (!string.IsNullOrEmpty(todo.Description)) toolStripButtonSoll.ForeColor = Color.White;
                if (!string.IsNullOrEmpty(todo.Result)) toolStripButtonRecherche.ForeColor = Color.White;
                if (!string.IsNullOrEmpty(todo.PublicText)) toolStripButtonResult.ForeColor = Color.White;
            }
        }

        public TaskEditor()
        {
            InitializeComponent();
            PanelsVisibility(panel2, toolStripButtonSoll);
        }


        private void PanelsVisibility(Panel activePanel, ToolStripButton button)
        {
            toolStripButtonIst.Checked = false;
            toolStripButtonSoll.Checked = false;
            toolStripButtonRecherche.Checked = false;
            toolStripButtonResult.Checked = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            activePanel.Visible = true;
            activePanel.Dock = DockStyle.Fill;
            button.Checked = true;
        }

        private void toolStripButtonIst_Click(object sender, EventArgs e)
        {
            PanelsVisibility(panel1, toolStripButtonIst);
            
        }

        private void toolStripButtonSoll_Click(object sender, EventArgs e)
        {
            PanelsVisibility(panel2, toolStripButtonSoll);
        }

        private void toolStripButtonRecherche_Click(object sender, EventArgs e)
        {
            PanelsVisibility(panel3, toolStripButtonRecherche);
        }

        private void toolStripButtonResult_Click(object sender, EventArgs e)
        {
            PanelsVisibility(panel4, toolStripButtonResult);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Todo currentTask = (Todo)todoBindingSource.Current;
            currentTask.OpenFilesFolder(Settings.Default.DataFolder);
        }
    }
    public static class StringExt
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength) + "...";
        }
    }
}
