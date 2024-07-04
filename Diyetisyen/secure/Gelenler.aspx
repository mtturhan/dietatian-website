<%@ Page Title="" Language="C#" MasterPageFile="~/secure/secure.master" AutoEventWireup="true" CodeFile="Gelenler.aspx.cs" Inherits="secure_Gelenler" %>

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
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td align="center">
                <asp:Label ID="Label3" runat="server" Text="Bu sayfa Gelenl Mesajların incelenmesi içindir."></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataKeyField="ID" DataSourceID="SqlDataSource1" ForeColor="#333333" RepeatColumns="3" Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#E3EAEB" />
                    <ItemTemplate>
                        <table style="border: 2px solid #000000; width:100%;">
                            <tr>
                                <td style="text-align: right">ID:</td>
                                <td>
                                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">IPadresi:</td>
                                <td>
                                    <asp:Label ID="IPadresiLabel" runat="server" Text='<%# Eval("IPadresi") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">adisoyadi:</td>
                                <td>
                                    <asp:Label ID="adisoyadiLabel" runat="server" Text='<%# Eval("adisoyadi") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">telefon:</td>
                                <td>
                                    <asp:Label ID="telefonLabel" runat="server" Text='<%# Eval("telefon") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">mailadresi:</td>
                                <td>
                                    <asp:Label ID="mailadresiLabel" runat="server" Text='<%# Eval("mailadresi") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">mesaj:</td>
                                <td>
                                    <asp:Label ID="mesajLabel" runat="server" Text='<%# Eval("mesaj") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">okundu:</td>
                                <td>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("ID") %>' OnClick="LinkButton2_Click" Text='<%# Eval("okundu") %>'></asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">tarihsaat: </td>
                                <td>
                                    <asp:Label ID="tarihsaatLabel" runat="server" Text='<%# Eval("tarihsaat") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="text-align: right">&nbsp;</td>
                                <td>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("ID") %>' Font-Bold="True" ForeColor="Red" OnClick="LinkButton1_Click">Kayıt Sil</asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        &nbsp;
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TuzlaTasarim %>" SelectCommand="SELECT [ID], [tarihsaat], [IPadresi], [adisoyadi], [telefon], [mailadresi], [mesaj], [okundu] FROM [gelenler] ORDER BY [ID] DESC"></asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

