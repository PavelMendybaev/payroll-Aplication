#pragma checksum "..\..\..\windows\AutWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36D72EB362A49596F1E3EC6C5B5768D06C0163A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using payroll_application.windows;


namespace payroll_application.windows {
    
    
    /// <summary>
    /// autWindow
    /// </summary>
    public partial class autWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\windows\AutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid myGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\windows\AutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseImage;
        
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
            System.Uri resourceLocater = new System.Uri("/payroll application;component/windows/autwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\AutWindow.xaml"
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
            this.myGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 9 "..\..\..\windows\AutWindow.xaml"
            this.myGrid.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.dragClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseImage = ((System.Windows.Controls.Image)(target));
            
            #line 16 "..\..\..\windows\AutWindow.xaml"
            this.CloseImage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.exitClick);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\windows\AutWindow.xaml"
            this.CloseImage.MouseLeave += new System.Windows.Input.MouseEventHandler(this.leaveMouseInImage);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\windows\AutWindow.xaml"
            this.CloseImage.MouseEnter += new System.Windows.Input.MouseEventHandler(this.enterMouseInImage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

