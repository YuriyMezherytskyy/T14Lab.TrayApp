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
        private NotifyIcon ni;

        public NotifyIcon Ni
        {
            get { return ni; }
            set { ni = value; }
        }

        public ProcessIcon()
        {
            ni = new NotifyIcon();
        }

        internal void Display()
        {
            ni.MouseClick += new MouseEventHandler(ni_MouseClick);
            DirectoryInfo iconsFolder = new DirectoryInfo(Application.StartupPath + "\\icons");
            Icon trayIcon = new Icon(iconsFolder.FullName + "\\trayIcon.ico");
            ni.Icon = trayIcon;
            ni.Visible = true;

            string profile = "start.xml";
            new ContextMenus().create(profile, ni);
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

            }
        }

        public void Dispose()
        {
            ni.Dispose();
        }
    }
}
