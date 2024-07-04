<%@ Page Title="" Language="C#" MasterPageFile="~/secure/secure.master" AutoEventWireup="true" CodeFile="SiteSabitleri.aspx.cs" Inherits="secure_SiteSabitleri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 17px;
        }
        .auto-style2 {
            height: 16px;
        }
        .auto-style3 {
            height: 15px;
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
                <asp:Label ID="Label3" runat="server" Text="Bu sayfa Site Sabitleri içeriği belirlemek içindir."></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel1" runat="server">
                    <table cellpadding="0px" cellspacing="0px" style="width:100%;">
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label4" runat="server" Text="Site Başlık :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label11" runat="server" Text="Site Üst Yazı :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" Width="100%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label6" runat="server" Text="Site Logo :"></asp:Label>
                            </td>
                            <td>
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                <asp:TextBox ID="TextBox2" runat="server" Width="250px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label9" runat="server" Text="Google Anahtar :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" Width="100%" Height="30px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style1" width="150px">
                                <asp:Label ID="Label10" runat="server" Text="Google Açıklama :"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TextBox4" runat="server" Width="100%" Height="30px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px" class="auto-style1">&nbsp;</td>
                            <td class="auto-style1"></td>
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

