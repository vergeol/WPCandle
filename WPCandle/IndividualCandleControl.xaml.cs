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
    public partial class IndividualCandleControl : UserControl
    {

        public Random r = new Random();
        public Storyboard FlickerSb;
        public Storyboard BurnageSb;
        public bool IsRotated = false;

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
