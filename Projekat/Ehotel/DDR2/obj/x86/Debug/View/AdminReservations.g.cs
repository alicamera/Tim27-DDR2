﻿#pragma checksum "C:\Users\user\Desktop\DDR2\DDR2\DDR2\View\AdminReservations.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "58E71C7F2A114CDB4220E58455623D1D"
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
    partial class AdminReservations : 
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
                    global::Windows.UI.Xaml.Controls.Button element1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\View\AdminReservations.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element1).Click += this.Button_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnEditRez = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "..\..\..\View\AdminReservations.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnEditRez).Click += this.btnEditRez_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnCancelRez = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\View\AdminReservations.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancelRez).Click += this.btnCancelRez_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnGoBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\View\AdminReservations.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnGoBack).Click += this.btnGoBack_Click_1;
                    #line default
                }
                break;
            case 5:
                {
                    this.ReservationsListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
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
