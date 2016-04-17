using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public string Text
        {
            get
            {
                return CustomEditor.Text2;
            }
            set
            {
                CustomEditor.Text2 = value;
            }
        }

        private Object data = null;
        private string displayMember;

        public void SetDataBinding(object obj, string displayMember)
        {
            this.data = obj;
            this.displayMember = displayMember;
            try {
                this.Text = obj.GetType().GetProperty(displayMember).GetValue(obj, null).ToString();
            } catch (Exception ex)
            {
                this.Text = "";
                Debug.WriteLine(ex.Message);
            }
        }

        private void CustomEditor_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(displayMember))
            {
                this.data.GetType().GetProperty(displayMember).SetValue(this.data, this.Text);
            }
        }

        private List<CompletionItem> completitionItemList = new List<CompletionItem>();

        public void FillComletionList(List<CompletionItem> completitionItemList)
        {
            Dictionary<string, List<string>> completitionDictionary = new Dictionary<string, List<string>>();
            foreach (CompletionItem item in completitionItemList)
            {
                List<string> attributes = new List<string>();
                attributes.Add(item.PopUpText);
                attributes.Add(item.ReplacementText);
                completitionDictionary.Add(item.DisplayText, attributes);
            }
            CustomEditor.FillCompletionData(completitionDictionary);
        }


        private void TextArea_LostFocus(object sender, RoutedEventArgs e)
        {
            if (this.displayMember != null)
            {
                this.data.GetType().GetProperty(displayMember).SetValue(this.data, this.Text);
            }
        }

        public WPFRichTextBox()
        {
            InitializeComponent();
            CustomEditor.TextChanged += CustomEditor_TextChanged;
            CustomEditor.HeaderClicked += CustomEditor_HeaderClicked;
        }
        public event EventHandler HeaderClicked;
        private void CustomEditor_HeaderClicked(object sender, EventArgs e)
        {
            HeaderClicked.Invoke(this, new EventArgs());
        }
    }
}
