﻿#pragma checksum "..\..\window.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DB777462729D12D6EB1571D514B152CC"
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
using ZooScenario;


namespace ZooScenario {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ZooScenario.MainWindow window;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button admitGuestButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button feedAnimalButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border temperatureBorder;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.RepeatButton increaseTemperature;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.RepeatButton decreaseTemperature;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label temperatureLabel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox animalListBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox guestListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ZooScenario;component/window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\window.xaml"
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
            this.window = ((ZooScenario.MainWindow)(target));
            
            #line 8 "..\..\window.xaml"
            this.window.Loaded += new System.Windows.RoutedEventHandler(this.window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.admitGuestButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\window.xaml"
            this.admitGuestButton.Click += new System.Windows.RoutedEventHandler(this.admitGuestButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.feedAnimalButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\window.xaml"
            this.feedAnimalButton.Click += new System.Windows.RoutedEventHandler(this.feedAnimalButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.temperatureBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.increaseTemperature = ((System.Windows.Controls.Primitives.RepeatButton)(target));
            
            #line 13 "..\..\window.xaml"
            this.increaseTemperature.Click += new System.Windows.RoutedEventHandler(this.increaseTemperature_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.decreaseTemperature = ((System.Windows.Controls.Primitives.RepeatButton)(target));
            
            #line 14 "..\..\window.xaml"
            this.decreaseTemperature.Click += new System.Windows.RoutedEventHandler(this.decreaseTemperature_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.temperatureLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.animalListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.guestListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

