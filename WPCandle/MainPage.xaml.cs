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
using Microsoft.Phone.Shell;

namespace WPCandle
{
    public partial class MainPage : PhoneApplicationPage
    {

        PageOrientation lastOrientation;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
            OrientationChanged += new EventHandler<OrientationChangedEventArgs>(MainPage_OrientationChanged);
            lastOrientation = this.Orientation;
        }


        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled;
        }



        void MainPage_OrientationChanged(object sender, OrientationChangedEventArgs e)
        {
            PageOrientation newOrientation = e.Orientation;

            // Orientations are (clockwise) 'PortraitUp', 'LandscapeRight', 'LandscapeLeft'
            RotateTransition transitionElement = new RotateTransition();

            switch (newOrientation)
            {
                case PageOrientation.Landscape:
                case PageOrientation.LandscapeRight:
                    // Come here from PortraitUp (i.e. clockwise) or LandscapeLeft?
                    if (lastOrientation == PageOrientation.PortraitUp)
                        transitionElement.Mode = RotateTransitionMode.In90Counterclockwise;
                    else
                        transitionElement.Mode = RotateTransitionMode.In180Clockwise;
                    break;
                case PageOrientation.LandscapeLeft:
                    // Come here from LandscapeRight or PortraitUp?
                    if (lastOrientation == PageOrientation.LandscapeRight)
                        transitionElement.Mode = RotateTransitionMode.In180Counterclockwise;
                    else
                        transitionElement.Mode = RotateTransitionMode.In90Clockwise;
                    break;
                case PageOrientation.Portrait:
                case PageOrientation.PortraitUp:
                    // Come here from LandscapeLeft or LandscapeRight?
                    if (lastOrientation == PageOrientation.LandscapeLeft)
                        transitionElement.Mode = RotateTransitionMode.In90Counterclockwise;
                    else
                        transitionElement.Mode = RotateTransitionMode.In90Clockwise;
                    break;
                default:
                    break;
            }

            // Execute the transition
            PhoneApplicationPage phoneApplicationPage = (PhoneApplicationPage)(((PhoneApplicationFrame)Application.Current.RootVisual)).Content;
            ITransition transition = transitionElement.GetTransition(phoneApplicationPage);
            transition.Completed += delegate
            {
                transition.Stop();
            };
            transition.Begin();

            lastOrientation = newOrientation;

        }
    }
}