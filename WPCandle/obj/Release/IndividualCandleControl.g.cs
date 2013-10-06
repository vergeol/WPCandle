﻿#pragma checksum "C:\Users\g\Documents\GitHub\WPCandle\WPCandle\IndividualCandleControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C50A5EE9A60EBEA616B5ECA30531EE4A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.32559
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class IndividualCandleControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.Animation.Storyboard SlowFlickerStoryboard;
        
        internal System.Windows.Media.Animation.Storyboard BurningStoryboard;
        
        internal System.Windows.Media.Animation.Storyboard SideBobStoryboard;
        
        internal System.Windows.Media.Animation.Storyboard SideBobStoryboard2;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.VisualStateGroup VisualStateGroup;
        
        internal System.Windows.VisualState WhiteVisualState;
        
        internal System.Windows.VisualState BlueVisualState;
        
        internal System.Windows.VisualState FuchsiaVisualState;
        
        internal System.Windows.VisualState OrangeVisualState;
        
        internal System.Windows.VisualState GreenVisualState;
        
        internal System.Windows.VisualState PurpleVisualState;
        
        internal System.Windows.VisualState BlackVisualState;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Grid HalosContainerRotation;
        
        internal System.Windows.Shapes.Ellipse HaloGeneral;
        
        internal System.Windows.Shapes.Ellipse Halo;
        
        internal System.Windows.Controls.Grid Candle;
        
        internal System.Windows.Shapes.Ellipse BottomShadow;
        
        internal System.Windows.Shapes.Ellipse Bottom;
        
        internal System.Windows.Shapes.Rectangle Body;
        
        internal System.Windows.Controls.Grid Glows;
        
        internal System.Windows.Shapes.Rectangle CandleHaloGlow;
        
        internal System.Windows.Shapes.Ellipse CandleWickZone;
        
        internal System.Windows.Controls.Grid Meche;
        
        internal System.Windows.Controls.Grid FlameContainerRotation;
        
        internal System.Windows.Controls.Grid Flame;
        
        internal System.Windows.Shapes.Ellipse ellipse;
        
        internal System.Windows.Controls.Grid OrnamentsContainer;
        
        internal System.Windows.Controls.Grid Ornaments;
        
        internal System.Windows.Shapes.Path path;
        
        internal System.Windows.Shapes.Path path1;
        
        internal System.Windows.Shapes.Path path2;
        
        internal System.Windows.Shapes.Path path3;
        
        internal System.Windows.Shapes.Path path4;
        
        internal System.Windows.Shapes.Path path5;
        
        internal System.Windows.Shapes.Path path6;
        
        internal System.Windows.Shapes.Path path7;
        
        internal System.Windows.Shapes.Path path8;
        
        internal System.Windows.Shapes.Path path9;
        
        internal System.Windows.Shapes.Path path10;
        
        internal System.Windows.Shapes.Path path11;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WPCandle;component/IndividualCandleControl.xaml", System.UriKind.Relative));
            this.SlowFlickerStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SlowFlickerStoryboard")));
            this.BurningStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("BurningStoryboard")));
            this.SideBobStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SideBobStoryboard")));
            this.SideBobStoryboard2 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SideBobStoryboard2")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.VisualStateGroup = ((System.Windows.VisualStateGroup)(this.FindName("VisualStateGroup")));
            this.WhiteVisualState = ((System.Windows.VisualState)(this.FindName("WhiteVisualState")));
            this.BlueVisualState = ((System.Windows.VisualState)(this.FindName("BlueVisualState")));
            this.FuchsiaVisualState = ((System.Windows.VisualState)(this.FindName("FuchsiaVisualState")));
            this.OrangeVisualState = ((System.Windows.VisualState)(this.FindName("OrangeVisualState")));
            this.GreenVisualState = ((System.Windows.VisualState)(this.FindName("GreenVisualState")));
            this.PurpleVisualState = ((System.Windows.VisualState)(this.FindName("PurpleVisualState")));
            this.BlackVisualState = ((System.Windows.VisualState)(this.FindName("BlackVisualState")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.HalosContainerRotation = ((System.Windows.Controls.Grid)(this.FindName("HalosContainerRotation")));
            this.HaloGeneral = ((System.Windows.Shapes.Ellipse)(this.FindName("HaloGeneral")));
            this.Halo = ((System.Windows.Shapes.Ellipse)(this.FindName("Halo")));
            this.Candle = ((System.Windows.Controls.Grid)(this.FindName("Candle")));
            this.BottomShadow = ((System.Windows.Shapes.Ellipse)(this.FindName("BottomShadow")));
            this.Bottom = ((System.Windows.Shapes.Ellipse)(this.FindName("Bottom")));
            this.Body = ((System.Windows.Shapes.Rectangle)(this.FindName("Body")));
            this.Glows = ((System.Windows.Controls.Grid)(this.FindName("Glows")));
            this.CandleHaloGlow = ((System.Windows.Shapes.Rectangle)(this.FindName("CandleHaloGlow")));
            this.CandleWickZone = ((System.Windows.Shapes.Ellipse)(this.FindName("CandleWickZone")));
            this.Meche = ((System.Windows.Controls.Grid)(this.FindName("Meche")));
            this.FlameContainerRotation = ((System.Windows.Controls.Grid)(this.FindName("FlameContainerRotation")));
            this.Flame = ((System.Windows.Controls.Grid)(this.FindName("Flame")));
            this.ellipse = ((System.Windows.Shapes.Ellipse)(this.FindName("ellipse")));
            this.OrnamentsContainer = ((System.Windows.Controls.Grid)(this.FindName("OrnamentsContainer")));
            this.Ornaments = ((System.Windows.Controls.Grid)(this.FindName("Ornaments")));
            this.path = ((System.Windows.Shapes.Path)(this.FindName("path")));
            this.path1 = ((System.Windows.Shapes.Path)(this.FindName("path1")));
            this.path2 = ((System.Windows.Shapes.Path)(this.FindName("path2")));
            this.path3 = ((System.Windows.Shapes.Path)(this.FindName("path3")));
            this.path4 = ((System.Windows.Shapes.Path)(this.FindName("path4")));
            this.path5 = ((System.Windows.Shapes.Path)(this.FindName("path5")));
            this.path6 = ((System.Windows.Shapes.Path)(this.FindName("path6")));
            this.path7 = ((System.Windows.Shapes.Path)(this.FindName("path7")));
            this.path8 = ((System.Windows.Shapes.Path)(this.FindName("path8")));
            this.path9 = ((System.Windows.Shapes.Path)(this.FindName("path9")));
            this.path10 = ((System.Windows.Shapes.Path)(this.FindName("path10")));
            this.path11 = ((System.Windows.Shapes.Path)(this.FindName("path11")));
        }
    }
}

