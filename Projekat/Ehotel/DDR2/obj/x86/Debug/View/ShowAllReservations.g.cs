﻿#pragma checksum "C:\Users\mirsad\Desktop\Tim27-DDR2-master\Projekat\Ehotel\DDR2\View\ShowAllReservations.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CED2C6508C8877EC13E2528BADF43CC5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DDR2.View
{
    partial class ShowAllReservations : 
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
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 16 "..\..\..\View\ShowAllReservations.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.textBlock).SelectionChanged += this.textBlock_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.textBox_Copy = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\View\ShowAllReservations.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.listBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 5:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 26 "..\..\..\View\ShowAllReservations.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.textBlock1).SelectionChanged += this.textBlock1_SelectionChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\View\ShowAllReservations.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.button1_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.button1_Copy = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\View\ShowAllReservations.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1_Copy).Click += this.button1_Copy_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.scrollBar = (global::Windows.UI.Xaml.Controls.Primitives.ScrollBar)(target);
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

