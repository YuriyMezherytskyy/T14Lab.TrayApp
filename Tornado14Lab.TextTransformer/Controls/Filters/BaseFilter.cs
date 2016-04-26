using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tornado14Lab.TextTransformer.Controls
{
    public class BaseFilter : UserControl
    {
        public Color TaskColor { get; set; }

        public virtual Filter Key { get; set; }
        public virtual string Description { get; set; }
        public virtual List<object> Values { get; set; }

        private bool allowDrag = true;
        public bool AllowDrag
        {
            get
            {
                return allowDrag;
            }
            set
            {
                allowDrag = value;
            }
        }
        private bool _isDragging = false;
        private int _DDradius = 40;
        private int _mX = 0;
        private int _mY = 0;


        protected override void OnGotFocus(EventArgs e)
        {
            this.BackColor = Color.FromArgb(20,20,20);
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = TaskColor;

            base.OnLostFocus(e);
        }

        protected override void OnClick(EventArgs e)
        {
            this.Focus();
            base.OnClick(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _mX = e.X;
            _mY = e.Y;
            this._isDragging = false;

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(200,200,200);
            //this.textBoxShortDescription.BackColor = BlackTheme.ColorDarkGray2;
            if (!_isDragging)
            {
                //this.BackColor = BlackTheme.ColorHeaders2;
                // This is a check to see if the mouse is moving while pressed.
                // Without this, the DragDrop is fired directly when the control is clicked, now you have to drag a few pixels first.
                if (e.Button == MouseButtons.Left && _DDradius > 0 && this.AllowDrag)
                {
                    int num1 = _mX - e.X;
                    int num2 = _mY - e.Y;
                    if (((num1 * num1) + (num2 * num2)) > _DDradius)
                    {
                        DoDragDrop(this, DragDropEffects.All);
                        _isDragging = true;
                        return;
                    }
                }
                base.OnMouseMove(e);
            }

        }

        protected override void OnMouseLeave(EventArgs e)
        {
            //this.textBoxShortDescription.BackColor = TaskColor;
            this.BackColor = TaskColor;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _isDragging = false;
            base.OnMouseUp(e);
        }

        private void Filter_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        private void Filter_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }
        private void Filter_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);
        }
    }
}
