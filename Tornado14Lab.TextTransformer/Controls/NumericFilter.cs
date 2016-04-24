﻿using System;
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
    public partial class NumericFilter : BaseFilter
    {
        public NumericFilter()
        {
            InitializeComponent();
            panelWrapper.MouseDown += Filter_MouseDown;
            panelWrapper.MouseLeave += Filter_MouseLeave;
            panelWrapper.MouseMove += Filter_MouseMove;
        }

        public override string Description
        {
            get
            {
                return base.Description;
            }

            set
            {
                labelDescription.Text = value;
                base.Description = value;
            }
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
