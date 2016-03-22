using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Tornado14Lab.Utils;
using Tornado14Lab.Utils.NativeTheme;
using Tornado14.TrayApp.Properties;
using Tornado14Lab.Utils.DataGridViewHelper;

namespace Tornado14.TrayApp.Controls
{
    public class StandardGridPanel: UserControl
    {
        public ProjectExplorer parentPanel { get; set; }

        public string DataFilePath { get; set; }

        private bool hasChanges;
        public bool HasChanges
        {
            get
            {
                return hasChanges;
            }
            set
            {
                hasChanges = value;
            }
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // StandardGridPanel
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StandardGridPanel";
            this.ResumeLayout(false);

        }

    }


}
