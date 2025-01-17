﻿using System;
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
        Purple,
        Black,
        Red
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
                case CandleColor.Red:
                    VisualStateManager.GoToState(this, RedVisualState.Name, true);
                    break;
                case CandleColor.Black:
                    VisualStateManager.GoToState(this, BlackVisualState.Name, true);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region angle

        public double CandleAngle
        {
            get { return (double)GetValue(CandleAngleProperty); }
            set
            {
                if (CandleAngle == value)
                    return;
                else
                    SetValue(CandleAngleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CandleAngle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CandleAngleProperty =
            DependencyProperty.Register("CandleAngle", typeof(double), typeof(IndividualCandleControl), new PropertyMetadata(0.0));

        #endregion

        public IndividualCandleControl()
        {
            InitializeComponent();
            Loaded += IndividualCandleControl_Loaded;
            Tap += IndividualCandleControl_Tap;
        }

        void IndividualCandleControl_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            SetNextColor();
        }

        void IndividualCandleControl_Loaded(object sender, RoutedEventArgs e)
        {
            FlickerTimer.Tick += FlickerTimer_Tick;
            WindTimer.Tick += WindTimer_Tick;

            BeginBurning();
            BeginRandomFlicker();
            BeginRandomWind();
        }

        #region motion

        public void SetAngle(double angle)
        {
            CandleAngle = angle;
        }

        #endregion

        #region Burning
        private void BeginBurning()
        {
            BurnageSb = (Storyboard)Resources["BurningStoryboard"];
            if (BurnageSb != null)
            {
                BurnageSb.Completed += BurnageSb_Completed;
                BurnageSb.SpeedRatio = 0.005 + 0.005 * (float)r.NextDouble();
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

        #region Color

        void SetNextColor()
        {
            switch (CurrentColor)
            {
                case CandleColor.White:
                    CurrentColor = CandleColor.Blue;
                    break;
                case CandleColor.Blue:
                    CurrentColor = CandleColor.Fuchsia;
                    break;
                case CandleColor.Fuchsia:
                    CurrentColor = CandleColor.Orange;
                    break;
                case CandleColor.Orange:
                    CurrentColor = CandleColor.Green;
                    break;
                case CandleColor.Green:
                    CurrentColor = CandleColor.Purple;
                    break;
                case CandleColor.Purple:
                    CurrentColor = CandleColor.Red;
                    break;
                case CandleColor.Red:
                    CurrentColor = CandleColor.Black;
                    break;
                case CandleColor.Black:
                    CurrentColor = CandleColor.White;
                    break;
                default:
                    break;
            }
        }

        #endregion

    }
}
