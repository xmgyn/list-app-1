using List_App.View;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string text = TextB.Text;
            if (!string.IsNullOrEmpty(text)) {
                View.ListInput listInput = new View.ListInput()
                {
                    ValueX = text,
                    Margin = new Thickness(0,5,0,5),
                };
                Stack.Children.Add(listInput);
                TextB.Clear();
            }
        }

        // Handle 'ENTER' Press
        private void TextB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key is Key.Return) Add_Click( this, e);
        }
    }
}
