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
using static System.Net.Mime.MediaTypeNames;

namespace List_App.View
{
    /// <summary>
    /// Interaction logic for ListInput.xaml
    /// </summary>
    public partial class ListInput : UserControl
    {
        public string Value
        {
            get { return Value; }
            set
            {
                Textbox.Text = value.ToUpper();
            }
        }

        public ListInput()
        {
            InitializeComponent();
            /*CheckBox tempblock = new CheckBox
            {
                ToolTip = "Mark As Done",
                Content = textBox,
                Margin = new Thickness(5),
                VerticalContentAlignment = VerticalAlignment.Center
            };*/
            
        }

        private void CheckBoxChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sdffjs");
            //IsEnabled = false;
        }
    }
}
