﻿#pragma checksum "..\..\RegistrarVehiculo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "903A92495B75A89683BFB59E7B894BC30870CC2CA79E11D056A9F3F63D5A2EE2"
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
    /// RegistrarVehiculo
    /// </summary>
    public partial class RegistrarVehiculo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancelar;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_marca;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_modelo;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_color;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_año;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_numeroPlacas;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_aseguradora;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_numPolizaSeguro;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\RegistrarVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_registrar;
        
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
            System.Uri resourceLocater = new System.Uri("/AppMunicipio;component/registrarvehiculo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegistrarVehiculo.xaml"
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
            this.btn_cancelar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\RegistrarVehiculo.xaml"
            this.btn_cancelar.Click += new System.Windows.RoutedEventHandler(this.cancelar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_marca = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_modelo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_color = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_año = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tb_numeroPlacas = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tb_aseguradora = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tb_numPolizaSeguro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btn_registrar = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
