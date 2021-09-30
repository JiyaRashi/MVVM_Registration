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
    /// Interaction logic for MandatoryControl.xaml
    /// </summary>
    public partial class MandatoryControl : UserControl
    {
        public MandatoryControl()
        {
            InitializeComponent();
        }

        public string RequiredSymbol
        {
            get => (string)GetValue(RequiredSymbolProperty);
            set => SetValue(LabelTextProperty, value);
        }

        // Using a DependencyProperty as the backing store for RequiredSymbol.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RequiredSymbolProperty =
            DependencyProperty.Register("RequiredSymbol", typeof(string), typeof(MandatoryControl), new PropertyMetadata("*"));


        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RequiredSymbol.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(MandatoryControl), new PropertyMetadata(string
                .Empty));

        public bool IsRequiredSymbol
        {
            get { return (bool)GetValue(IsRequiredSymbolProperty); }
            set { SetValue(IsRequiredSymbolProperty, value); }
        }

        public static readonly DependencyProperty IsRequiredSymbolProperty =
            DependencyProperty.Register("IsRequiredSymbol", typeof(bool), typeof(MandatoryControl), new PropertyMetadata(true,OnRequiredChange));

        private static void OnRequiredChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MandatoryControl ctrl = d as MandatoryControl;
            if ((bool)e.NewValue == false)
            {
                ctrl.RequiredSymbol = string.Empty;
            }
        }
    }
}
