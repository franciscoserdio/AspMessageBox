<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MessageBox.ascx.cs" Inherits="FW.UI.MessageBox" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<style type="text/css">
    .modalBackground
    {
        background-color: darkgray;
        filter: alpha(opacity=90);
        opacity: 0.8;
    }
    .modalPopup
    {
        background-color: #FFFFFF;
        border-width: 3px;
        border-style: solid;
        border-color: black;
        padding-top: 10px;
        padding-left: 10px;
    }
</style>

<cc1:ModalPopupExtender ID="mpe_msg_box" runat="server" PopupControlID="pnl_msg_box" BackgroundCssClass="modalBackground" TargetControlID="pnl_msg_box" >
</cc1:ModalPopupExtender>
<asp:Panel id="pnl_msg_box" runat="server" CssClass="modalPopup" align="center" style="border: 1px solid #000;" Width="300px">
    <table>
        <tbody>
            <tr>
                <td colspan="2">
                    <div style="width:100%;height:20px;position:relative;border-bottom:1px groove;padding-top:4px;">
                        <asp:Label ID="lbl_msg_title" runat="server" Width="100%"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr style="height: 3px">
            </tr>
            <tr>
                <td style="width: 5%; padding: 5px;">
                    <asp:Image runat="server" ID="img_msg_icon"/>
                </td>
                <td style="width: 95%; padding: 5px;">
                    <asp:Label runat="server" ID="lbt_msg_text"></asp:Label>
                </td>
            </tr>
            <tr style="height: 3px">
            </tr>
            <tr>
                <td colspan="2">
                    <div style="width:100%;position:relative;border-top:1px groove;padding-top:4px;">
                        <asp:Panel ID="pnl_buttons" runat="server" style="float:right;">
                            <asp:Button ID="btn_Yes" Text="Yes" runat="server" CausesValidation="False" UseSubmitBehavior="False" OnClick="response_Click" />
                            <asp:Button ID="btn_No" Text="No" runat="server" CausesValidation="False" UseSubmitBehavior="False" OnClick="response_Click" />
                            <asp:Button ID="btn_Abort" Text="Abort" runat="server" CausesValidation="False" UseSubmitBehavior="False" OnClick="response_Click" />
                            <asp:Button ID="btn_Retry" Text="Retry" runat="server" CausesValidation="False" UseSubmitBehavior="False" OnClick="response_Click" />
                            <asp:Button ID="btn_Ignore" Text="Ignore" runat="server" CausesValidation="False" UseSubmitBehavior="False" OnClick="response_Click" />
                            <asp:Button ID="btn_Ok" Text="Ok" runat="server" CausesValidation="False" UseSubmitBehavior="False" OnClick="response_Click" />
                            <asp:Button ID="btn_Cancel" Text="Cancel" runat="server" CausesValidation="False" UseSubmitBehavior="False" OnClick="response_Click" />
                        </asp:Panel>                    
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Panel>
