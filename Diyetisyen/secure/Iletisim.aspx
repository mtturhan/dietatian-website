<%@ Page Title="" Language="C#" MasterPageFile="~/secure/secure.master" AutoEventWireup="true" CodeFile="Iletisim.aspx.cs" Inherits="secure_Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        height: 17px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table cellpadding="0px" cellspacing="0px" style="width:100%;">
        <tr>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td align="center" class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Bu sayfa İletişim İçeriği içindir."></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel1" runat="server">
                    <table cellpadding="0px" cellspacing="0px" style="width:100%;">
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label4" runat="server" Text="Telefon :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label6" runat="server" Text="Mail Adresi :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Width="250px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label7" runat="server" Text="Adres :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" Width="100%" Height="60px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label8" runat="server" Text="Facebook :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" Width="350px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label9" runat="server" Text="Instagram :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" Width="350px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style1" width="150px">
                                <asp:Label ID="Label10" runat="server" Text="LinkedIn :"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TextBox6" runat="server" Width="350px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">&nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">&nbsp;</td>
                            <td>
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

