// Updated by XamlIntelliSenseFileGenerator 30.06.2023 20:22:56
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3043B72A79E4FAEA3DEB9F4113B5633F808403DC"
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
using hws_30._06;


namespace hws_30._06
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/hws 30.06;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 8 "..\..\..\MainWindow.xaml"
                    ((hws_30._06.MainWindow)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);

#line default
#line hidden

#line 8 "..\..\..\MainWindow.xaml"
                    ((hws_30._06.MainWindow)(target)).KeyUp += new System.Windows.Input.KeyEventHandler(this.Window_KeyUp);

#line default
#line hidden
                    return;
                case 2:
                    this.amountSybmPerSec = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 3:
                    this.amountFail = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 4:
                    this.amountSybms = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 5:

#line 27 "..\..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Slider)(target)).ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);

#line default
#line hidden
                    return;
                case 6:

#line 28 "..\..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonStart_Click);

#line default
#line hidden
                    return;
                case 7:

#line 32 "..\..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.panelBtn = ((System.Windows.Controls.WrapPanel)(target));
                    return;
                case 9:
                    this.allBtn = ((System.Windows.Controls.Grid)(target));
                    return;
                case 10:
                    this.leftShift = ((System.Windows.Controls.Button)(target));
                    return;
                case 11:
                    this.rightShift = ((System.Windows.Controls.Button)(target));
                    return;
                case 12:
                    this.leftCtrl = ((System.Windows.Controls.Button)(target));
                    return;
                case 13:
                    this.leftAlt = ((System.Windows.Controls.Button)(target));
                    return;
                case 14:
                    this.rightAlt = ((System.Windows.Controls.Button)(target));
                    return;
                case 15:
                    this.rightCtrl = ((System.Windows.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox textX;
        internal System.Windows.Controls.TextBox textY;
        internal System.Windows.Controls.Canvas canvas;
        internal System.Windows.Shapes.Rectangle rec;
        internal System.Windows.Media.TranslateTransform trans;
    }
}

