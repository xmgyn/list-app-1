using System;
using System.ComponentModel;
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
    public partial class ListInput : UserControl, INotifyPropertyChanged
    {
        private string _valueX;
        private bool _check;
        private double _opacity = 1;
        public string ValueX
        {
            get { return _valueX; }
            set
            {
                _valueX = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ValueX"));
            }
        }

        public bool CheckBoxChangedX
        {
            get { return _check; }
            set
            {
                _check = value;
                HandleCheck();
                OnPropertyChanged(new PropertyChangedEventArgs("CheckBoxChangedX"));
                OnPropertyChanged(new PropertyChangedEventArgs("ValueX_Opacity"));
            }
        }

        public double ValueX_Opacity {
            get { return _opacity; }
            set
            {
                _opacity = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ValueX_Opacity"));
            }
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        // Binding UpdateSourceTrigger
        public ListInput()
        {
            DataContext = this;
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

            GridX.MouseDown += (sender, e) => CheckBoxChangedX = !(CheckBoxChangedX);  
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void HandleCheck() {
            if(CheckBoxChangedX) ValueX_Opacity = 0.6; 
            else ValueX_Opacity = 1;
        }
    }
}
