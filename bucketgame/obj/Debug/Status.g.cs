﻿#pragma checksum "..\..\Status.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F100ADED76AA84F769AFC7920AAC0E58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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


namespace BucketGame {
    
    
    /// <summary>
    /// Status
    /// </summary>
    public partial class Status : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelTime;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelScore;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelNothing;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelJoint;
        
        #line default
        #line hidden
        
        /// <summary>
        /// checkboxShowOnlyWantedTarget Name Field
        /// </summary>
        
        #line 10 "..\..\Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.CheckBox checkboxShowOnlyWantedTarget;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTouchingDistance;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderTouchingDistance;
        
        #line default
        #line hidden
        
        /// <summary>
        /// checkboxNearMode Name Field
        /// </summary>
        
        #line 13 "..\..\Status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.CheckBox checkboxNearMode;
        
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
            System.Uri resourceLocater = new System.Uri("/BucketGame;component/status.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Status.xaml"
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
            this.LabelTime = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.LabelScore = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.LabelNothing = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.LabelJoint = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.checkboxShowOnlyWantedTarget = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.labelTouchingDistance = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.sliderTouchingDistance = ((System.Windows.Controls.Slider)(target));
            
            #line 12 "..\..\Status.xaml"
            this.sliderTouchingDistance.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sliderTouchingDistance_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.checkboxNearMode = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

