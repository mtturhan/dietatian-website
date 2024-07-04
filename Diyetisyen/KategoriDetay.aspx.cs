using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KategoriDetay : System.Web.UI.Page
{
    string sitebaslik = "";
    StringBuilder sbTarif = new StringBuilder();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            int test = Convert.ToInt32(RouteData.Values["ID"].ToString());
            lblGelenID.Text = test.ToString();
        }
        catch (Exception)
        {
            Response.Redirect("/anasayfa");
        }

        sabitlerigetir();
        icerikseogetir();
    }

    protected void sabitlerigetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select sitebaslik from sitesabitleri where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", "1");

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        SqlDataReader dr = com.ExecuteReader();

        if (dr.HasRows)
        {
            while (dr.Read())
            {
                sitebaslik = dr["sitebaslik"].ToString();
            }
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }

    protected void icerikseogetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select kategoriadi, icerik, googleanahtar, googleaciklama, lower(kategoriadi) as kucukkategoriadi from kategori where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", lblGelenID.Text);

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        SqlDataReader dr = com.ExecuteReader();

        if (dr.HasRows)
        {
            while (dr.Read())
            {
                this.Title = sitebaslik + " | " + dr["kategoriadi"].ToString();
                this.MetaKeywords = dr["googleanahtar"].ToString();
                this.MetaDescription = dr["googleaciklama"].ToString();
                ltrBaslik.Text = dr["kategoriadi"].ToString();
                ltrAciklama.Text = dr["icerik"].ToString();
                tariflergetir(lblGelenID.Text, dr["kucukkategoriadi"].ToString());
                ltrTarifler.Text = sbTarif.ToString();
            }
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }

    protected void tariflergetir(string kategoriID, string kategoriadi)
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select tarifID, (select resim from tarif where ID=tarifID) as resim, (select yemekadi from tarif where ID=tarifID) as yemekadi from tarifler where kategoriID=@kategoriID and aktif=@aktif order by siralama", b.Baglanti);

        com.Parameters.AddWithValue("@aktif", "Evet");
        com.Parameters.AddWithValue("@kategoriID", kategoriID);

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        SqlDataReader dr = com.ExecuteReader();

        if (dr.HasRows)
        {
            while (dr.Read())
            {
                sbTarif.AppendLine("<div class='gallery-item " + kategoriadi + "'>");
                sbTarif.AppendLine("<div class='thumb'>");
                sbTarif.AppendLine("<img class='img-fullwidth' src='/images/" + dr["resim"].ToString() + "' alt='" + dr["yemekadi"].ToString() + "' style='min-height: 279px !important;'>");
                sbTarif.AppendLine("<div class='overlay-shade'></div>");
                sbTarif.AppendLine("<div class='text-holder text-center'>");
                sbTarif.AppendLine("<h5 class='title'>" + dr["yemekadi"].ToString() + "</h5>");
                sbTarif.AppendLine("</div>");
                sbTarif.AppendLine("<div class='icons-holder'>");
                sbTarif.AppendLine("<div class='icons-holder-inner'>");
                sbTarif.AppendLine("<div class='styled-icons icon-sm icon-dark icon-circled icon-theme-colored'>");
                sbTarif.AppendLine("<a data-lightbox='image' href='/images/" + dr["resim"].ToString() + "'><i class='fa fa-plus'></i></a>");
                sbTarif.AppendLine("<a href='/tarifdetay/" + dr["tarifID"].ToString() + "/" + Temizle.UrlCevir(dr["yemekadi"].ToString()) + "'><i class='fa fa-link'></i></a>");
                sbTarif.AppendLine("</div>");
                sbTarif.AppendLine("</div>");
                sbTarif.AppendLine("</div>");
                sbTarif.AppendLine("<a class='hover-link' data-lightbox='image' href='/images/" + dr["resim"].ToString() + "'>Devamı</a>");
                sbTarif.AppendLine("</div>");
                sbTarif.AppendLine("</div>");
            }
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }
}