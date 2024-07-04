using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    StringBuilder sbTarif = new StringBuilder();
    double kilo, boy;

    protected void Page_Load(object sender, EventArgs e)
    {
        sabitlerigetir();
        slidergetir();
        hizmetlergetir();
        kategorilergetir();
    }

    protected void sabitlerigetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select sitebaslik, googleanahtar, googleaciklama from sitesabitleri where ID=@ID", b.Baglanti);

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
                this.Title = dr["sitebaslik"].ToString() + " | Anasayfa";
                this.MetaKeywords = dr["googleanahtar"].ToString();
                this.MetaDescription = dr["googleaciklama"].ToString();
            }
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }

    protected void slidergetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select ID, resim, yazi from slider where aktif=@aktif order by siralama", b.Baglanti);

        com.Parameters.AddWithValue("@aktif", "Evet");

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        SqlDataReader dr = com.ExecuteReader();

        if (dr.HasRows)
        {
            rptSlider.DataSource = dr;
            rptSlider.DataBind();
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }

    protected void hizmetlergetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select ID, baslik, resim, kisaaciklama from hizmetlerimiz where aktif=@aktif order by siralama", b.Baglanti);

        com.Parameters.AddWithValue("@aktif", "Evet");

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        SqlDataReader dr = com.ExecuteReader();

        if (dr.HasRows)
        {
            rptHizmetler.DataSource = dr;
            rptHizmetler.DataBind();
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }

    protected void kategorilergetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select ID, kategoriadi, lower(kategoriadi) as kucukkategoriadi from kategori where aktif=@aktif order by siralama", b.Baglanti);

        com.Parameters.AddWithValue("@aktif", "Evet");

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        SqlDataReader dr = com.ExecuteReader();
        StringBuilder sbKategori = new StringBuilder();
        int sayi = 1;

        if (dr.HasRows)
        {
            while (dr.Read())
            {
                if (sayi == 1)
                {
                    sbKategori.AppendLine("<a href='#" + dr["kucukkategoriadi"].ToString() + "' class='active' data-filter='." + dr["kucukkategoriadi"].ToString() + "'>" + dr["kategoriadi"].ToString() + "</a>");
                }
                else
                {
                    sbKategori.AppendLine("<a href='#" + dr["kucukkategoriadi"].ToString() + "' class='' data-filter='." + dr["kucukkategoriadi"].ToString() + "'>" + dr["kategoriadi"].ToString() + "</a>");
                }

                tariflergetir(dr["ID"].ToString(), dr["kucukkategoriadi"].ToString());

                sayi++;
            }
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();

        ltrKategoriler.Text = sbKategori.ToString();
        ltrTarifler.Text = sbTarif.ToString();
    }

    protected void tariflergetir(string kategoriID, string kategoriadi)
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select top(4) tarifID, (select resim from tarif where ID=tarifID) as resim, (select yemekadi from tarif where ID=tarifID) as yemekadi from tarifler where kategoriID=@kategoriID and aktif=@aktif order by newid()", b.Baglanti);

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

    protected void lnkHesapla_Click(object sender, EventArgs e)
    {
        lblSonuc1.Text = "";
        lblSonuc2.Text = "";

        if (txtAgirlik.Text == "" || txtBoy.Text == "")
        {
            lblSonuc.Text = "Ağırlık ve Boy Bilgilerini Giriniz";
            divSonuc.Visible = true;
        }
        else
        {
            lblSonuc.Text = "";
            divSonuc.Visible = false;

            try
            {
                kilo = Convert.ToDouble(txtAgirlik.Text.Replace(",","."));
                lblSonuc.Text = "";
                divSonuc.Visible = false;
            }
            catch (Exception)
            {
                lblSonuc.Text = "Ağırlık Bilgilerini Tamsayı Olarak Giriniz";
                divSonuc.Visible = true;
            }

            try
            {
                boy = Convert.ToDouble(txtBoy.Text.Replace(",", "."));
                lblSonuc.Text = "";
                divSonuc.Visible = false;
            }
            catch (Exception)
            {
                lblSonuc.Text = "Boy Bilgilerini cm ve Tamsayı Olarak Giriniz";
                divSonuc.Visible = true;
            }

            double islemboy = boy / 100;

            double islemsonuc = kilo / (islemboy * islemboy);

            lblSonuc1.Text = "Vücut kitle İndeksiniz : ";
            lblSonuc.Text =  islemsonuc.ToString("###.##");
            lblSonuc2.Text = " olarak hesaplanmıştır. <br/> <a href='#bmi_table' aria-controls='bmi_table' role='tab' data-toggle='tab'> Hesap Sonuç Değerlendirme Başlığından Detaylarını İnceleyebilirsiniz.</a>";
            divSonuc.Visible = true;
        }
    }
}