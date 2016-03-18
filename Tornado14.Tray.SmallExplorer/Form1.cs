using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tornado14.Tray.SmallExplorer
{
    public partial class Form1 : Form
    {
        FileSystemWatcher FSW;
        DirectoryInfo info = new DirectoryInfo(@"c:\temp\3");

        public Form1()
        {
            InitializeComponent();
            
            // Filesystemwatcher anlegen
            FSW = new FileSystemWatcher();

            // Pfad und Filter festlegen
            FSW.Path = info.FullName;
            FSW.Filter = "*.txt";

            // Events definieren
            FSW.Changed += new FileSystemEventHandler(FSW_Changed);
            FSW.Created += new FileSystemEventHandler(FSW_Created);
            FSW.Deleted += new FileSystemEventHandler(FSW_Deleted);
            FSW.Renamed += new RenamedEventHandler(FSW_Renamed);

            // Filesystemwatcher aktivieren
            FSW.EnableRaisingEvents = true;

            PopulateTreeView(info);

        }


        private void PopulateTreeView(DirectoryInfo info)
        {
            
            if (info.Exists)
            {
                
                DirectoryInfo nodeDirInfo = info;
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;
                listView1.Items.Clear();
                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 0);
                    subItems = new ListViewItem.ListViewSubItem[]
                  {new ListViewItem.ListViewSubItem(item, "Directory"), 
                   new ListViewItem.ListViewSubItem(item, 
				dir.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    item = new ListViewItem(file.Name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                  { new ListViewItem.ListViewSubItem(item, "File"), 
                   new ListViewItem.ListViewSubItem(item, 
				file.LastAccessTime.ToShortDateString())};

                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                MessageBox.Show("Folder not exist:" + info, "Wrong parameter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void FSW_Renamed(object sender, RenamedEventArgs e)
        {
        }

        void FSW_Deleted(object sender, FileSystemEventArgs e)
        {
            listView1.Invoke((MethodInvoker)(() =>
            {
                PopulateTreeView(info);
            }));
        }

        void FSW_Created(object sender, FileSystemEventArgs e)
        {
            listView1.Invoke((MethodInvoker)(() =>
            {
                PopulateTreeView(info);
            }));
        }

        void FSW_Changed(object sender, FileSystemEventArgs e)
        {
            listView1.Invoke((MethodInvoker)(() =>
            {
                PopulateTreeView(info);
            }));
        }

    }
}
