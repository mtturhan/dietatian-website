<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>

<script RunAt="server">


    void Application_Start(object sender, EventArgs e)
    {
        RegisterRoutes(RouteTable.Routes);
    }

    void Application_End(object sender, EventArgs e)
    {

    }

    void Application_Error(object sender, EventArgs e)
    {

    }

    void Session_Start(object sender, EventArgs e)
    {

    }

    void Session_End(object sender, EventArgs e)
    {

    }

    void RegisterRoutes(RouteCollection routes)
    {
        //masterpage                                                    //OK-1


        routes.MapPageRoute("anasayfa",
                            "anasayfa/",
                            "~/Default.aspx");                          //OK-2


        routes.MapPageRoute("hakkimizda",
                            "hakkimizda/",
                            "~/Hakkimizda.aspx");                       //OK-3


        routes.MapPageRoute("hizmetlerimiz",
                            "hizmetlerimiz/",
                            "~/Hizmetlerimiz.aspx");                    //OK-4


        routes.MapPageRoute("sss",
                            "sss/",
                            "~/Sss.aspx");                              //OK-5


        routes.MapPageRoute("kategoridetay",
                            "kategoridetay/{ID}/{KategoriAdi}",
                            "~/KategoriDetay.aspx");                    //OK-6


        routes.MapPageRoute("tarifdetay",
                            "tarifdetay/{ID}/{YemekAdi}",
                            "~/TarifDetay.aspx");                       //OK-7


        routes.MapPageRoute("iletisim",
                            "iletisim/",
                            "~/Iletisim.aspx");                         //OK-8
    }
       
</script>
