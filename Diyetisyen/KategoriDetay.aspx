<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="KategoriDetay.aspx.cs" Inherits="KategoriDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblGelenID" runat="server" Visible="false"></asp:Label>
    <section class="inner-header divider parallax layer-overlay overlay-dark-5" data-parallax-ratio="0.7" data-bg-img="/images/nutrition/bg/bg7.jpg">
        <div class="container pt-50 pb-50">
            <div class="section-content pt-100">
                <div class="row">
                    <div class="col-md-12">
                        <h3 class="title text-white"><asp:Literal ID="ltrBaslik" runat="server"></asp:Literal></h3>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id="gallery">
        <div class="container-fluid pb-0" style="padding-top: 0px;">
            <div class="section-content">
                <div class="row">
                    <div class="col-md-12">
                        <blockquote><asp:Literal ID="ltrAciklama" runat="server"></asp:Literal></blockquote>
                    </div>
                    <div class="col-md-12">
                        <div id="grid" class="gallery-isotope grid-4 clearfix">
                            <asp:Literal ID="ltrTarifler" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

