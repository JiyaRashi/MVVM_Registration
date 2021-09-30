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
    /// Interaction logic for TimeControl.xaml
    /// </summary>
    public partial class TimeControl : UserControl
    {
        public TimeControl()
        {
            InitializeComponent();
        }

        public DateTime ShowTime
        {
            get { return (DateTime)base.GetValue(ShowTimeProperty); }
            set { base.SetValue(ShowTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowTimeProperty =
            DependencyProperty.Register("ShowTime", typeof(DateTime), typeof(TimeControl), new PropertyMetadata(DateTime.Now,new PropertyChangedCallback(OnPropertityChanged),new CoerceValueCallback(CoerceValueCallbackValue)));

        private static object CoerceValueCallbackValue(DependencyObject d, object baseValue)
        {
            TimeControl ctrl = d as TimeControl;
            return  DateTime.Now;
        }

        private static void OnPropertityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TimeControl ctrl = d as TimeControl;
            ctrl.ShowTime = DateTime.Now;
        }
    }
}
