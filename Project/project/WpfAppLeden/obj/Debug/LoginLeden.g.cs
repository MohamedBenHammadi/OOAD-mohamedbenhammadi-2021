﻿#pragma checksum "..\..\LoginLeden.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2472039FA428ABF6FD3FA46EE0441956C616785C265184ADFF3515FD4B8CE224"
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
using WpfAppLeden;


namespace WpfAppLeden {
    
    
    /// <summary>
    /// LoginLeden
    /// </summary>
    public partial class LoginLeden : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\LoginLeden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBarcode;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\LoginLeden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblfoutmelding;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\LoginLeden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogIn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\LoginLeden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnZonderLogIN;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppLeden;component/loginleden.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginLeden.xaml"
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
            this.txtBarcode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.lblfoutmelding = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnLogIn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\LoginLeden.xaml"
            this.btnLogIn.Click += new System.Windows.RoutedEventHandler(this.btnLogIn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnZonderLogIN = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\LoginLeden.xaml"
            this.BtnZonderLogIN.Click += new System.Windows.RoutedEventHandler(this.BtnZonderLogIN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

