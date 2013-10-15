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
using Microsoft.Devices.Sensors;
using DashboardDazzler.Assets.Managers;
using Microsoft.Xna.Framework;

namespace WPCandle
{
    public partial class MainPage : PhoneApplicationPage
    {
        bool loaded = false;
        PageOrientation lastOrientation;
        EventHandler<SensorReadingEventArgs<MotionReading>> motionEventHandler;


        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
            Unloaded += new RoutedEventHandler(MainPage_Unloaded);
            OrientationChanged += new EventHandler<OrientationChangedEventArgs>(MainPage_OrientationChanged);
            lastOrientation = this.Orientation;
            VisualStateManager.GoToState(this, PortraitState.Name, true);
        }


        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            InitialiseMotion();
            loaded = true;
            PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled;
        }

        void MainPage_Unloaded(object sender, RoutedEventArgs e)
        {
            UninitialiseMotion();
        }




        #region Motion

        void InitialiseMotion()
        {
            if (!Motion.IsSupported)
                MessageBox.Show("Oh No", "Motion API didn't work", MessageBoxButton.OK);

            try
            {
                motionEventHandler = new EventHandler<SensorReadingEventArgs<MotionReading>>(motion_CurrentValueChanged);
                //MotionManager.Instance.motion.TimeBetweenUpdates = TimeSpan.FromMilliseconds(100);
                MotionManager.Instance.motion.CurrentValueChanged += motionEventHandler;
            }
            catch (Exception e)
            {
                MotionManager.Instance.DisplayError();
            }

        }

        private void UninitialiseMotion()
        {
            MotionManager.Instance.motion.CurrentValueChanged -= motionEventHandler;
            motionEventHandler = null;
        }

        void motion_CurrentValueChanged(object sender, SensorReadingEventArgs<MotionReading> e)
        {
            // This event arrives on a background thread. Use BeginInvoke to call
            // CurrentValueChanged on the UI thread.
            Dispatcher.BeginInvoke(() => CurrentValueChanged(e.SensorReading));
        }

        private void CurrentValueChanged(MotionReading e)
        {
            //// Check to see if the Motion data is valid.
            if (MotionManager.Instance.motion.IsDataValid)
            {
                //// Show the numeric values for attitude.
                //yawTextBlock.Text = "YAW: " + MathHelper.ToDegrees(e.Attitude.Yaw).ToString("0") + "°";
                //pitchTextBlock.Text = "PITCH: " + MathHelper.ToDegrees(e.Attitude.Pitch).ToString("0") + "°";
                //rollTextBlock.Text = "ROLL: " + MathHelper.ToDegrees(e.Attitude.Roll).ToString("0") + "°";

                //// Set the Angle of the triangle RenderTransforms to the attitude of the device.
                //((RotateTransform)yawtriangle.RenderTransform).Angle = MathHelper.ToDegrees(e.Attitude.Yaw);
                //((RotateTransform)pitchtriangle.RenderTransform).Angle = MathHelper.ToDegrees(e.Attitude.Pitch);
                //((RotateTransform)rolltriangle.RenderTransform).Angle = MathHelper.ToDegrees(e.Attitude.Roll);

                // Show the numeric values for acceleration.
                //xTextBlock.Text = "X: " + e.DeviceAcceleration.X.ToString("0.00");
                //yTextBlock.Text = "Y: " + e.DeviceAcceleration.Y.ToString("0.00");
                //zTextBlock.Text = "Z: " + e.DeviceAcceleration.Z.ToString("0.00");

                // Show the acceleration values graphically.
                //xLine.X2 = xLine.X1 + e.DeviceAcceleration.X * 100;
                //yLine.Y2 = yLine.Y1 - e.DeviceAcceleration.Y * 100;
                //zLine.X2 = zLine.X1 - e.DeviceAcceleration.Z * 50;
                //zLine.Y2 = zLine.Y1 + e.DeviceAcceleration.Z * 50;

                //this.nodderControl.SendDeviationOf(
                //    e.DeviceAcceleration.X,
                //    e.DeviceAcceleration.Y,
                //    e.DeviceAcceleration.Z,
                //    e.DeviceRotationRate.X,
                //    e.DeviceRotationRate.Z);


                double Angle = 0.0;
                if (lastOrientation == null)
                {
                    MainCandle.SetAngle(0.0);
                }
                else
                {
                    switch (lastOrientation)
                    {
                        case PageOrientation.Landscape:
                        case PageOrientation.LandscapeLeft:
                        case PageOrientation.LandscapeRight:
                            Angle = 0.0;
                            break;
                        case PageOrientation.None:
                        case PageOrientation.Portrait:
                        case PageOrientation.PortraitDown:
                        case PageOrientation.PortraitUp:
                            Angle = -1.0 * (double)MathHelper.ToDegrees(e.Attitude.Roll);
                            break;
                        default:

                            break;
                    }
                }
                //DebugTextBlock.Text =  lastOrientation.ToString()+ " " + Angle.ToString();
                MainCandle.SetAngle(Angle);
            }
        }

        #endregion


        void MainPage_OrientationChanged(object sender, OrientationChangedEventArgs e)
        {
            PageOrientation newOrientation = e.Orientation;

            //// Orientations are (clockwise) 'PortraitUp', 'LandscapeRight', 'LandscapeLeft'
            RotateTransition transitionElement = new RotateTransition();

            switch (newOrientation)
            {
                case PageOrientation.Landscape:
                case PageOrientation.LandscapeRight:
                    //// Come here from PortraitUp (i.e. clockwise) or LandscapeLeft?
                    if (lastOrientation == PageOrientation.PortraitUp)
                        transitionElement.Mode = RotateTransitionMode.In90Counterclockwise;
                    else
                        transitionElement.Mode = RotateTransitionMode.In180Clockwise;
                    VisualStateManager.GoToState(this, LandscapeState.Name, true);
                    break;
                case PageOrientation.LandscapeLeft:
                    // Come here from LandscapeRight or PortraitUp?
                    if (lastOrientation == PageOrientation.LandscapeRight)
                        transitionElement.Mode = RotateTransitionMode.In180Counterclockwise;
                    else
                        transitionElement.Mode = RotateTransitionMode.In90Clockwise;
                    VisualStateManager.GoToState(this, LandscapeState.Name, true);
                    break;
                case PageOrientation.Portrait:
                case PageOrientation.PortraitUp:
                    // Come here from LandscapeLeft or LandscapeRight?
                    if (lastOrientation == PageOrientation.LandscapeLeft)
                        transitionElement.Mode = RotateTransitionMode.In90Counterclockwise;
                    else
                        transitionElement.Mode = RotateTransitionMode.In90Clockwise;
                    VisualStateManager.GoToState(this, PortraitState.Name, true);
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