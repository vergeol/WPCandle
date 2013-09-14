using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace WPCandle
{
    public partial class MainPage : PhoneApplicationPage
    {
        public Random r = new Random();
        public Storyboard FlickerSb;
        public Storyboard BurnageSb;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Loaded+=MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            FlickerSb = (Storyboard) Resources["SlowFlickerStoryboard"];
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
            FlickerSb.SpeedRatio = (float)r.NextDouble();
            FlickerSb.Begin();
        }
    }
}