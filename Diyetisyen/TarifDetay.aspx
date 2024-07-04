<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TarifDetay.aspx.cs" Inherits="TarifDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="lblGelenID" runat="server" Visible="false"></asp:Label>
    <section class="inner-header divider parallax layer-overlay overlay-dark-5" data-parallax-ratio="0.7" data-bg-img="/images/nutrition/bg/bg7.jpg">
        <div class="container pt-50 pb-50">
            <div class="section-content pt-100">
                <div class="row">
                    <div class="col-md-12">
                        <h3 class="title text-white">
                            <asp:Literal ID="ltrBaslik" runat="server"></asp:Literal></h3>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id="about">
        <div class="container pb-20 pt-30 mt-10">
            <div class="section-content">
                <div class="row">
                    <div class="col-md-8">
                        <h3 class=" font-28 letter-space-3 mt-0"><span class="text-theme-colored">
                            <asp:Literal ID="ltrYemekAdi" runat="server"></asp:Literal></span></h3>
                        <h4 class=" font-14 letter-space-3 mt-0">
                            <asp:Literal ID="ltrKalori" runat="server"></asp:Literal></h4>
                        <div class="row">
                            <div class="col-md-12">
                                <asp:Literal ID="ltrAciklama" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="thumb">
                            <asp:Literal ID="ltrResim" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

