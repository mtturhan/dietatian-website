<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Iletisim.aspx.cs" Inherits="Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="inner-header divider parallax layer-overlay overlay-dark-5" data-parallax-ratio="0.7" data-bg-img="/images/nutrition/bg/bg7.jpg">
        <div class="container pt-50 pb-50">
            <div class="section-content pt-100">
                <div class="row">
                    <div class="col-md-12">
                        <h3 class="title text-white">İletişim</h3>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <asp:Repeater ID="rptIletisim" runat="server">
        <ItemTemplate>
            <section class="divider">
                <div class="container pt-60 pb-60">
                    <div class="section-title mb-60">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="esc-heading small-border text-center">
                                    <h3>Bize Ulaşınız</h3>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="section-content">
                        <div class="row">
                            <div class="col-sm-12 col-md-4">
                                <div class="contact-info text-center">
                                    <i class="fa fa-phone font-36 mb-10 text-theme-colored"></i>
                                    <h4>Telefon</h4>
                                    <h6 class="text-gray"><a href='tel:<%# Eval("telefon").ToString().Replace(" ","") %>'><%# Eval("telefon") %></a></h6>
                                </div>
                            </div>
                            <div class="col-sm-12 col-md-4">
                                <div class="contact-info text-center">
                                    <i class="fa fa-map-marker font-36 mb-10 text-theme-colored"></i>
                                    <h4>Adres</h4>
                                    <h6 class="text-gray"><%# Eval("adres") %></h6>
                                </div>
                            </div>
                            <div class="col-sm-12 col-md-4">
                                <div class="contact-info text-center">
                                    <i class="fa fa-envelope font-36 mb-10 text-theme-colored"></i>
                                    <h4>Email</h4>
                                    <h6 class="text-gray"><a href='mailto:<%# Eval("mailadresi") %>'><%# Eval("mailadresi") %></a></h6>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

