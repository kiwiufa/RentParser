﻿#pragma checksum "..\..\..\Views\ParticipantDetailsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DDA1734BE3CE35600ABA0A49F8999BE157AA5FA75E3ED96E4B45112318DE0EC5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RentParser.ViewModel;
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


namespace RentParser.ViewModel {
    
    
    /// <summary>
    /// ParticipantDetailsView
    /// </summary>
    public partial class ParticipantDetailsView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\ParticipantDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name_textbox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\ParticipantDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView accounts_view;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\ParticipantDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox key_textbox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\ParticipantDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label name_label_Copy1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\ParticipantDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox comment_textbox;
        
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
            System.Uri resourceLocater = new System.Uri("/RentParser;component/views/participantdetailsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ParticipantDetailsView.xaml"
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
            this.name_textbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\Views\ParticipantDetailsView.xaml"
            this.name_textbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Name_textbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.accounts_view = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.key_textbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\Views\ParticipantDetailsView.xaml"
            this.key_textbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.key_textbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.name_label_Copy1 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.comment_textbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\Views\ParticipantDetailsView.xaml"
            this.comment_textbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Comment_textbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 23 "..\..\..\Views\ParticipantDetailsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 24 "..\..\..\Views\ParticipantDetailsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

