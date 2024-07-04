<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Hakkimizda.aspx.cs" Inherits="Hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="inner-header divider parallax layer-overlay overlay-dark-5" data-parallax-ratio="0.7" data-bg-img="/images/nutrition/bg/bg7.jpg">
        <div class="container pt-50 pb-50">
            <div class="section-content pt-100">
                <div class="row">
                    <div class="col-md-12">
                        <h3 class="title text-white">Hakkımızda</h3>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id="about">
        <div class="container pb-20 pt-30 mt-10">
            <div class="section-content">
                <div class="row">
                    <asp:Repeater ID="rptIcerik" runat="server">
                        <ItemTemplate>
                            <div class="col-md-8">
                                <h3 class=" font-28 letter-space-3 mt-0"><span class="text-theme-colored"><%# Eval("baslik") %></span></h3>
                                <h5 class=" font-weight-400"><%# Eval("kisaaciklama") %></h5>

                                <div class="row">
                                    <div class="col-md-12">
                                        <%# Eval("aciklama") %>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="thumb">
                                    <img class="img-fullwidth" src='/images/<%# Eval("resim") %>' alt='<%# Eval("baslik") %>'>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <hr />
                <div class="row mt-40">
                    <div class="col-md-4">
                        <div class="icon-box p-0">
                            <a href="#" class="icon-border-effect effect-circled  icon icon-circled mb-0 mr-0 pull-left flip icon-lg">
                                <i class="flaticon-nutrition-salad-bowl-hand-drawn-food text-theme-colored font-54"></i>
                            </a>
                            <div class="ml-120">
                                <h5 class="icon-box-title mt-15 mb-10">Özel Diyetler</h5>
                                <p class="text-gray">Size özel diyet tavsiyelerimiz için bize ulaşın.</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="icon-box p-0">
                            <a href="#" class="icon-border-effect effect-circled  icon icon-circled mb-0 mr-0 pull-left flip icon-lg">
                                <i class="flaticon-nutrition-vegetables-hand-drawn-basket text-theme-colored font-54"></i>
                            </a>
                            <div class="ml-120">
                                <h5 class="icon-box-title mt-15 mb-10">Antioksidan</h5>
                                <p class="text-gray">Aynı zamanda vücut temizliğimiz de önemli.</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="icon-box p-0">
                            <a href="#" class="icon-border-effect effect-circled  icon icon-circled mb-0 mr-0 pull-left flip icon-lg">
                                <i class="flaticon-nutrition-lettuce-vegetable text-theme-colored font-54"></i>
                            </a>
                            <div class="ml-120">
                                <h5 class="icon-box-title mt-15 mb-10">Sağlıklı Gıdalar</h5>
                                <p class="text-gray">Aynı zamanda kalp damar sağlığımız da önemli.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

