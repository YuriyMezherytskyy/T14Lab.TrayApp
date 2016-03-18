using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tornado14.TrayApp
{
    public partial class BrowserTest : Form
    {
        public BrowserTest()
        {
            InitializeComponent();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (((WebBrowser)sender).Document.GetElementById("checktext_ifr") != null)
            {
                //int a = 0;
                //((WebBrowser)sender).Document.GetElementById("tinymce").InnerHtml = "asdf";
                //((WebBrowser)sender).Document.GetElementsByTagName("body")[0].InnerHtml = ((WebBrowser)sender).Document.GetElementById("checktext_ifr").InnerHtml;
            }
            else
            {
                //e.Cancel = true;
            }

            //panel-pane-korrektor
            //((WebBrowser)sender).Document.GetElementsByTagName("body")[0].InnerHtml = ((WebBrowser)sender).Document.GetElementById("checktext_ifr").InnerHtml;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
