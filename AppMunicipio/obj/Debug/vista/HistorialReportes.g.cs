#pragma checksum "..\..\..\vista\HistorialReportes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3F1D3BA392B3B7D915D7F0F96228964805ECC9F0077CB359DE652B516E9317CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppMunicipio.vista;
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


namespace AppMunicipio.vista {
    
    
    /// <summary>
    /// HistorialReportes
    /// </summary>
    public partial class HistorialReportes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\vista\HistorialReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\vista\HistorialReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbEstatus;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\vista\HistorialReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpFecha;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\vista\HistorialReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDelegacion;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\vista\HistorialReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFiltrar;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\vista\HistorialReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMostrarTodo;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\vista\HistorialReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLevantarReporte;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\vista\HistorialReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvReportes;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\vista\HistorialReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVerDetalles;
        
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
            System.Uri resourceLocater = new System.Uri("/AppMunicipio;component/vista/historialreportes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\vista\HistorialReportes.xaml"
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
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\vista\HistorialReportes.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbEstatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.dpFecha = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.cbDelegacion = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnFiltrar = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\vista\HistorialReportes.xaml"
            this.btnFiltrar.Click += new System.Windows.RoutedEventHandler(this.btnFiltrar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnMostrarTodo = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\vista\HistorialReportes.xaml"
            this.btnMostrarTodo.Click += new System.Windows.RoutedEventHandler(this.btnMostrarTodo_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnLevantarReporte = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\vista\HistorialReportes.xaml"
            this.btnLevantarReporte.Click += new System.Windows.RoutedEventHandler(this.btnLevantarReporte_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lvReportes = ((System.Windows.Controls.ListView)(target));
            
            #line 87 "..\..\..\vista\HistorialReportes.xaml"
            this.lvReportes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnVerDetalles = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\vista\HistorialReportes.xaml"
            this.btnVerDetalles.Click += new System.Windows.RoutedEventHandler(this.btnVerDetalles_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

