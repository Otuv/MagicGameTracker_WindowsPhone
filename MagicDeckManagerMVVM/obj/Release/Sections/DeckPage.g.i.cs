﻿#pragma checksum "C:\Users\Otto\Documents\GitHub\MagicGameTracker_WindowsPhone\MagicDeckManagerMVVM\Sections\DeckPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8DDD1FC27741B58E56133A9DDE1BE023"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class DeckPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Advertising.Mobile.UI.AdControl adDeck;
        
        internal System.Windows.Controls.Grid DeckDetailsPanel;
        
        internal MagicGameTracker.View.DeckDetails DeckDetails;
        
        internal System.Windows.Controls.Grid DeckStatisticsPanel;
        
        internal MagicGameTracker.View.DeckStatisticsView DeckStatistics;
        
        internal System.Windows.Controls.Grid DeckGamesPanel;
        
        internal MagicGameTracker.View.GamesListView GamesListView;
        
        internal System.Windows.Controls.Grid DeckAlterationsPanel;
        
        internal MagicGameTracker.View.AlterationList DeckAlterationList;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton bHelp;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton bAddGame;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton bRegisterChange;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton bToggleActive;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem bDeleteDeck;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MagicDeckManagerMVVM;component/Sections/DeckPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.adDeck = ((Microsoft.Advertising.Mobile.UI.AdControl)(this.FindName("adDeck")));
            this.DeckDetailsPanel = ((System.Windows.Controls.Grid)(this.FindName("DeckDetailsPanel")));
            this.DeckDetails = ((MagicGameTracker.View.DeckDetails)(this.FindName("DeckDetails")));
            this.DeckStatisticsPanel = ((System.Windows.Controls.Grid)(this.FindName("DeckStatisticsPanel")));
            this.DeckStatistics = ((MagicGameTracker.View.DeckStatisticsView)(this.FindName("DeckStatistics")));
            this.DeckGamesPanel = ((System.Windows.Controls.Grid)(this.FindName("DeckGamesPanel")));
            this.GamesListView = ((MagicGameTracker.View.GamesListView)(this.FindName("GamesListView")));
            this.DeckAlterationsPanel = ((System.Windows.Controls.Grid)(this.FindName("DeckAlterationsPanel")));
            this.DeckAlterationList = ((MagicGameTracker.View.AlterationList)(this.FindName("DeckAlterationList")));
            this.bHelp = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("bHelp")));
            this.bAddGame = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("bAddGame")));
            this.bRegisterChange = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("bRegisterChange")));
            this.bToggleActive = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("bToggleActive")));
            this.bDeleteDeck = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("bDeleteDeck")));
        }
    }
}

