﻿#pragma checksum "E:\Users\natan\Documents\Visual Studio 2017\Projects\3D Led Pong App\3D Led Pong\ScoreBoardPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8A29A059E07526ED17B67EA4A39B40E6"
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
    partial class ScoreBoardPage : 
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
                    this.ButtonBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 119 "..\..\..\ScoreBoardPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonBack).Click += this.ButtonBack_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.ButtonSoftReset = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 128 "..\..\..\ScoreBoardPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonSoftReset).Click += this.ButtonSoftReset_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.TitleGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    this.ContentPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10:
                {
                    this.ItemsGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 11:
                {
                    this.ChooseGame = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.ChooseGame_Copy = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.ChooseGame_Copy1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.ListItems = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 103 "..\..\..\ScoreBoardPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ListItems).SelectionChanged += this.ListItems_SelectionChanged;
                    #line default
                }
                break;
            case 15:
                {
                    this.TitleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 69 "..\..\..\ScoreBoardPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.TitleTextBlock).SelectionChanged += this.TitleTextBlock_SelectionChanged;
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

