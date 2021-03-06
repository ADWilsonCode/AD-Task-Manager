﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F2A97B992CB5A17B6387E7190AF9DD19"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace AW_Task_Manager {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProcessesListView;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ProcessNameColumn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton UnRespondingProcessesRadioBttn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RefreshProcessListRadioBttn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FindProcessLB;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FindProcessTxt;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ProgramOpenCheckBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button KillProcessBttn;
        
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
            System.Uri resourceLocater = new System.Uri("/AW Task Manager;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 4 "..\..\MainWindow.xaml"
            ((AW_Task_Manager.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ProcessesListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.ProcessNameColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 4:
            this.UnRespondingProcessesRadioBttn = ((System.Windows.Controls.RadioButton)(target));
            
            #line 14 "..\..\MainWindow.xaml"
            this.UnRespondingProcessesRadioBttn.Click += new System.Windows.RoutedEventHandler(this.UnRespondingProcessesRadioBttn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RefreshProcessListRadioBttn = ((System.Windows.Controls.RadioButton)(target));
            
            #line 15 "..\..\MainWindow.xaml"
            this.RefreshProcessListRadioBttn.Click += new System.Windows.RoutedEventHandler(this.RefreshProcessListRadioBttn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FindProcessLB = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.FindProcessTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.FindProcessTxt.GotFocus += new System.Windows.RoutedEventHandler(this.FindProcessTxt_GotFocus);
            
            #line default
            #line hidden
            
            #line 19 "..\..\MainWindow.xaml"
            this.FindProcessTxt.LostFocus += new System.Windows.RoutedEventHandler(this.FindProcessTxt_LostFocus);
            
            #line default
            #line hidden
            
            #line 19 "..\..\MainWindow.xaml"
            this.FindProcessTxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FindProcessTxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ProgramOpenCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 22 "..\..\MainWindow.xaml"
            this.ProgramOpenCheckBox.Click += new System.Windows.RoutedEventHandler(this.ProgramOpenCheckBox_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.KillProcessBttn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.KillProcessBttn.Click += new System.Windows.RoutedEventHandler(this.KillProcessBttn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

