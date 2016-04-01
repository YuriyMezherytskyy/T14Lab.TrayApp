using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Shapes;
using Tornado14.TrayApp.Properties;

namespace Tornado14.TrayApp
{
    public class ProcessIcon : IDisposable
    {
        private NotifyIcon notifyIcon;

        public NotifyIcon NotifyIcon
        {
            get { return notifyIcon; }
            set { notifyIcon = value; }
        }

        public ProcessIcon()
        {
            notifyIcon = new NotifyIcon();
        }
        ContextMenus cm;

        internal void Display()
        {
            notifyIcon.MouseClick += new MouseEventHandler(ni_MouseClick);
            DirectoryInfo iconsFolder = new DirectoryInfo(Application.StartupPath + "\\icons");
            Icon trayIcon = new Icon(iconsFolder.FullName + "\\trayIcon.ico");
            notifyIcon.Icon = trayIcon;
            notifyIcon.Visible = true;

            cm = new ContextMenus().Create("start.xml", notifyIcon);
            //ni.ShowBalloonTip(3000, "Text 1", "Text 2", ToolTipIcon.Info);
        }

        void ni_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cm.LoadSettingsContextMenu();
            } else if (e.Button == MouseButtons.Right)
            {
                cm.LoadLastSelectedProfile();
            }
        }

        public void Dispose()
        {
            notifyIcon.Dispose();
        }
    }
}
