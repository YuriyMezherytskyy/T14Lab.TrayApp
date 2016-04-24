using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tornado14Lab.TextTransformer.Controls
{

    public partial class ScenarioSelector : UserControl
    {
        public enum Filter
        {
            empty = 0,
            StartToString = 10,
            StringToEnd = 20,
            StartToCharNumber = 30,
            CharNumberToEnd = 40,
            Breakline = 50,

            EmptyLines = 100,
            StartsWith = 110,
            NotStartsWith = 120,
            EndsWidh = 130,
            NotEndsWidh = 140,
            Contains = 150,
            NotContains = 160,
            GiveEachLineNo = 170,

            AddAtStartAndAtEnd = 200,
            SplitAmdDuplicate = 210,

            GetDuplicateLines = 300,
            GetNotDuplicateLines = 310,
            RemoveDuplicateLines = 320
        }

        public ScenarioSelector()
        {
            InitializeComponent();
            // Remove in line
            AddTextBoxFilter(tabPageRemoveInLine, Filter.StartToString, "Remove in line from start to string");
            AddTextBoxFilter(tabPageRemoveInLine, Filter.StringToEnd, "Remove in line from string to end");
            AddNumericFilter(tabPageRemoveInLine, Filter.StartToCharNumber, "Remove in line from start to char number");
            AddNumericFilter(tabPageRemoveInLine, Filter.CharNumberToEnd, "Remove in line from chart to end");
            AddNoDataFilter(tabPageRemoveInLine, Filter.Breakline, "Remove in line breaklines");
            // remove from char no to char no

            AddNoDataFilter(tabPageRemoveLine, Filter.EmptyLines, "Remove Empty lines");
            AddTextBoxFilter(tabPageRemoveLine, Filter.StartsWith, "Remove lines Starts with");
            AddTextBoxFilter(tabPageRemoveLine, Filter.NotStartsWith, "Remove lines not starts with");
            AddTextBoxFilter(tabPageRemoveLine, Filter.EndsWidh, "Remove lines ends with");
            AddTextBoxFilter(tabPageRemoveLine, Filter.NotEndsWidh, "Remove lines not ends with");
            AddTextBoxFilter(tabPageRemoveLine, Filter.Contains, "Remove lines contains");
            AddTextBoxFilter(tabPageRemoveLine, Filter.NotContains, "Remove lines not contains");
            AddNumericFilter(tabPageRemoveLine, Filter.GiveEachLineNo, "Give each line no");

            AddDoubleTextboxFiler(tabPageModifyLine, Filter.AddAtStartAndAtEnd, "Add at start and at end, each line");
            AddTextBoxFilter(tabPageModifyLine, Filter.SplitAmdDuplicate, "Split amd duplicate lines");

            AddNoDataFilter(tabPageDuplicate, Filter.GetDuplicateLines, "Get duplicates lines");
            AddNoDataFilter(tabPageDuplicate, Filter.GetNotDuplicateLines, "Get not duplicates lines");
            AddNoDataFilter(tabPageDuplicate, Filter.RemoveDuplicateLines, "Remove duplicate lines");
        }

        #region Add Filter

        private TextboxFilter AddTextBoxFilter(TabPage page, Filter key, string description)
        {
            TextboxFilter textboxFilter = new TextboxFilter();

            textboxFilter.Key = key.ToString();
            textboxFilter.Description = description;
            page.Controls.Add(textboxFilter);
            textboxFilter.Dock = DockStyle.Top;

            return textboxFilter;
        }

        private NoDataFilter AddNoDataFilter(TabPage page, Filter key, string description)
        {
            NoDataFilter noDataFilter = new NoDataFilter();

            noDataFilter.Key = key.ToString();
            noDataFilter.Description = description;
            page.Controls.Add(noDataFilter);
            noDataFilter.Dock = DockStyle.Top;

            return noDataFilter;
        }

        private DoubleTextboxFiler AddDoubleTextboxFiler(TabPage page, Filter key, string description)
        {
            DoubleTextboxFiler doubleTextboxFilter = new DoubleTextboxFiler();

            doubleTextboxFilter.Key = key.ToString();
            doubleTextboxFilter.Description = description;
            page.Controls.Add(doubleTextboxFilter);
            doubleTextboxFilter.Dock = DockStyle.Top;

            return doubleTextboxFilter;
        }

        private NumericFilter AddNumericFilter(TabPage page, Filter key, string description)
        {
            NumericFilter numericFilter = new NumericFilter();

            numericFilter.Key = key.ToString();
            numericFilter.Description = description;
            page.Controls.Add(numericFilter);
            numericFilter.Dock = DockStyle.Top;

            return numericFilter;
        }


        #endregion

        #region Drag and Drop Events

        void flowLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            Control data = null;
            data = (BaseFilter)e.Data.GetData(typeof(TextboxFilter));
            if (data == null) data = (BaseFilter)e.Data.GetData(typeof(NoDataFilter));
            if (data == null) data = (BaseFilter)e.Data.GetData(typeof(DoubleTextboxFiler));
            if (data == null) data = (BaseFilter)e.Data.GetData(typeof(NumericFilter));

            Panel _destination = (Panel)sender;
            Control _source = (Control)data.Parent;

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

            //if (data.Tag != null && data.Tag.GetType() == typeof(KanbanPosition))
            //{
            //    //((KanbanPosition)data.Tag).Position = _destination.Controls.GetChildIndex(data, false);
            //    //((KanbanPosition)data.Tag).Status = (Status)_destination.Tag;


            //    SortableBindingList<Todo> todos = (SortableBindingList<Todo>)todoBindingSource.DataSource;
            //    var task = from todo in todos
            //               where todo.pId == ((KanbanPosition)data.Tag).TaskPid
            //               select todo;



            //    if (task.Count() > 0)
            //    {
            //        Todo todo = (Todo)task.First();
            //        todo.Status = (Status)_destination.Tag;
            //    }
            //}
            //ReloadTaskGrid();
        }

        void flowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        #endregion

    }

}
