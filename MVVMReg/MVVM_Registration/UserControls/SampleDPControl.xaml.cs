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

namespace MVVM_Registration.UserControls
{
    /// <summary>
    /// Interaction logic for SampleDPControl.xaml
    /// </summary>
    public partial class SampleDPControl : UserControl
    {
        public SampleDPControl()
        {
            InitializeComponent();
        }




        public int BirthYear
        {
            get { return (int)GetValue(BirthYearProperty); }
            set { SetValue(BirthYearProperty, value); }
        }

        public static DependencyProperty BirthYearProperty { get; set; } = 
            DependencyProperty.Register("BirthYear", typeof(int),
                typeof(SampleDPControl),
                new PropertyMetadata(1990, new PropertyChangedCallback(OnPropertyChanged),
                    new CoerceValueCallback(OnCoerceValueCallback)));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SampleDPControl ctrl = d as SampleDPControl;
            if((int)e.NewValue >2000)
            {
                SolidColorBrush Brush = new SolidColorBrush();
                Brush.Color = Colors.Red;
                ctrl.Foreground = Brush;
               // MessageBox.Show("Value Not Accepted");
            }
            else
            {
                SolidColorBrush Brush = new SolidColorBrush();
                Brush.Color = Colors.Yellow;
                ctrl.Foreground = Brush;
            }

        }

        private static object OnCoerceValueCallback(DependencyObject d, object baseValue)
        {
            SampleDPControl ctrl = d as SampleDPControl;
            if ((int)baseValue > 2003)
            {
                return baseValue =1990;
            }
            else
            {
                return baseValue;
            }
        }
        
    }
}
