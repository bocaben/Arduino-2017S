﻿#pragma checksum "E:\Users\natan\Documents\Visual Studio 2017\Projects\3D Led Pong App\natan_test_07_06\ServerCreateGamePage .xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0DAB199EB6BBE8FA1D6F172FF6BBCC5C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Led_Pong_App
{
    partial class ServerCreateGamePage : 
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
                    this.LayoutRoot = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3:
                {
                    this.NarrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.WideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.ContentGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6:
                {
                    this.TitleGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.ContentPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8:
                {
                    this.addItemPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 9:
                {
                    this.GameCreatedText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.ButtonSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 106 "..\..\..\ServerCreateGamePage .xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonSave).Click += this.ButtonSave_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.ButtonBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 114 "..\..\..\ServerCreateGamePage .xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonBack).Click += this.ButtonBack_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.NickName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.NickNameInput = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 102 "..\..\..\ServerCreateGamePage .xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.NickNameInput).KeyDown += this.TextInput_KeyDown;
                    #line default
                }
                break;
            case 14:
                {
                    this.GameName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.TextInput = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 98 "..\..\..\ServerCreateGamePage .xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.TextInput).KeyDown += this.TextInput_KeyDown;
                    #line default
                }
                break;
            case 16:
                {
                    this.TitleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

