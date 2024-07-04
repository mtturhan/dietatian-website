<%@ Page Title="" Language="C#" MasterPageFile="~/secure/secure.master" AutoEventWireup="true" CodeFile="Hizmetlerimiz.aspx.cs" Inherits="secure_Hizmetlerimiz" %>

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
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td align="center" class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Bu sayfa Hizmetlerimiz İçeriği içindir."></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Yeni Kayıt Aç</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <table cellpadding="0px" cellspacing="0px" style="width:100%;">
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label2" runat="server" Text="Başlık :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Width="185px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label3" runat="server" Text="Resim :"></asp:Label>
                            </td>
                            <td>
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                <asp:TextBox ID="TextBox2" runat="server" Width="150px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label4" runat="server" Text="Kısa Açıklama :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" Width="100%" TextMode="MultiLine" Height="30px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label5" runat="server" Text="Sıralama :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" Width="100px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label6" runat="server" Text="Aktif :"></asp:Label>
                            </td>
                            <td>
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatColumns="2" Width="175px">
                                    <asp:ListItem Selected="True">Evet</asp:ListItem>
                                    <asp:ListItem>Hayır</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label7" runat="server" Text="Google Anahtar :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" Width="100%" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label8" runat="server" Text="Google Açıklama :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox6" runat="server" Width="100%" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style1" width="150px"></td>
                            <td class="auto-style1"></td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label9" runat="server"></asp:Label>
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
            <td>
                <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataKeyField="ID" DataSourceID="SqlDataSource1" ForeColor="#333333" RepeatColumns="2" Width="100%">
                            <AlternatingItemStyle BackColor="White" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <ItemStyle BackColor="#E3EAEB" />
                            <ItemTemplate>
                                <table style="width:100%;">
                                    <tr>
                                        <td class="auto-style1" style="text-align: right">ID:</td>
                                        <td class="auto-style1">
                                            <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right">baslik:</td>
                                        <td>
                                            <asp:Label ID="baslikLabel" runat="server" Text='<%# Eval("baslik") %>' />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right">resim:</td>
                                        <td>
                                            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl='<%# Eval("resim", "~/images/{0}") %>' Width="250px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right">kisaaciklama:</td>
                                        <td>
                                            <asp:Label ID="kisaaciklamaLabel" runat="server" Text='<%# Eval("kisaaciklama") %>' />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right">aktif:</td>
                                        <td>
                                            <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("ID") %>' OnClick="LinkButton2_Click1" Text='<%# Eval("aktif") %>'></asp:LinkButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right">siralama:</td>
                                        <td>
                                            <asp:Label ID="siralamaLabel" runat="server" Text='<%# Eval("siralama") %>' />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right">googleanahtar:</td>
                                        <td>
                                            <asp:Label ID="googleanahtarLabel" runat="server" Text='<%# Eval("googleanahtar") %>' />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right">googleaciklama:</td>
                                        <td>
                                            <asp:Label ID="googleaciklamaLabel" runat="server" Text='<%# Eval("googleaciklama") %>' />
                                        </td>
                                    </tr>
                                </table>
                                <br />
                                <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument='<%# Eval("ID") %>' Font-Bold="True" ForeColor="Green" OnClick="LinkButton3_Click">Değiştir</asp:LinkButton>
                                <br />
                                <br />
                                <asp:LinkButton ID="LinkButton4" runat="server" CommandArgument='<%# Eval("ID") %>' Font-Bold="True" ForeColor="Red" OnClick="LinkButton4_Click">Kayıt Sil</asp:LinkButton>
                                <br />
                                <br />
                            </ItemTemplate>
                            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        </asp:DataList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TuzlaTasarim %>" SelectCommand="SELECT [ID], [baslik], [resim], [kisaaciklama], [aktif], [siralama], [googleanahtar], [googleaciklama] FROM [hizmetlerimiz] ORDER BY [ID] DESC"></asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

