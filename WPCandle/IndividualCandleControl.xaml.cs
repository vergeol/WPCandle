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
using System.Windows.Threading;

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
        public Storyboard SideBobSb;
        public Storyboard SideBobSb2;
        public bool IsRotated = false;
        public DispatcherTimer FlickerTimer = new DispatcherTimer();
        public DispatcherTimer WindTimer = new DispatcherTimer();


        #region CandleColor
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
        #endregion

        public IndividualCandleControl()
        {
            InitializeComponent();
            Loaded += IndividualCandleControl_Loaded;
        }

        void IndividualCandleControl_Loaded(object sender, RoutedEventArgs e)
        {
            FlickerTimer.Tick += FlickerTimer_Tick;
            WindTimer.Tick += WindTimer_Tick;

            BeginBurning();
            BeginRandomFlicker();
            BeginRandomWind();
        }


        #region Burning
        private void BeginBurning()
        {
            BurnageSb = (Storyboard)Resources["BurningStoryboard"];
            if (BurnageSb != null)
            {
                BurnageSb.Completed += BurnageSb_Completed;
                BurnageSb.SpeedRatio = 0.05 + 0.005 * (float)r.NextDouble();
                BurnageSb.FillBehavior = FillBehavior.Stop;
                BurnageSb.Begin();
            }
        }

        void BurnageSb_Completed(object sender, EventArgs e)
        {
            BurnageSb.Begin();
        }
        #endregion


        #region Flicker
        private void BeginRandomFlicker()
        {
            FlickerTimer.Interval = TimeSpan.FromSeconds(5.0 * (float)r.NextDouble());
            FlickerSb = (Storyboard)Resources["SlowFlickerStoryboard"];
            if (FlickerSb != null)
            {
                FlickerSb.Completed += sb_Completed;
                FlickerTimer.Start();
            }
        
        }

        void sb_Completed(object sender, EventArgs e)
        {
            FlickerTimer.Interval = TimeSpan.FromSeconds(5.0 * (float)r.NextDouble());
            FlickerTimer.Start();

        }

        void FlickerTimer_Tick(object sender, EventArgs e)
        {
            FlickerTimer.Stop();
            FlickerSb.SpeedRatio = 1.0 * (float)r.NextDouble();
            FlickerSb.Begin();
        }
        #endregion


        #region Wind
        private void BeginRandomWind()
        {
            WindTimer.Interval = TimeSpan.FromSeconds(5.0 * (float)r.NextDouble());

            SideBobSb = (Storyboard)Resources["SideBobStoryboard"];
            if (SideBobSb != null)
            {
                SideBobSb.Completed += SideBobSb_Completed;
            }
            SideBobSb2 = (Storyboard)Resources["SideBobStoryboard2"];
            if (SideBobSb2 != null)
            {
                SideBobSb2.Completed += SideBobSb_Completed;
            }
            WindTimer.Start();
        }



        void SideBobSb_Completed(object sender, EventArgs e)
        {
            WindTimer.Interval = TimeSpan.FromSeconds(5.0 * (float)r.NextDouble());
            WindTimer.Start();
            
        }


        void WindTimer_Tick(object sender, EventArgs e)
        {
            WindTimer.Stop();

            if (r.NextDouble() > 0.5)
            {
                SideBobSb.SpeedRatio = 0.25 * (float)r.NextDouble()+ 0.15;
                SideBobSb.Begin();
            }
            else
            {
                SideBobSb2.SpeedRatio = 0.25 * (float)r.NextDouble() + 0.15;
                SideBobSb2.Begin();
            }
        }
        #endregion

    }
}
