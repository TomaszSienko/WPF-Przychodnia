﻿#pragma checksum "..\..\..\..\Windows\Login.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "735013B48308171467ECAE09160697FEAA497C74"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Przychodnia_App_v1.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Przychodnia_App_v1.Windows {
    
    
    /// <summary>
    /// Logowanie
    /// </summary>
    public partial class Logowanie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Windows\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B_Window_Minimize;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Windows\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B_Window_Close;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Windows\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox B_LoginInput;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Windows\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox B_PasswordInput;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Windows\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B_TryLog;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Przychodnia_App_v1;V1.0.0.0;component/windows/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Login.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\Windows\Login.xaml"
            ((Przychodnia_App_v1.Windows.Logowanie)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.B_Window_Minimize = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Windows\Login.xaml"
            this.B_Window_Minimize.Click += new System.Windows.RoutedEventHandler(this.B_Window_Minimize1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.B_Window_Close = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Windows\Login.xaml"
            this.B_Window_Close.Click += new System.Windows.RoutedEventHandler(this.B_Window_Close1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.B_LoginInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.B_PasswordInput = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.B_TryLog = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Windows\Login.xaml"
            this.B_TryLog.Click += new System.Windows.RoutedEventHandler(this.B_TryLog1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

