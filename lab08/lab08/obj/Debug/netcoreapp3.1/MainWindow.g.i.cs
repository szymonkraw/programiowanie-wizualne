﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54D6186DC451B79BC7EBF254C8A31E1360F3DCB0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

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
using lab08;


namespace lab08 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lotnisko_lista;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn Tytul;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox kod_icao;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox kod_iata;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox l_pasaz;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox woj;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox miast;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button szukaj;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/lab08;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lotnisko_lista = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.Tytul = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 3:
            this.kod_icao = ((System.Windows.Controls.CheckBox)(target));
            
            #line 18 "..\..\..\MainWindow.xaml"
            this.kod_icao.Checked += new System.Windows.RoutedEventHandler(this.kod_icao_Checked);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\MainWindow.xaml"
            this.kod_icao.Unchecked += new System.Windows.RoutedEventHandler(this.kod_icao_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.kod_iata = ((System.Windows.Controls.CheckBox)(target));
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.kod_iata.Checked += new System.Windows.RoutedEventHandler(this.kod_iata_Checked);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.kod_iata.Unchecked += new System.Windows.RoutedEventHandler(this.kod_iata_Unchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.l_pasaz = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\..\MainWindow.xaml"
            this.l_pasaz.Checked += new System.Windows.RoutedEventHandler(this.l_pasaz_Checked);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\MainWindow.xaml"
            this.l_pasaz.Unchecked += new System.Windows.RoutedEventHandler(this.l_pasaz_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.woj = ((System.Windows.Controls.CheckBox)(target));
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.woj.Checked += new System.Windows.RoutedEventHandler(this.woj_Checked);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.woj.Unchecked += new System.Windows.RoutedEventHandler(this.woj_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.miast = ((System.Windows.Controls.CheckBox)(target));
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.miast.Checked += new System.Windows.RoutedEventHandler(this.miast_Checked);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.miast.Unchecked += new System.Windows.RoutedEventHandler(this.miast_Unchecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.szukaj = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\MainWindow.xaml"
            this.szukaj.Click += new System.Windows.RoutedEventHandler(this.szukaj_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
