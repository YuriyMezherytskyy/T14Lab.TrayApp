using ICSharpCode.AvalonEdit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Tornado14.WPFControls
{
    [Obsolete]
    public class MvvmTextEditor : TextEditor, INotifyPropertyChanged
    {
        public static readonly DependencyProperty MyContentProperty = DependencyProperty.Register(
             "MyContent", typeof(string), typeof(MvvmTextEditor), new PropertyMetadata("", OnMyContentChanged));

        private static void OnMyContentChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var control = (MvvmTextEditor)sender;
            if (e.NewValue != null && string.Compare(control.MyContent, e.NewValue.ToString()) != 0)
            {
                //avoid undo stack overflow
                control.MyContent = e.NewValue.ToString();
            }
        }

        public string MyContent
        {
            get
            {
                string result = Text;
                return result;
            }
            set
            {
                Text = value;
                
            }
        }

        protected override void OnLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            SetCurrentValue(MyContentProperty, Text);
            RaisePropertyChanged("MyContent");
            base.OnLostKeyboardFocus(e);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
