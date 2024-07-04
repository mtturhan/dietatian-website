<%@ Page Title="" Language="C#" MasterPageFile="~/secure/secure.master" AutoEventWireup="true" CodeFile="AdminTanim.aspx.cs" Inherits="secure_AdminTanim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 16px;
        }
        .auto-style2 {
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
                <asp:Label ID="Label3" runat="server" Text="Bu sayfa yönetim paneli kullanımı için YÖNETİCİ TANIMLAMA işlemi içindir."></asp:Label>
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
                                <asp:Label ID="Label4" runat="server" Text="Kullanıcı Adı :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Width="184px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label6" runat="server" Text="Şifre :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Width="184px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">
                                <asp:Label ID="Label7" runat="server" Text="Mail Adresi :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" Width="184px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="150px">&nbsp;</td>
                            <td>
                                <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
                            </td>
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
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="No" InsertVisible="False" ReadOnly="True" SortExpression="ID">
                        <ItemStyle HorizontalAlign="Center" Width="75px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="kullaniciadi" HeaderText="Kullanıcı Adı" SortExpression="kullaniciadi">
                        <ItemStyle Width="150px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sifre" HeaderText="Şifre" SortExpression="sifre">
                        <ItemStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="mailadresi" HeaderText="Mail Adresi" SortExpression="mailadresi">
                        <ItemStyle Width="150px" />
                        </asp:BoundField>
                        <asp:CommandField CancelText="İptal" DeleteText="Kayıt Sil" EditText="Değiştir" ShowDeleteButton="True" ShowEditButton="True" UpdateText="Kaydet">
                        <ItemStyle HorizontalAlign="Center" Width="150px" />
                        </asp:CommandField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:TuzlaTasarim %>" DeleteCommand="DELETE FROM [admin] WHERE [ID] = @original_ID" InsertCommand="INSERT INTO [admin] ([kullaniciadi], [sifre], [mailadresi]) VALUES (@kullaniciadi, @sifre, @mailadresi)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [ID], [kullaniciadi], [sifre], [mailadresi] FROM [admin] ORDER BY [ID] DESC">
                    <DeleteParameters>
                        <asp:Parameter Name="original_ID" Type="Int64" />
                    </DeleteParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

