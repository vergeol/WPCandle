﻿#pragma checksum "C:\Users\g\Documents\GitHub\WPCandle\WPCandle\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "34FF6DB042A48A618F32710B574476BA"
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


namespace WPCandle {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage phoneApplicationPage;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.VisualStateGroup VisualStateGroup;
        
        internal System.Windows.VisualState No_Info;
        
        internal System.Windows.VisualState Info;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid Scene;
        
        internal System.Windows.Shapes.Rectangle Floor;
        
        internal System.Windows.Shapes.Rectangle Bg;
        
        internal System.Windows.Controls.Grid InfoGrid;
        
        internal System.Windows.Controls.Grid stackPanel;
        
        internal System.Windows.Controls.Button ExitButton;
        
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
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.Scene = ((System.Windows.Controls.Grid)(this.FindName("Scene")));
            this.Floor = ((System.Windows.Shapes.Rectangle)(this.FindName("Floor")));
            this.Bg = ((System.Windows.Shapes.Rectangle)(this.FindName("Bg")));
            this.InfoGrid = ((System.Windows.Controls.Grid)(this.FindName("InfoGrid")));
            this.stackPanel = ((System.Windows.Controls.Grid)(this.FindName("stackPanel")));
            this.ExitButton = ((System.Windows.Controls.Button)(this.FindName("ExitButton")));
            this.InfoButton_Copy = ((System.Windows.Controls.Button)(this.FindName("InfoButton_Copy")));
            this.InfoButton = ((System.Windows.Controls.Button)(this.FindName("InfoButton")));
        }
    }
}

