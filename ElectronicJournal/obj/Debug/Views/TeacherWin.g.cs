﻿#pragma checksum "..\..\..\Views\TeacherWin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FCF7C8FFA28FDE9F9FC806FB55848CDF471C0DEDED9FDF4EFE28680CE2D6FCFA"
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
    /// TeacherWin
    /// </summary>
    public partial class TeacherWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Views\TeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label namelb;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\TeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\TeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox classTxtBx;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\TeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button listBt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\TeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button listDiscipline;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\TeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editBt;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\TeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button passBt;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\TeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeworkBt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\TeacherWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
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
            System.Uri resourceLocater = new System.Uri("/ElectronicJournal;component/views/teacherwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\TeacherWin.xaml"
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
            return;
            case 3:
            this.classTxtBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.listBt = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Views\TeacherWin.xaml"
            this.listBt.Click += new System.Windows.RoutedEventHandler(this.listBt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.listDiscipline = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Views\TeacherWin.xaml"
            this.listDiscipline.Click += new System.Windows.RoutedEventHandler(this.listDiscipline_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.editBt = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Views\TeacherWin.xaml"
            this.editBt.Click += new System.Windows.RoutedEventHandler(this.editBt_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.passBt = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Views\TeacherWin.xaml"
            this.passBt.Click += new System.Windows.RoutedEventHandler(this.passBt_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.HomeworkBt = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Views\TeacherWin.xaml"
            this.HomeworkBt.Click += new System.Windows.RoutedEventHandler(this.HomeworkBt_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Views\TeacherWin.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

