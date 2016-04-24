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
        public ScenarioSelector()
        {
            InitializeComponent();
            AddFilters();
        }

        private void AddFilters()
        {
            tabPageRemoveInLine.Controls.Clear();
            tabPageRemoveLine.Controls.Clear();
            tabPageModifyLine.Controls.Clear();
            tabPageDuplicate.Controls.Clear();

            AddFilter(tabPageRemoveInLine, Filter.StartToString);
            AddFilter(tabPageRemoveInLine, Filter.StringToEnd);
            AddFilter(tabPageRemoveInLine, Filter.StartToCharNumber);
            AddFilter(tabPageRemoveInLine, Filter.CharNumberToEnd);
            AddFilter(tabPageRemoveInLine, Filter.Breakline);
            // remove from char no to char no

            AddFilter(tabPageRemoveLine, Filter.EmptyLines);
            AddFilter(tabPageRemoveLine, Filter.StartsWith);
            AddFilter(tabPageRemoveLine, Filter.NotStartsWith);
            AddFilter(tabPageRemoveLine, Filter.EndsWidh);
            AddFilter(tabPageRemoveLine, Filter.NotEndsWidh);
            AddFilter(tabPageRemoveLine, Filter.Contains);
            AddFilter(tabPageRemoveLine, Filter.NotContains);
            AddFilter(tabPageRemoveLine, Filter.GiveEachLineNo);

            AddFilter(tabPageModifyLine, Filter.AddAtStartAndAtEnd);
            AddFilter(tabPageModifyLine, Filter.SplitAmdDuplicate);

            AddFilter(tabPageDuplicate, Filter.GetDuplicateLines);
            AddFilter(tabPageDuplicate, Filter.GetNotDuplicateLines);
            AddFilter(tabPageDuplicate, Filter.RemoveDuplicateLines);
        }

        private void AddFilter(TabPage page, Filter filter)
        {
            FilterHelper filterHelper = new FilterHelper();
            BaseFilter filterControl = filterHelper.GetFilter(filter);
            page.Controls.Add(filterControl);
            filterControl.Dock = DockStyle.Top;
        }

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
