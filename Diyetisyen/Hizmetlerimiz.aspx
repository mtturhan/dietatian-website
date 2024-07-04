<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Hizmetlerimiz.aspx.cs" Inherits="Hizmetlerimiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="inner-header divider parallax layer-overlay overlay-dark-5" data-parallax-ratio="0.7" data-bg-img="/images/nutrition/bg/bg7.jpg">
        <div class="container pt-50 pb-50">
            <div class="section-content pt-100">
                <div class="row">
                    <div class="col-md-12">
                        <h3 class="title text-white">Hizmetlerimiz</h3>
                    </div>
                </div>
            </div>
        </div>
    </section>    
    <section id="classes">
        <div class="container">
            <div class="section-title text-center">
                <div class="row">
                    <div class="col-md-8 col-md-offset-2">
                        <h2 class="title text-uppercase">HİZMETLERİMİZ</h2>
                        <p class="letter-space-4">Sizlere Yardım Etmek İçin Buradayız...</p>
                    </div>
                </div>
            </div>
            <div class="row mtli-row-clearfix">
                <div class="col-md-12">
                    <div class="">
                        <asp:Repeater ID="rptHizmetler" runat="server">
                            <ItemTemplate>
                                <div class="col-md-4">
                                    <div class="class-item box-hover-effect effect1 mb-md-30 bg-lighter">
                                        <div class="thumb mb-20">
                                            <img alt='<%# Eval("baslik") %>' src='/images/<%# Eval("resim") %>' class="img-responsive img-fullwidth" style="height: 250px !important;">
                                        </div>
                                        <div class="content text-left p-25 pt-0 flip">
                                            <h4 class="font-weight-400 line-bottom"><%# Eval("baslik") %></h4>
                                            <p><%# Eval("kisaaciklama") %></p>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

