﻿#pragma checksum "..\..\..\Views\AddTeacherWin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "01B47B31294B34FB001BBC706703D3240FBF78799323E834198803CEA5C43860"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ElectronicJournal.Views;
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


namespace ElectronicJournal.Views {
    
    
    /// <summary>
    /// AddTeacherWin
    /// </summary>
    public partial class AddTeacherWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\AddTeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label namelb;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\AddTeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\AddTeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surnameTxt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\AddTeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTxt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\AddTeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox middleName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\AddTeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginTxt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\AddTeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passTxt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\AddTeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DiscTxt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\AddTeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBt;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\AddTeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBt;
        
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
            System.Uri resourceLocater = new System.Uri("/ElectronicJournal;component/views/addteacherwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddTeacherWin.xaml"
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
            this.namelb = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\..\Views\AddTeacherWin.xaml"
            this.dataGrid.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.dataGrid_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.surnameTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.nameTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.middleName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.loginTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.passTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.DiscTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.AddBt = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Views\AddTeacherWin.xaml"
            this.AddBt.Click += new System.Windows.RoutedEventHandler(this.AddBt_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EditBt = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Views\AddTeacherWin.xaml"
            this.EditBt.Click += new System.Windows.RoutedEventHandler(this.EditBt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

