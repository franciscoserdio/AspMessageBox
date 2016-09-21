<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <h2>Page Default</h2>
        <p>
        </p>
        <p>
            <asp:UpdatePanel ID="up_buttons" runat="server">
                <ContentTemplate>
                    <table>
                        <tr>
                            <td>
                                Message box with code 'ACTION #1' 
                                <br />
                                <asp:Button runat="server" ID="btn_OK" Text="Info + OK" Width="300px" OnClick="btn_OK_Click" />
                                <br /><br />

                                Message box with code 'ACTION #2' 
                                <br />
                                <asp:Button runat="server" ID="btn_OK_CANCEL" Text="Warning + OK/CANCEL" Width="300px" OnClick="btn_OK_CANCEL_Click" />
                                <br /><br />
                    
                                Message box with code 'ACTION #3' 
                                <br />
                                <asp:Button runat="server" ID="btn_OK_error" Text="Error + OK" Width="300px" OnClick="btn_OK_error_Click" />
                                <br /><br />
                    
                                Message box with code 'ACTION #4' 
                                <br />
                                <asp:Button runat="server" ID="btn_YES_NO" Text="Question + YES/NO" Width="300px" OnClick="btn_YES_NO_Click" />
                                <br /><br />
                    
                                Message box with code 'ACTION #5' 
                                <br />
                                <asp:Button runat="server" ID="btn_YES_NO_CANCEL" Text="Question + YES/NO/CANCEL" Width="300px" OnClick="btn_YES_NO_CANCEL_Click" />
                                <br /><br />
                    
                                Message box with code 'ACTION #6' 
                                <br />
                                <asp:Button runat="server" ID="btn_ABORT_RETRY_IGNORE" Text="Warning + ABORT/RETRY/IGNORE" Width="300px" OnClick="btn_ABORT_RETRY_IGNORE_Click" />
                                <br /><br />

                                Message box with code 'ACTION #7' 
                                <br />
                                <asp:Button runat="server" ID="btn_OK_stop" Text="Stop + OK" Width="300px" OnClick="btn_OK_stop_Click" />
                    
                            </td>
                            <td>
                                RESPONSE IN SERVER
                                <br />
                                <asp:TextBox runat="server" ID="txt_response" Width="500px" />
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </p>
    </div>
</asp:Content>
