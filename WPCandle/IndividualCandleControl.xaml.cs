using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Animation;

namespace WPCandle
{

    public enum CandleColor 
    {
        White,
        Blue, 
        Fuchsia,
        Orange,
        Green,
        Purple
    }

    public partial class IndividualCandleControl : UserControl
    {

        public Random r = new Random();
        public Storyboard FlickerSb;
        public Storyboard BurnageSb;
        public bool IsRotated = false;



        public CandleColor CurrentColor
        {
            get { return (CandleColor)GetValue(CurrentColorProperty); }
            set { SetValue(CurrentColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentColorProperty =
            DependencyProperty.Register("CurrentColor", typeof(CandleColor), typeof(IndividualCandleControl), new PropertyMetadata(OnColorChanged));

        private static void OnColorChanged(DependencyObject element, DependencyPropertyChangedEventArgs e)
        {
            (element as IndividualCandleControl).UpdateColor();
        }

        public void UpdateColor()
        {
            switch (CurrentColor)
            {
                case CandleColor.White:
                    VisualStateManager.GoToState(this, WhiteVisualState.Name, true);
                    break;
                case CandleColor.Blue:
                    VisualStateManager.GoToState(this, BlueVisualState.Name, true);
                    break;
                case CandleColor.Fuchsia:
                    VisualStateManager.GoToState(this, FuchsiaVisualState.Name, true);
                    break;
                case CandleColor.Orange:
                    VisualStateManager.GoToState(this, OrangeVisualState.Name, true);
                    break;
                case CandleColor.Green:
                    VisualStateManager.GoToState(this, GreenVisualState.Name, true);
                    break;
                case CandleColor.Purple:
                    VisualStateManager.GoToState(this, PurpleVisualState.Name, true);
                    break;
                default:
                    break;
            }
        }

        public IndividualCandleControl()
        {
            InitializeComponent();
            Loaded += IndividualCandleControl_Loaded;
        }

        void IndividualCandleControl_Loaded(object sender, RoutedEventArgs e)
        {
            FlickerSb = (Storyboard)Resources["SlowFlickerStoryboard"];
            if (FlickerSb != null)
            {
                FlickerSb.Completed += sb_Completed;
                FlickerSb.Begin();
            }
            BurnageSb = (Storyboard)Resources["BurningStoryboard"];
            if (BurnageSb != null)
            {
                BurnageSb.Completed += BurnageSb_Completed;
                BurnageSb.SpeedRatio = 0.01;
                BurnageSb.FillBehavior = FillBehavior.Stop;
                BurnageSb.Begin();
            }
        }

        void BurnageSb_Completed(object sender, EventArgs e)
        {
            BurnageSb.Begin();
        }

        void sb_Completed(object sender, EventArgs e)
        {
            FlickerSb.SpeedRatio = 2.0 * (float)r.NextDouble();
            FlickerSb.Begin();
        }
    }
}
