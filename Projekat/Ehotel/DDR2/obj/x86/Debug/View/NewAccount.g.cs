﻿#pragma checksum "C:\Users\user\Desktop\DDR2\DDR2\DDR2\View\NewAccount.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "832B3272875207F2EF292F04E3524ABC"
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
    partial class NewAccount : 
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
                    this.txtFname = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.txtLname = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.txtAddress = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.txtUsername = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.txtPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 6:
                {
                    this.txtCpassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 7:
                {
                    this.txtEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.btnNewAcc = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\View\NewAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnNewAcc).Click += this.btnNewAcc_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.btnCancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\View\NewAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancel).Click += this.btnCancel_Click;
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
