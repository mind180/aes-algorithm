﻿#pragma checksum "..\..\WindowOpen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A69A7D1B5EA035ADDC361E0568C30C03E5E9E90"
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


namespace AES {
    
    
    /// <summary>
    /// WindowOpen
    /// </summary>
    public partial class WindowOpen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPath;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextField;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KeyField;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox KeySizeField;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Encrypt;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpen;
        
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
            System.Uri resourceLocater = new System.Uri("/AES;component/windowopen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowOpen.xaml"
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
            this.TextBoxPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.KeyField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.KeySizeField = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Encrypt = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\WindowOpen.xaml"
            this.Encrypt.Click += new System.Windows.RoutedEventHandler(this.Encrypt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonOpen = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\WindowOpen.xaml"
            this.ButtonOpen.Click += new System.Windows.RoutedEventHandler(this.ButtonOpen_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
