<%@ Page Title="" Language="C#" MasterPageFile="~/secure/secure.master" AutoEventWireup="true" CodeFile="Anasayfa.aspx.cs" Inherits="secure_Anasayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div>
        <span><strong>Bu sayfada yönetim panelinde yapılan işlemler listelenmektedir.</strong></span>
        <br />
    </div>
    <br />
    <div align="center">

        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="13pt" ForeColor="Red" Text="Lütfen Sayfaların Açıklamalarını Okumadan İşlem Yapmayınız !!!"></asp:Label>

    </div>
</asp:Content>

