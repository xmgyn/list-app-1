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

namespace List_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // MainWindow() => InitializeComponent(); This Will Work Too
        public MainWindow()
        {
            InitializeComponent();
            //EventManager.RegisterClassHandler(typeof(CheckBox), , new RoutedEventHandler(CheckBoxChanged));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string text = TextB.Text;
            if (!string.IsNullOrEmpty(text)) {
                TextBlock textBox = new TextBlock
                {
                    Text = text.ToUpper(),
                    FontSize = 20,
                    TextWrapping = TextWrapping.Wrap,
                };
                CheckBox tempblock = new CheckBox
                {
                    ToolTip = "Mark As Done",
                    Content = textBox,
                    Margin = new Thickness(5),
                    VerticalContentAlignment = VerticalAlignment.Center
                };
                Stack.Children.Add(tempblock);
                TextB.Clear();
            }
        }

        private void TextB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key is Key.Return) Add_Click( this, e);
        }

        private void CheckBoxChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sdffjs");
            //IsEnabled = false;
        }
    }
}
