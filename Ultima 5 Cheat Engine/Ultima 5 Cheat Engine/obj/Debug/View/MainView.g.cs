﻿#pragma checksum "..\..\..\View\MainView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3732F244A439B477AD959E68AE4DF36C8139E92B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GalaSoft.MvvmLight.Command;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Ultima_5_Cheat_Engine.Converter;
using Ultima_5_Cheat_Engine.View;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Ultima_5_Cheat_Engine.View {
    
    
    /// <summary>
    /// MainView
    /// </summary>
    public partial class MainView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PlayerBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FileBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FileButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid2;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown HitPoints;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown MaxHP;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown Strength;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown Dexterity;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown Intelligence;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown Experience;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown Gold;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button KeyButton;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SkullKeyButton;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GemButton;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BlackBadgeButton;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MagicCarpetButton;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MagicAxeButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Ultima 5 Cheat Engine;component/view/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MainView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.PlayerBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 21 "..\..\..\View\MainView.xaml"
            this.PlayerBox.AddHandler(System.Windows.Controls.Primitives.ScrollBar.ScrollEvent, new System.Windows.Controls.Primitives.ScrollEventHandler(this.PlayerBox_Scroll));
            
            #line default
            #line hidden
            return;
            case 3:
            this.SelectButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.FileBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.FileButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.Grid2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.HitPoints = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 9:
            this.MaxHP = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 10:
            this.Strength = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 11:
            this.Dexterity = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 12:
            this.Intelligence = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 13:
            this.Experience = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 14:
            this.Gold = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 15:
            this.KeyButton = ((System.Windows.Controls.Button)(target));
            return;
            case 16:
            this.SkullKeyButton = ((System.Windows.Controls.Button)(target));
            return;
            case 17:
            this.GemButton = ((System.Windows.Controls.Button)(target));
            return;
            case 18:
            this.BlackBadgeButton = ((System.Windows.Controls.Button)(target));
            return;
            case 19:
            this.MagicCarpetButton = ((System.Windows.Controls.Button)(target));
            return;
            case 20:
            this.MagicAxeButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
