using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace List_App.View
{
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

            // Adding Border Color Transitions When Mouse Enters And Leaves
            GridX.MouseEnter += (sender, e) =>
            {
                BorderX.BorderBrush = new SolidColorBrush(Colors.SlateBlue);
            };
            GridX.MouseLeave += (sender, e) =>
            {
                BorderX.BorderBrush = new SolidColorBrush(Colors.LightSteelBlue);
            };

            GridX.MouseDown += (sender, e) =>
            {
                bool isChecked = Check.IsChecked ?? true;
                if(!isChecked)
                {
                    Check.IsChecked = true;
                    Textbox.Opacity = 0.6;
                }
                else
                {
                    Check.IsChecked = false;
                    Textbox.Opacity = 1;
                }
            };
        }

        private void CheckBoxChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sdffjs");
            //IsEnabled = false;
        }
    }
}
