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
using Tornado14Lab.Utils.NativeTheme;

namespace Tornado14.TrayApp.Controls
{
    public partial class TaskSearchPanel : UserControl
    {
        public DataGridView Grid { 
            get {
                return this.dataGridViewTodos;
            }
            set
            {

            }
        }
        public void SetTodoBindingSource(object todoBindingSource)
        {
            TodoBindingSource.DataSource = todoBindingSource;
            AddStandardFilters();
            AddAdditionalFieldsFilters();
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


        internal void SetSprintBindingSource(object dataSource)
        {
            this.sprintBindingSource.DataSource = dataSource;
        }

        internal void SetProjectBindingSource(object dataSource)
        {
            this.projectBindingSource.DataSource = dataSource;
            projectPidDataGridViewTextBoxColumn.DataSource = dataSource;
            projectPidDataGridViewTextBoxColumn.DisplayMember = "ShortDescription";
        }


        public TaskSearchPanel()
        {
            InitializeComponent();

            // Fix Grid Columns
            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dataGridViewTodos.Columns[statusDataGridViewTextBoxColumn.Name];
            col.DataSource = Enum.GetValues(typeof(Status));
            col.ValueType = typeof(Status);



        

        }

        private void AddStandardFilters()
        {

            Dictionary<int, Color> colorPool = new Dictionary<int, Color>();
            colorPool.Add(0, BlackTheme.mBlueDark2);
            colorPool.Add(1, BlackTheme.mGrayDark2);
            colorPool.Add(2, BlackTheme.mGreenLight2);
            colorPool.Add(3, BlackTheme.mGreenDark2);
            colorPool.Add(4, BlackTheme.mViolett2);
            colorPool.Add(5, BlackTheme.mBraun2);
            colorPool.Add(6, BlackTheme.mPink2);
            colorPool.Add(7, BlackTheme.mYellow2);
            colorPool.Add(8, BlackTheme.mGreenLight1);
            colorPool.Add(9, BlackTheme.mGreenDark1);
            colorPool.Add(10, BlackTheme.mBraun1);
            colorPool.Add(11, BlackTheme.mBlueDark1);
            colorPool.Add(12, BlackTheme.mBlue1);

            filterStatus.label.Text = "Status";
            filterStatus.Height = 60;
            filterStatus.ComboBox.DataSource = Enum.GetValues(typeof(Status));
            filterStatus.TaskColor = colorPool[0];
            filterStatus.BackColor = colorPool[0];
            filterStatus.label.ForeColor = Color.White;
            filterStatus.ComboBox.SelectedValueChanged += FilterComboBoxValueChanged;

            filterSprint.Height = 60;
            filterSprint.label.Text = "Sprint";
            filterSprint.ComboBox.DataSource = sprintBindingSource;
            filterSprint.ComboBox.DisplayMember = "Summary";
            filterSprint.TaskColor = colorPool[3];
            filterSprint.BackColor = colorPool[3];
            filterSprint.ComboBox.SelectedValueChanged += FilterComboBoxValueChanged;

            filterProject.Height = 60;
            filterProject.label.Text = "Project";
            filterProject.ComboBox.DataSource = projectBindingSource;
            filterProject.ComboBox.DisplayMember = "ShortDescription";
            filterProject.TaskColor = colorPool[2];
            filterProject.BackColor = colorPool[2];
            filterProject.ComboBox.SelectedValueChanged += FilterComboBoxValueChanged;


            filterShortDescription.Height = 60;
            filterShortDescription.label.Text = "Short Description";
            filterShortDescription.TaskColor = colorPool[4];
            filterShortDescription.BackColor = colorPool[4];
            filterShortDescription.TextBox.TextChanged += FilterTextBoxTextChanged;

        }

        private ComboBoxFilter CreateAdditionalFilter(string name)
        {
            SortableBindingList<string> allAdditionalFieldValues = new SortableBindingList<string>();
            ComboBoxFilter additionalFieldFilter = new ComboBoxFilter();
            additionalFieldFilter.label.Text = name;
            additionalFieldFilter.Dock = DockStyle.Top;
            additionalFieldFilter.Height = 45;
            additionalFieldFilter.TaskColor = BlackTheme.BlueLight;
            additionalFieldFilter.BackColor = BlackTheme.BlueLight;
            additionalFieldFilter.ComboBox.SelectedValueChanged += FilterComboBoxValueChanged;
            return additionalFieldFilter;
        }

        private void AddAdditionalFieldsFilters()
        {
            AdditionalField1.HeaderText = "Customer";
            AdditionalField2.HeaderText = "Work Art";
            AdditionalField3.HeaderText = "Keyword";
            AdditionalField4.HeaderText = "Comment";
            AdditionalField5.Visible = false;


            ComboBoxFilter additionalField1Filter = CreateAdditionalFilter("Customer");
            ComboBoxFilter additionalField2Filter = CreateAdditionalFilter("Work Art");
            ComboBoxFilter additionalField3Filter = CreateAdditionalFilter("Keyword");
            ComboBoxFilter additionalField4Filter = CreateAdditionalFilter("Comment");
            //ComboBoxFilter additionalField5Filter = CreateAdditionalFilter("Field5");

            SortableBindingList<string> allAdditionalField1Values = new SortableBindingList<string>();
            SortableBindingList<string> allAdditionalField2Values = new SortableBindingList<string>();
            SortableBindingList<string> allAdditionalField3Values = new SortableBindingList<string>();
            SortableBindingList<string> allAdditionalField4Values = new SortableBindingList<string>();
            SortableBindingList<string> allAdditionalField5Values = new SortableBindingList<string>();
            SortableBindingList<Todo> allTodos = (SortableBindingList<Todo>)todoBindingSource.DataSource;
            foreach (Todo todo in allTodos)
            {
                if (!allAdditionalField1Values.Contains(todo.AdditionalField1))
                {
                    if (todo.AdditionalField1 != null)
                    {
                        allAdditionalField1Values.Add(todo.AdditionalField1);
                    }
                }
                if (!allAdditionalField2Values.Contains(todo.AdditionalField2))
                {
                    if (todo.AdditionalField2 != null)
                    {
                        allAdditionalField2Values.Add(todo.AdditionalField2);
                    }
                }
                if (!allAdditionalField3Values.Contains(todo.AdditionalField3))
                {
                    if (todo.AdditionalField3 != null)
                    {
                        allAdditionalField3Values.Add(todo.AdditionalField3);
                    }
                }
                if (!allAdditionalField4Values.Contains(todo.AdditionalField4))
                {
                    if (todo.AdditionalField4 != null)
                    {
                        allAdditionalField4Values.Add(todo.AdditionalField4);
                    }
                }
                if (!allAdditionalField5Values.Contains(todo.AdditionalField5))
                {
                    if (todo.AdditionalField5 != null)
                    {
                        allAdditionalField5Values.Add(todo.AdditionalField5);
                    }
                }
            }
            additionalField1Filter.ComboBox.DataSource = allAdditionalField1Values;
            additionalField2Filter.ComboBox.DataSource = allAdditionalField2Values;
            additionalField3Filter.ComboBox.DataSource = allAdditionalField3Values;
            additionalField4Filter.ComboBox.DataSource = allAdditionalField4Values;
            //additionalField5Filter.ComboBox.DataSource = allAdditionalField5Values;
            panelColumnAvailableFilter.Controls.Add(additionalField1Filter);
            panelColumnAvailableFilter.Controls.Add(additionalField2Filter);
            panelColumnAvailableFilter.Controls.Add(additionalField3Filter);
            panelColumnAvailableFilter.Controls.Add(additionalField4Filter);
            //panelColumnAvailableFilter.Controls.Add(additionalField5Filter);
        }

        private void FilterTextBoxTextChanged(object sender, EventArgs e)
        {
            ReloadTaskGrid();
        }

        private void FilterComboBoxValueChanged(object sender, EventArgs e)
        {
            ReloadTaskGrid();
        }

        private void ReloadTaskGrid()
        {
            SortableBindingList<Todo> filteredList = new SortableBindingList<Todo>();
            try {
                filteredList = (SortableBindingList<Todo>)TodoBindingSource.DataSource;
            } catch(Exception ex)
            {

            }
            foreach (Control filter in panelColumn1.Controls)
            {
                if (filter is ComboBoxFilter) {
                    ComboBoxFilter comboBoxFilter = (ComboBoxFilter)filter;
                    if (comboBoxFilter.ComboBox.SelectedItem != null && filteredList != null)
                    {
                        if (comboBoxFilter.ComboBox.SelectedItem is Sprint)
                        {
                            filteredList = SprintFilter(filteredList, (Sprint)comboBoxFilter.ComboBox.SelectedItem);
                        }
                        else if (comboBoxFilter.ComboBox.SelectedItem is Project)
                        {
                            filteredList = ProjectFilter(filteredList, (Project)comboBoxFilter.ComboBox.SelectedItem);
                        }
                        else if (comboBoxFilter.ComboBox.SelectedValue is Status)
                        {
                            filteredList = ProjectStatusFilter(filteredList, (Status)comboBoxFilter.ComboBox.SelectedItem);
                        } else if (comboBoxFilter.ComboBox.SelectedValue is string)
                        {
                            switch(comboBoxFilter.label.Text)
                            {
                                case "Customer":
                                    filteredList = AdditionalField1Filter(filteredList, (string)comboBoxFilter.ComboBox.SelectedValue);
                                    break;
                                case "Work Art":
                                    filteredList = AdditionalField2Filter(filteredList, (string)comboBoxFilter.ComboBox.SelectedValue);
                                    break;
                                case "Keyword":
                                    filteredList = AdditionalField3Filter(filteredList, (string)comboBoxFilter.ComboBox.SelectedValue);
                                    break;
                                case "Comment":
                                    filteredList = AdditionalField4Filter(filteredList, (string)comboBoxFilter.ComboBox.SelectedValue);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                } else if (filter is TextBoxFilter && filteredList != null)
                {
                    filteredList = ProjectShortDescriptionFilter(filteredList, ((TextBoxFilter)filter).TextBox.Text);
                }
            }
            if (filteredList != null)
            {
                dataGridViewTodos.DataSource = filteredList;
            }
        }

        private SortableBindingList<Todo> SprintFilter(SortableBindingList<Todo> todoList, Sprint sprint) {
            // All Tasks in Sprint
            List<Guid> sprintTasks = new List<Guid>();
            sprint.Kanban.ForEach(p => sprintTasks.Add(p.TaskPid));

            //Filter Global List
            return new SortableBindingList<Todo>(todoList.Where(t => sprintTasks.Contains(t.pId)));
        }

        private SortableBindingList<Todo> ProjectFilter(SortableBindingList<Todo> todoList, Project project)
        {
            //Filter Global List
            return new SortableBindingList<Todo>(todoList.Where(t => t.ProjectPid == project.pId));
        }

        private SortableBindingList<Todo> ProjectShortDescriptionFilter(SortableBindingList<Todo> todoList, string text)
        {
            //Filter Global List
            return new SortableBindingList<Todo>(todoList.Where(t => t.ShortDescription.ToLower().StartsWith(text)));
        }
        

        private SortableBindingList<Todo> ProjectStatusFilter(SortableBindingList<Todo> todoList, Status status)
        {
            //Filter Global List
            return new SortableBindingList<Todo>(todoList.Where(t => t.Status == status));
        }
        private SortableBindingList<Todo>AdditionalField1Filter(SortableBindingList<Todo> todoList, string value)
        {
            //Filter Global List
            return new SortableBindingList<Todo>(todoList.Where(t => t.AdditionalField1 == value));
        }
        private SortableBindingList<Todo> AdditionalField2Filter(SortableBindingList<Todo> todoList, string value)
        {
            //Filter Global List
            return new SortableBindingList<Todo>(todoList.Where(t => t.AdditionalField2 == value));
        }
        private SortableBindingList<Todo> AdditionalField3Filter(SortableBindingList<Todo> todoList, string value)
        {
            //Filter Global List
            return new SortableBindingList<Todo>(todoList.Where(t => t.AdditionalField3 == value));
        }
        private SortableBindingList<Todo> AdditionalField4Filter(SortableBindingList<Todo> todoList, string value)
        {
            //Filter Global List
            return new SortableBindingList<Todo>(todoList.Where(t => t.AdditionalField4 == value));
        }
        private SortableBindingList<Todo> AdditionalField5Filter(SortableBindingList<Todo> todoList, string value)
        {
            //Filter Global List
            return new SortableBindingList<Todo>(todoList.Where(t => t.AdditionalField5 == value));
        }

        private void todoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            // Check if the data source has been updated, and that no error has occured.
            if (e.BindingCompleteContext ==
                BindingCompleteContext.DataSourceUpdate && e.Exception == null)

                // If not, end the current edit.
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selectedProject = (ComboBox)sender;
            todoBindingSource.Filter = string.Format("{0} = '{1}'", projectPidDataGridViewTextBoxColumn.HeaderText, selectedProject.SelectedValue);
            SortableBindingList<Todo> source1 = (SortableBindingList<Todo>)todoBindingSource.DataSource;
            SortableBindingList<Todo> filteredList = new SortableBindingList<Todo>(source1.Where(t => t.ProjectPid == (Guid)selectedProject.SelectedValue));

            dataGridViewTodos.DataSource = filteredList;
        }

        private void fillDropdowns()
        {

        }

        private void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortableBindingList<Sprint> allSprints = (SortableBindingList<Sprint>)sprintBindingSource.DataSource;
            ComboBox selectedSprint = (ComboBox)sender;
            Sprint sprint = allSprints.Where(s => s.pId == (Guid)selectedSprint.SelectedValue).Single();
            List<Guid> sprintTasks = new List<Guid>();
            foreach (KanbanPosition position in sprint.Kanban)
            {
                sprintTasks.Add(position.TaskPid);
            }
            
            todoBindingSource.Filter = string.Format("{0} = '{1}'", projectPidDataGridViewTextBoxColumn.HeaderText, selectedSprint.SelectedValue);
            SortableBindingList<Todo> source1 = (SortableBindingList<Todo>)todoBindingSource.DataSource;
            
            SortableBindingList<Todo> filteredList = new SortableBindingList<Todo>(source1.Where(t => sprintTasks.Contains(t.pId)));

            dataGridViewTodos.DataSource = filteredList;
        }


        #region Drag and Drop Events

        void flowLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            Control data = (TextBoxFilter)e.Data.GetData(typeof(TextBoxFilter));
            if (data == null)
            {
                data = (ComboBoxFilter)e.Data.GetData(typeof(ComboBoxFilter));
            }
            Panel _destination = (Panel)sender;
            Control _source = (Panel)data.Parent;

            SortedDictionary<int, Control> list = new SortedDictionary<int, Control>();
            int currentIndex = -1;
            foreach (Control control in _destination.Controls)
            {
                int i = _destination.Controls.GetChildIndex(control, false);
                if (control != data)
                {
                    list.Add(i * 10, control);
                }
                else
                {
                    currentIndex = i * 10;
                }
            }

            if (_source != _destination)
            {
                // Add control to panel
                _destination.Controls.Add(data);
                data.Width = _destination.Width - 14;

                // Reorder
                Point p = _destination.PointToClient(new Point(e.X, e.Y));
                var item = _destination.GetChildAtPoint(p);
                int index = _destination.Controls.GetChildIndex(item, false);

                list.Add(((index * 10)) - 5, data);

                _destination.Invalidate();
                _source.Invalidate();
            }
            else
            {
                Point p = _destination.PointToClient(new Point(e.X, e.Y));
                var item = _destination.GetChildAtPoint(p);
                int index = _destination.Controls.GetChildIndex(item, false);
                if (index * 10 < currentIndex)
                {
                    list.Add(((index * 10)) - 5, data);
                }
                else
                {
                    list.Add(((index * 10)) + 5, data);
                }

                _destination.Invalidate();
            }

            int newIndex = list.Count;
            _destination.Controls.Clear();
            foreach (KeyValuePair<int, Control> co in list)
            {
                _destination.Controls.Add(co.Value);
                //((KanbanPosition)co.Value.Tag).Position = newIndex;
                newIndex--;
            }

            foreach (Control control in _destination.Controls)
            {
                int i = _destination.Controls.GetChildIndex(control, false);
                //((KanbanPosition)control.Tag).Position = i;
            }

            if (data.Tag != null && data.Tag.GetType() == typeof(KanbanPosition))
            {
                //((KanbanPosition)data.Tag).Position = _destination.Controls.GetChildIndex(data, false);
                //((KanbanPosition)data.Tag).Status = (Status)_destination.Tag;


                SortableBindingList<Todo> todos = (SortableBindingList<Todo>)todoBindingSource.DataSource;
                var task = from todo in todos
                           where todo.pId == ((KanbanPosition)data.Tag).TaskPid
                           select todo;



                if (task.Count() > 0)
                {
                    Todo todo = (Todo)task.First();
                    todo.Status = (Status)_destination.Tag;
                }
            }
        }

        void flowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        #endregion

    }
}
