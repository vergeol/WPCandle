﻿#pragma checksum "C:\Users\g\SkyDrive\Projects\WPCandle\WPCandle\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FDBB187BFFC8ECA040B37BC3A3FD16C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.32559
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using WPCandle;


namespace WPCandle {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage phoneApplicationPage;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.VisualStateGroup VisualStateGroup;
        
        internal System.Windows.VisualState No_Info;
        
        internal System.Windows.VisualState Info;
        
        internal System.Windows.VisualStateGroup LandStates;
        
        internal System.Windows.VisualState LandscapeState;
        
        internal System.Windows.VisualState PortraitState;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid Scene;
        
        internal System.Windows.Shapes.Rectangle Floor;
        
        internal System.Windows.Shapes.Rectangle Bg;
        
        internal System.Windows.Controls.Viewbox viewbox;
        
        internal System.Windows.Controls.Grid grid;
        
        internal System.Windows.Controls.Grid Scene_Bg;
        
        internal WPCandle.IndividualCandleControl MainCandle;
        
        internal System.Windows.Controls.Grid Scene_Fg;
        
        internal System.Windows.Controls.Grid InfoGrid;
        
        internal System.Windows.Controls.Grid stackPanel;
        
        internal System.Windows.Controls.Button ExitButton_Copy;
        
        internal System.Windows.Controls.Button ExitButton;
        
        internal System.Windows.Controls.TextBlock DebugTextBlock;
        
        internal System.Windows.Controls.Button InfoButton_Copy;
        
        internal System.Windows.Controls.Button InfoButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/WPCandle;component/MainPage.xaml", System.UriKind.Relative));
            this.phoneApplicationPage = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("phoneApplicationPage")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.VisualStateGroup = ((System.Windows.VisualStateGroup)(this.FindName("VisualStateGroup")));
            this.No_Info = ((System.Windows.VisualState)(this.FindName("No_Info")));
            this.Info = ((System.Windows.VisualState)(this.FindName("Info")));
            this.LandStates = ((System.Windows.VisualStateGroup)(this.FindName("LandStates")));
            this.LandscapeState = ((System.Windows.VisualState)(this.FindName("LandscapeState")));
            this.PortraitState = ((System.Windows.VisualState)(this.FindName("PortraitState")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.Scene = ((System.Windows.Controls.Grid)(this.FindName("Scene")));
            this.Floor = ((System.Windows.Shapes.Rectangle)(this.FindName("Floor")));
            this.Bg = ((System.Windows.Shapes.Rectangle)(this.FindName("Bg")));
            this.viewbox = ((System.Windows.Controls.Viewbox)(this.FindName("viewbox")));
            this.grid = ((System.Windows.Controls.Grid)(this.FindName("grid")));
            this.Scene_Bg = ((System.Windows.Controls.Grid)(this.FindName("Scene_Bg")));
            this.MainCandle = ((WPCandle.IndividualCandleControl)(this.FindName("MainCandle")));
            this.Scene_Fg = ((System.Windows.Controls.Grid)(this.FindName("Scene_Fg")));
            this.InfoGrid = ((System.Windows.Controls.Grid)(this.FindName("InfoGrid")));
            this.stackPanel = ((System.Windows.Controls.Grid)(this.FindName("stackPanel")));
            this.ExitButton_Copy = ((System.Windows.Controls.Button)(this.FindName("ExitButton_Copy")));
            this.ExitButton = ((System.Windows.Controls.Button)(this.FindName("ExitButton")));
            this.DebugTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("DebugTextBlock")));
            this.InfoButton_Copy = ((System.Windows.Controls.Button)(this.FindName("InfoButton_Copy")));
            this.InfoButton = ((System.Windows.Controls.Button)(this.FindName("InfoButton")));
        }
    }
}

