<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Sss.aspx.cs" Inherits="Sss" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="inner-header divider parallax layer-overlay overlay-dark-5" data-parallax-ratio="0.7" data-bg-img="/images/nutrition/bg/bg7.jpg">
        <div class="container pt-50 pb-50">
            <div class="section-content pt-100">
                <div class="row">
                    <div class="col-md-12">
                        <h3 class="title text-white">Sık Sorulan Sorular</h3>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-md-10 col-md-offset-1">
                    <div id="accordion1" class="panel-group accordion">
                        <asp:Repeater ID="rptIcerik" runat="server">
                            <ItemTemplate>
                                <div class="panel">
                                    <%# string.Format("{0}", Eval("sira")=="1"?"<div class='panel-title'><a data-parent='#accordion"+Eval("sira")+"' data-toggle='collapse' href='#accordion1"+Eval("sira")+"' class='active' aria-expanded='true'><span class='open-sub'></span><strong>"+ Eval("baslik") +"</strong></a> </div><div id='accordion1"+ Eval("sira") +"' class='panel-collapse collapse in' role='tablist' aria-expanded='true'><div class='panel-content'><p>"+ Eval("aciklama") +"</p></div></div>":"<div class='panel-title'><a data-parent='#accordion"+Eval("sira")+"' data-toggle='collapse' href='#accordion1"+Eval("sira")+"' aria-expanded='false'><span class='open-sub'></span><strong>"+ Eval("baslik") +"</strong></a> </div><div id='accordion1"+ Eval("sira") +"' class='panel-collapse collapse' role='tablist' aria-expanded='true'><div class='panel-content'><p>"+ Eval("aciklama") +"</p></div></div>" )%>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

