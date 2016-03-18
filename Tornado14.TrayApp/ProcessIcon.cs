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
        Starter starter;
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

        internal void Display()
        {
            notifyIcon.MouseClick += new MouseEventHandler(ni_MouseClick);
            DirectoryInfo iconsFolder = new DirectoryInfo(Application.StartupPath + "\\icons");
            Icon trayIcon = new Icon(iconsFolder.FullName + "\\trayIcon.ico");
            notifyIcon.Icon = trayIcon;
            notifyIcon.Visible = true;

            string profile = "start.xml";
            new ContextMenus().create(profile, notifyIcon);
            //ni.ShowBalloonTip(3000, "Text 1", "Text 2", ToolTipIcon.Info);
        }

        void ni_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                /*
                Point currentMousePosition = Cursor.Position;
                currentMousePosition.X -= 100;
                ni.ContextMenuStrip.Show(currentMousePosition);
                */
                if (starter != null) {
                    starter.Close();
                    starter = null;
                }
                starter = new Starter();
                starter.Show();
                starter.BringToFront();
            }
        }

        public void Dispose()
        {
            notifyIcon.Dispose();
        }
    }
}
