using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tornado14.TrayApp.Controls
{
    /// <summary>
    /// Interaction logic for WPFRichTextBox.xaml
    /// </summary>
    public partial class WPFRichTextBox : UserControl
    {
        public string Text {
            get {
                return CustomEditor.Text2;
            }
            set
            {
                CustomEditor.Text2 = value;
            }
        }
        public WPFRichTextBox()
        {
            InitializeComponent();
        }
    }
}
