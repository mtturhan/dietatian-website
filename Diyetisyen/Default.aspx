<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="home" class="divider">
        <div class="container-fluid p-0">
            <div class="rev_slider_wrapper">
                <div class="rev_slider" data-version="5.0">
                    <ul>
                        <asp:Repeater ID="rptSlider" runat="server">
                            <ItemTemplate>
                                <li data-index='rs-<%# Eval("ID") %>' data-transition="slidingoverlayhorizontal" data-slotamount="default" data-easein="default" data-easeout="default" data-masterspeed="default" data-thumb='/images/<%# Eval("resim") %>' data-rotate="0" data-saveperformance="off" data-title='<%# Eval("yazi") %>' data-description="">
                                    <img src='/images/<%# Eval("resim") %>' alt='<%# Eval("yazi") %>' data-bgposition="center center" data-bgfit="cover" data-bgrepeat="no-repeat" class="rev-slidebg" data-bgparallax="6" data-no-retina>
                                    <div class="tp-caption tp-resizeme font-raleway text-center text-black-333"
                                        id="rs-3-layer-1"
                                        data-x="['center']"
                                        data-hoffset="['0']"
                                        data-y="['middle']"
                                        data-voffset="['-80']"
                                        data-fontsize="['60','60','54','24']"
                                        data-lineheight="['95']"
                                        data-width="none"
                                        data-height="none"
                                        data-whitespace="nowrap"
                                        data-transform_idle="o:1;s:500"
                                        data-transform_in="y:100;scaleX:1;scaleY:1;opacity:0;"
                                        data-transform_out="x:left(R);s:1000;e:Power3.easeIn;s:1000;e:Power3.easeIn;"
                                        data-mask_in="x:0px;y:0px;s:inherit;e:inherit;"
                                        data-mask_out="x:inherit;y:inherit;s:inherit;e:inherit;"
                                        data-start="1000"
                                        data-splitin="none"
                                        data-splitout="none"
                                        data-responsive_offset="on"
                                        style="z-index: 5; white-space: nowrap; font-weight: 700;">
                                        <span class="text-theme-colored"><%# Eval("yazi") %></span>
                                    </div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
            <script>
                $(document).ready(function (e) {
                    var revapi = $(".rev_slider").revolution({
                        sliderType: "standard",
                        jsFileLocation: "js/revolution-slider/js/",
                        sliderLayout: "auto",
                        dottedOverlay: "none",
                        delay: 5000,
                        navigation: {
                            keyboardNavigation: "off",
                            keyboard_direction: "horizontal",
                            mouseScrollNavigation: "off",
                            onHoverStop: "off",
                            touch: {
                                touchenabled: "on",
                                swipe_threshold: 75,
                                swipe_min_touches: 1,
                                swipe_direction: "horizontal",
                                drag_block_vertical: false
                            },
                            arrows: {
                                style: "gyges",
                                enable: true,
                                hide_onmobile: false,
                                hide_onleave: true,
                                hide_delay: 200,
                                hide_delay_mobile: 1200,
                                tmp: '',
                                left: {
                                    h_align: "left",
                                    v_align: "center",
                                    h_offset: 0,
                                    v_offset: 0
                                },
                                right: {
                                    h_align: "right",
                                    v_align: "center",
                                    h_offset: 0,
                                    v_offset: 0
                                }
                            },
                            bullets: {
                                enable: true,
                                hide_onmobile: true,
                                hide_under: 800,
                                style: "hebe",
                                hide_onleave: false,
                                direction: "horizontal",
                                h_align: "center",
                                v_align: "bottom",
                                h_offset: 0,
                                v_offset: 30,
                                space: 5,
                                tmp: '<span class="tp-bullet-image"></span><span class="tp-bullet-imageoverlay"></span><span class="tp-bullet-title"></span>'
                            }
                        },
                        responsiveLevels: [1240, 1024, 778],
                        visibilityLevels: [1240, 1024, 778],
                        gridwidth: [1170, 1024, 778, 480],
                        gridheight: [720, 768, 960, 720],
                        lazyType: "none",
                        parallax: "mouse",
                        parallaxBgFreeze: "off",
                        parallaxLevels: [2, 3, 4, 5, 6, 7, 8, 9, 10, 1],
                        shadow: 0,
                        spinner: "off",
                        stopLoop: "on",
                        stopAfterLoops: 0,
                        stopAtSlide: -1,
                        shuffle: "off",
                        autoHeight: "off",
                        fullScreenAutoWidth: "off",
                        fullScreenAlignForce: "off",
                        fullScreenOffsetContainer: "",
                        fullScreenOffset: "0",
                        hideThumbsOnMobile: "off",
                        hideSliderAtLimit: 0,
                        hideCaptionAtLimit: 0,
                        hideAllCaptionAtLilmit: 0,
                        debugMode: false,
                        fallbacks: {
                            simplifyAll: "off",
                            nextSlideOnWindowFocus: "off",
                            disableFocusListener: false,
                        }
                    });
                });
            </script>
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
                    <div class="owl-carousel-3col" data-dots="true">
                        <asp:Repeater ID="rptHizmetler" runat="server">
                            <ItemTemplate>
                                <div class="item">
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
    <section class="divider parallax layer-overlay overlay-dark-6" data-bg-img="images/nutrition/bg/bg4.jpg" data-parallax-ratio="0.7">
        <div class="container">
            <div class="row mb-50">
                <div class="col-md-6 text-center col-md-offset-3">
                    <h5 class="text-white">En Uygun Çözümlerimizle</h5>
                    <h2 class="text-white">Kişisel danışmanınız olmak istiyoruz. Rakamlarla Biz Diyelim; </h2>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12 col-sm-6 col-md-3 mb-md-50">
                    <div class="funfact text-center">
                        <a href="#"><i class="pe-7s-date text-gray-lighter font-46"></i></a>
                        <h5 class="animate-number text-theme-colored font-36 font-weight-400 font-opensans mt-20 mb-20" data-value="15" data-animation-duration="2500">0</h5>
                        <h6 class="title text-white font-16">Yıllık Tecrübe</h6>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6 col-md-3 mb-md-50">
                    <div class="funfact text-center">
                        <a href="#"><i class="pe-7s-smile text-gray-lighter font-46"></i></a>
                        <h5 class="animate-number text-theme-colored font-36 font-weight-400 font-opensans mt-20 mb-20" data-value="147" data-animation-duration="2500">0</h5>
                        <h6 class="title text-white font-16">Mutlu Müşteri</h6>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6 col-md-3 mb-md-50">
                    <div class="funfact text-center">
                        <a href="#"><i class="pe-7s-medal text-gray-lighter font-46"></i></a>
                        <h5 class="animate-number text-theme-colored font-36 font-weight-400 font-opensans mt-20 mb-20" data-value="3" data-animation-duration="2500">0</h5>
                        <h6 class="title text-white font-16">Ödül Sayımız</h6>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6 col-md-3 mb-md-50">
                    <div class="funfact text-center">
                        <a href="#"><i class="pe-7s-like2 text-gray-lighter font-46"></i></a>
                        <h5 class="animate-number text-theme-colored font-36 font-weight-400 font-opensans mt-20 mb-20" data-value="26892" data-animation-duration="2500">0</h5>
                        <h6 class="title text-white font-16">Sosyal Medya Takipçilerimiz</h6>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section data-bg-img="images/pattern/p8.png">
        <div class="container pb-0">
            <div class="section-content">
                <div class="row">
                    <div class="col-md-6 pb-sm-70">
                        <h3 class="mt-0"><span class="text-theme-colored">Vücut Kitle İndeksi</span> Hesaplama</h3>
                        <p>Kişinin boyuna ve kilosuna göre sağlıklı vücut ağırlığında olup olmadığını belirlemek için yapılmaktadır.</p>
                        <ul class="nav nav-tabs" role="tablist">
                            <li role="presentation" class="active"><a href="#bmi_metric_version" aria-controls="bmi_metric_version" role="tab" data-toggle="tab">Hesaplama</a></li>
                            <li role="presentation"><a href="#bmi_table" aria-controls="bmi_table" role="tab" data-toggle="tab">Hesap Sonuç Değerlendirme</a></li>
                        </ul>
                        <div class="tab-content border-gray-lightgray pr-0">
                            <div role="tabpanel" class="tab-pane active" id="bmi_metric_version">
                                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <div id="form_bmi_metric_calculator">
                                            <div class="row">
                                                <div class="col-xs-8">
                                                    <div class="form-group">
                                                        <label>Ağırlık </label>
                                                        <asp:TextBox ID="txtAgirlik" runat="server" class="form-control" required placeholder="kg"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="clearfix"></div>
                                                <div class="col-xs-5">
                                                    <div class="form-group">
                                                        <label>Boy </label>
                                                        <asp:TextBox ID="txtBoy" runat="server" class="form-control" required placeholder="cm Olarak yazınız"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="clearfix"></div>
                                                <div class="col-xs-12">
                                                    <div id="divSonuc" runat="server" visible="false" style="margin-bottom:10px;">
                                                        <asp:Label ID="lblSonuc1" runat="server"></asp:Label>&nbsp;<asp:Label ID="lblSonuc" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>&nbsp;<asp:Label ID="lblSonuc2" runat="server"></asp:Label>
                                                    </div>
                                                    <asp:LinkButton ID="lnkHesapla" runat="server" class="btn btn-sm btn-theme-colored" data-loading-text="Lütfen Bekleyiniz..." OnClick="lnkHesapla_Click">Hesapla</asp:LinkButton>
                                                </div>
                                            </div>
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="bmi_table">
                                <p>Dünya Sağlık Örgütü tarafından yapılan araştırmalar sonucunda <strong>Vücut Kitle İndeksi Hesaplama</strong> oranlarının temsil ettikleri değerler ve karşılıkları aşağıda belirtilmiştir. Yapmış olduğunuz hesaplama sonucuna göre tablodan ilgili değeri karşılaştırınız.</p>
                                <table class="table table-striped">
                                    <tbody>
                                        <tr>
                                            <td>Kategori</td>
                                            <td>VKİ Oran - kg/m<sup>2</sup></td>
                                        </tr>
                                        <tr>
                                            <td>Çok Zayıf</td>
                                            <td>&lt; 16</td>
                                        </tr>
                                        <tr>
                                            <td>Zayıf</td>
                                            <td>16 - 17</td>
                                        </tr>
                                        <tr>
                                            <td>Orta Zayıf</td>
                                            <td>17 - 18.5</td>
                                        </tr>

                                        <tr>
                                            <td>Normal</td>
                                            <td>18.5 - 25</td>
                                        </tr>
                                        <tr>
                                            <td>Kilolu</td>
                                            <td>25 - 30</td>
                                        </tr>
                                        <tr>
                                            <td>Obez 1. Sınıf</td>
                                            <td>30 - 35</td>
                                        </tr>
                                        <tr>
                                            <td>Obez 2. Sınıf</td>
                                            <td>35 - 40</td>
                                        </tr>
                                        <tr>
                                            <td>Obez 3. Sınıf</td>
                                            <td>&gt; 40</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <img src="/images/nutrition/about/1.png" alt="" />
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id="gallery">
        <div class="container-fluid pb-0">
            <div class="section-title text-center">
                <div class="row">
                    <div class="col-md-8 col-md-offset-2">
                        <h2 class="title">Sizlere Uygun <span class="text-black font-weight-300">Tarifler</span></h2>
                        <p class="letter-space-4">Kategorilere ait 4'er tane tarif bulunmaktadır. Daha Fazlası İçin Menüden İlgili Kategoriyi Tıklayınız.</p>
                    </div>
                </div>
            </div>
            <div class="section-content">
                <div class="row">
                    <div class="col-md-12">
                        <div class="portfolio-filter">
                            <%--<a href="#" data-filter="*">Tümü</a>--%>
                            <asp:Literal ID="ltrKategoriler" runat="server"></asp:Literal>
                        </div>
                        <div id="grid" class="gallery-isotope grid-4 clearfix">
                            <asp:Literal ID="ltrTarifler" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

