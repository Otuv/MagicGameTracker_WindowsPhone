﻿#pragma checksum "C:\Users\Otto\Documents\GitHub\MagicGameTracker_WindowsPhone\MagicDeckManagerMVVM\Components\ColorsUsedGraph.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EE759D086DD2E552B554FC0E3126B0CC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace MagicGameTracker.Components {
    
    
    public partial class ColorsUsedGraph : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock tbViewTitle;
        
        internal System.Windows.Controls.Canvas ColorsUsedCanvas;
        
        internal System.Windows.Controls.TextBlock tbNumberOfBlack;
        
        internal System.Windows.Controls.TextBlock tbNumberOfWhite;
        
        internal System.Windows.Controls.TextBlock tbNumberOfRed;
        
        internal System.Windows.Controls.TextBlock tbNumberOfBlue;
        
        internal System.Windows.Controls.TextBlock tbNumberOfGreen;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MagicDeckManagerMVVM;component/Components/ColorsUsedGraph.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.tbViewTitle = ((System.Windows.Controls.TextBlock)(this.FindName("tbViewTitle")));
            this.ColorsUsedCanvas = ((System.Windows.Controls.Canvas)(this.FindName("ColorsUsedCanvas")));
            this.tbNumberOfBlack = ((System.Windows.Controls.TextBlock)(this.FindName("tbNumberOfBlack")));
            this.tbNumberOfWhite = ((System.Windows.Controls.TextBlock)(this.FindName("tbNumberOfWhite")));
            this.tbNumberOfRed = ((System.Windows.Controls.TextBlock)(this.FindName("tbNumberOfRed")));
            this.tbNumberOfBlue = ((System.Windows.Controls.TextBlock)(this.FindName("tbNumberOfBlue")));
            this.tbNumberOfGreen = ((System.Windows.Controls.TextBlock)(this.FindName("tbNumberOfGreen")));
        }
    }
}

