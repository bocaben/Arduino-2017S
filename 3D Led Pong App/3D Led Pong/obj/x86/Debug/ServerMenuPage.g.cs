﻿#pragma checksum "E:\Users\natan\Documents\Visual Studio 2017\Projects\natan_test_27_06\natan_test_07_06\ServerMenuPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4E0832F34E91FDD659BD6B3C6B6E7DF7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace natan_test_07_06
{
    partial class ServerMenuPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.ButtonCreate = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\ServerMenuPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonCreate).Click += this.ButtonCreate_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.ButtonJoin = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\ServerMenuPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonJoin).Click += this.ButtonJoin_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

