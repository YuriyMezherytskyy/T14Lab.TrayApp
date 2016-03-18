using System;
using System.Windows.Forms;

namespace Tornado14.TrayApp
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (ProcessIcon pi = new ProcessIcon())
            {
                pi.Display();
                Starter starter = new Starter();
                starter.InitStarter(pi);
                starter.Show();

                TimeTracking t = new TimeTracking();
                t.Show();

                //Comments comments = new Comments();
                //comments.Show();
                //GlassForm g = new GlassForm();
                //g.Show();                

                //CheckList c = new CheckList();
                //c.Show();
                ProjectExplorer p = new ProjectExplorer();
                Application.Run(p);


            }
        }
    }
}
