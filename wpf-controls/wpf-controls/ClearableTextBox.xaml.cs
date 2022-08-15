using System;
using System.Collections.Generic;
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

namespace wpf_controls
{
    /// <summary>
    /// Логика взаимодействия для ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(ClearableTextBox));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private void ClearContentButton_Click(object sender, RoutedEventArgs e)
        {
            ContentTextBox.Text = string.Empty;
        }
    }
}
