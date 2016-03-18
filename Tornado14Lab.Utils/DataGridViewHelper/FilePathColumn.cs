using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Tornado14Lab.Utils.DataGridViewHelper
{
    public class FilePathColumn : DataGridViewColumn
    {
        private bool useFolderSelectionDialog = false;
        public FilePathColumn()
            : base(new FilePathCell())
        {
        }


        public bool UseFolderSelectionDialog {
            get
            {
                return this.useFolderSelectionDialog;
            }
            set
            {
                this.useFolderSelectionDialog = value;
            } 
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                // Ensure that the cell used for the template is a CalendarCell. 
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(FilePathCell)))
                {
                    throw new InvalidCastException("Must be a CalendarCell");
                }
                base.CellTemplate = value;
            }
        }

        public override object Clone()
        {
            FilePathColumn result = (FilePathColumn)base.Clone();
            result.UseFolderSelectionDialog = this.useFolderSelectionDialog;
            return result;
        }
    }
}
