﻿#pragma checksum "..\..\MenuMunicipio.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FFE69CFCF8837611BAD6489E0044FF70D16582A7178A2E266907CAC27B4EBF14"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppMunicipio;
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


namespace AppMunicipio {
    
    
    /// <summary>
    /// MenuMunicipio
    /// </summary>
    public partial class MenuMunicipio : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\MenuMunicipio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ReporteVehicular;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MenuMunicipio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_vehiculos;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MenuMunicipio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_conductores;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MenuMunicipio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_chat;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MenuMunicipio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cerrarSesion;
        
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
            System.Uri resourceLocater = new System.Uri("/AppMunicipio;component/menumunicipio.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuMunicipio.xaml"
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
            this.btn_ReporteVehicular = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\MenuMunicipio.xaml"
            this.btn_ReporteVehicular.Click += new System.Windows.RoutedEventHandler(this.btn_reporteVehicular_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_vehiculos = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\MenuMunicipio.xaml"
            this.btn_vehiculos.Click += new System.Windows.RoutedEventHandler(this.btn_vehiculos_click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_conductores = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\MenuMunicipio.xaml"
            this.btn_conductores.Click += new System.Windows.RoutedEventHandler(this.btn_conductores_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_chat = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\MenuMunicipio.xaml"
            this.btn_chat.Click += new System.Windows.RoutedEventHandler(this.btn_chat_click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_cerrarSesion = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\MenuMunicipio.xaml"
            this.btn_cerrarSesion.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

