﻿#pragma checksum "..\..\Signin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0044D45C13F998CA25B53E80F2B61F8CEEE77221BE1D27754049FB8F81ABE953"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Stationery;
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


namespace Stationery {
    
    
    /// <summary>
    /// Signin
    /// </summary>
    public partial class Signin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_back;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbox_name;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbox_surname;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbox_phone;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbox_email;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbox_login;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbox_pass;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbox_pass_check;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Signin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_signin;
        
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
            System.Uri resourceLocater = new System.Uri("/Stationery;component/signin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Signin.xaml"
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
            this.btn_back = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Signin.xaml"
            this.btn_back.Click += new System.Windows.RoutedEventHandler(this.btn_back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbox_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbox_surname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbox_phone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbox_email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbox_login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbox_pass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.tbox_pass_check = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.btn_signin = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Signin.xaml"
            this.btn_signin.Click += new System.Windows.RoutedEventHandler(this.btn_signin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

