﻿#pragma checksum "..\..\WindowLoad.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8B598470DE31F7C2A859D9621DB0E67BFF0370812F03BA12675B38CCC8CF8B44"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// WindowLoad
    /// </summary>
    public partial class WindowLoad : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\WindowLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgressLoad;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\WindowLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\WindowLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exiter;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WindowLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Menu;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\WindowLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem WarningList;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\WindowLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Version;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\WindowLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem About;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WindowLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Language;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\WindowLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem General;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/windowload.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowLoad.xaml"
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
            
            #line 9 "..\..\WindowLoad.xaml"
            ((WpfApp1.WindowLoad)(target)).ContentRendered += new System.EventHandler(this.Window_ContentRendered);
            
            #line default
            #line hidden
            
            #line 9 "..\..\WindowLoad.xaml"
            ((WpfApp1.WindowLoad)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ProgressLoad = ((System.Windows.Controls.ProgressBar)(target));
            
            #line 17 "..\..\WindowLoad.xaml"
            this.ProgressLoad.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ProgressLoad_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button2 = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\WindowLoad.xaml"
            this.Button2.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Exiter = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\WindowLoad.xaml"
            this.Exiter.Click += new System.Windows.RoutedEventHandler(this.Exiter_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Menu = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            this.WarningList = ((System.Windows.Controls.MenuItem)(target));
            
            #line 23 "..\..\WindowLoad.xaml"
            this.WarningList.Click += new System.Windows.RoutedEventHandler(this.WarningList_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Version = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\WindowLoad.xaml"
            this.Version.Click += new System.Windows.RoutedEventHandler(this.Version_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.About = ((System.Windows.Controls.MenuItem)(target));
            
            #line 26 "..\..\WindowLoad.xaml"
            this.About.Click += new System.Windows.RoutedEventHandler(this.About_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Language = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 10:
            this.General = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\WindowLoad.xaml"
            this.General.Click += new System.Windows.RoutedEventHandler(this.General_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

