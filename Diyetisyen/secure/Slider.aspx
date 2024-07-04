<%@ Page Title="" Language="C#" MasterPageFile="~/secure/secure.master" AutoEventWireup="true" CodeFile="Slider.aspx.cs" Inherits="secure_Slider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 31px;
        }

        .auto-style2 {
            height: 17px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table cellpadding="0px" cellspacing="0px" style="width: 100%;">
        <tr>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td align="center" class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Bu sayfa Slider Resim Tanımlamaları içindir."></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Yeni Kayıt Aç</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <table cellpadding="0px" cellspacing="0px" style="width: 100%;">
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label4" runat="server" Text="Yazı Yazınız :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtYazi" runat="server" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px" class="auto-style1">
                                <asp:Label ID="Label6" runat="server" Text="Resim Seçiniz :"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                <asp:TextBox ID="txtResim" runat="server" Visible="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label7" runat="server" Text="Sıralama :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSiralama" runat="server" Width="50px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label8" runat="server" Text="Aktif :"></asp:Label>
                            </td>
                            <td>
                                <asp:RadioButtonList ID="rbAktif" runat="server" Height="30px" RepeatColumns="2" Width="180px">
                                    <asp:ListItem>Evet</asp:ListItem>
                                    <asp:ListItem>Hayır</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="lblDegistirID" runat="server" Visible="false"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" />
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Kaydet" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:DataList ID="DataList1" runat="server" DataKeyField="ID" DataSourceID="SqlDataSource1" RepeatColumns="2" Width="100%">
                    <ItemTemplate>
                        No:
                                        <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                        <br />
                        Resim:
                                        <br />
                        <asp:Image ID="Image1" runat="server" Height="185px" ImageUrl='<%# Eval("resim", "~/images/{0}") %>' Width="285px" />
                        <br />
                        Yazı:
                                        <asp:Label ID="resimLabel" runat="server" Text='<%# Eval("yazi") %>' />
                        <br />
                        Sıralama:
                                        <asp:Label ID="siralamaLabel" runat="server" Text='<%# Eval("siralama") %>' />
                        <br />
                        Aktif:
                                        <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("ID") %>' OnClick="LinkButton2_Click" Text='<%# Eval("aktif") %>'></asp:LinkButton>
                        <br />
                        <br />
                        <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument='<%# Eval("ID") %>' Font-Bold="True" ForeColor="Green" OnClick="LinkButton3_Click">Değiştir</asp:LinkButton>
                        <br />
                        <br />
                        <asp:LinkButton ID="LinkButton4" runat="server" CommandArgument='<%# Eval("ID") %>' Font-Bold="True" ForeColor="Red" OnClick="LinkButton4_Click">Kayıt Sil</asp:LinkButton>
                        <br />
                    </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TuzlaTasarim %>" SelectCommand="SELECT [ID], [resim], [yazi], [siralama], [aktif] FROM [slider] ORDER BY [ID] DESC"></asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

