using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for WPFStarterComboBox.xaml
    /// </summary>
    public partial class WPFStarterComboBox : UserControl
    {
        public WPFStarterComboBox()
        {
            InitializeComponent();
            //Init();
        }

        public delegate void ItemSelectedEventHandler(object selectedObject);
        public event ItemSelectedEventHandler SelectionChanged;


        public List<ProfileConfigItem> SuggestionItems
        {
            get { return (List<ProfileConfigItem>)GetValue(SuggestionItemsProperty); }
            set { SetValue(SuggestionItemsProperty, value); }
        }


        public static readonly DependencyProperty SuggestionItemsProperty =
            DependencyProperty.Register("SuggestionItems", typeof(List<ProfileConfigItem>), typeof(WPFStarterComboBox), new UIPropertyMetadata(null));



        public void Init(IEnumerable suggestionItems)
        {
            filteredComboBox.IsEditable = true;
            filteredComboBox.IsTextSearchEnabled = false;
            //filteredComboBox.ItemsSource = typeof(Colors).GetProperties();
            filteredComboBox.ItemsSource = suggestionItems;
            SuggestionItems = (List<ProfileConfigItem>)suggestionItems;
            filteredComboBox.PreviewMouseLeftButtonUp += FilteredComboBox_PreviewMouseLeftButtonUp;

        }

        private void FilteredComboBox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int a = 0;
        }

        private void filteredComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                //SelectionChanged.Invoke(e.AddedItems[0]);
            }
        }

        public void SetText(string text)
        {
            filteredComboBox.Text = text;
        }

        public void SetFocus()
        {
            filteredComboBox.Focus();
        }
        private void filteredComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && filteredComboBox.SelectedItem != null)
            {
                SelectionChanged.Invoke(filteredComboBox.SelectedItem);
            }
        }

        private void VirtualizingStackPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SelectionChanged.Invoke(filteredComboBox.SelectedItem);
        }

        private void VirtualizingStackPanel_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SelectionChanged.Invoke(filteredComboBox.SelectedItem);

        }
    }
}
