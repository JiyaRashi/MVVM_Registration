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
using System.Windows.Threading;

namespace MVVM_Registration.UserControls
{
    /// <summary>
    /// Interaction logic for TimeControl.xaml
    /// </summary>
    public partial class TimeControl : UserControl
    {
        public DateTime Time
        {
            get { return (DateTime)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }
        public TimeControl()
        {
            InitializeComponent();
        }

        // Using a DependencyProperty as the backing store for ShowTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TimeProperty =
            DependencyProperty.Register("Time", typeof(DateTime), typeof(TimeControl),
                new PropertyMetadata(DateTime.Now));
        public static readonly RoutedEvent TimeChangedEvent = EventManager.
            RegisterRoutedEvent("TimeChanged", RoutingStrategy.Bubble, 
            typeof(RoutedPropertyChangedEventHandler<DateTime>), typeof(TimeControl));

        //private static object CoerceValueCallbackValue(DependencyObject d, object baseValue)
        //{
        //    TimeControl ctrl = d as TimeControl;
        //    return  DateTime.Now;
        //}

        //private static void OnPropertityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{

        //    TimeControl clock = d as TimeControl;
        //  //  clock.RaiseEvent(new RoutedPropertyChangedEventArgs<DateTime>((DateTime)e.OldValue, (DateTime)e.NewValue, TimeChangedEvent));

        //}

        protected virtual void OnTimeChanged(DateTime newTime)
        {
            Time = newTime;
        }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            OnTimeChanged(DateTime.Now);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += (s, j) => OnTimeChanged(DateTime.Now);
            timer.Start();
        }

        public event RoutedPropertyChangedEventHandler<DateTime> TimeChanged
        {
            add
            {
                AddHandler(TimeChangedEvent, value);
            }
            remove
            {
                RemoveHandler(TimeChangedEvent, value);
            }
        }

    }

        //private static void OnTimeChanged(DependencyObject d,DateTime now)
        //{
            
        //}
    
}
