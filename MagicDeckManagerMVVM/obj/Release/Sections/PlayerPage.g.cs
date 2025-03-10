﻿#pragma checksum "C:\Users\Otto\Documents\GitHub\MagicGameTracker_WindowsPhone\MagicDeckManagerMVVM\Sections\PlayerPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8E19F29170919AA9E443150626C94349"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MagicGameTracker.Components;
using MagicGameTracker.View;
using Microsoft.Advertising.Mobile.UI;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
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


namespace MagicGameTracker.Sections {
    
    
    public partial class PlayerPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Advertising.Mobile.UI.AdControl adPlayerPage;
        
        internal MagicGameTracker.View.PlayerWinrate PlayerWinrateView;
        
        internal MagicGameTracker.Components.WinrateHistoryGraphSlim PlayerWinrateGraph;
        
        internal MagicGameTracker.Components.ColorsUsedGraphSlim PlayerColorsUsedGraph;
        
        internal MagicGameTracker.View.PlayerWinrate ActivePlayerWinrateView;
        
        internal MagicGameTracker.Components.WinrateHistoryGraphSlim ActiveWinrateGraph;
        
        internal MagicGameTracker.Components.ColorsUsedGraphSlim ActiveColorsUsedGraph;
        
        internal MagicGameTracker.View.PlayerWinrate TodayPlayerWinrateView;
        
        internal MagicGameTracker.Components.WinrateHistoryGraphSlim TodayWinrateGraph;
        
        internal MagicGameTracker.Components.ColorsUsedGraphSlim TodayColorsUsedGraph;
        
        internal MagicGameTracker.Components.ColorsUsedGraph ColorsFoundInAciveDecksGraph;
        
        internal MagicGameTracker.Components.ColorsUsedGraph ColorsFoundInAllDecksGraph;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton bHelp;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MagicDeckManagerMVVM;component/Sections/PlayerPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.adPlayerPage = ((Microsoft.Advertising.Mobile.UI.AdControl)(this.FindName("adPlayerPage")));
            this.PlayerWinrateView = ((MagicGameTracker.View.PlayerWinrate)(this.FindName("PlayerWinrateView")));
            this.PlayerWinrateGraph = ((MagicGameTracker.Components.WinrateHistoryGraphSlim)(this.FindName("PlayerWinrateGraph")));
            this.PlayerColorsUsedGraph = ((MagicGameTracker.Components.ColorsUsedGraphSlim)(this.FindName("PlayerColorsUsedGraph")));
            this.ActivePlayerWinrateView = ((MagicGameTracker.View.PlayerWinrate)(this.FindName("ActivePlayerWinrateView")));
            this.ActiveWinrateGraph = ((MagicGameTracker.Components.WinrateHistoryGraphSlim)(this.FindName("ActiveWinrateGraph")));
            this.ActiveColorsUsedGraph = ((MagicGameTracker.Components.ColorsUsedGraphSlim)(this.FindName("ActiveColorsUsedGraph")));
            this.TodayPlayerWinrateView = ((MagicGameTracker.View.PlayerWinrate)(this.FindName("TodayPlayerWinrateView")));
            this.TodayWinrateGraph = ((MagicGameTracker.Components.WinrateHistoryGraphSlim)(this.FindName("TodayWinrateGraph")));
            this.TodayColorsUsedGraph = ((MagicGameTracker.Components.ColorsUsedGraphSlim)(this.FindName("TodayColorsUsedGraph")));
            this.ColorsFoundInAciveDecksGraph = ((MagicGameTracker.Components.ColorsUsedGraph)(this.FindName("ColorsFoundInAciveDecksGraph")));
            this.ColorsFoundInAllDecksGraph = ((MagicGameTracker.Components.ColorsUsedGraph)(this.FindName("ColorsFoundInAllDecksGraph")));
            this.bHelp = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("bHelp")));
        }
    }
}

