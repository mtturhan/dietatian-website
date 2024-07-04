using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        sabitlerigetir();
        iletisimgetir();
        kategorilergetir();
        tariflergetir();
        hakkimizdagetir();
    }

    protected void sabitlerigetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select resim, sitebaslik from sitesabitleri where ID=@ID", b.Baglanti);

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
                ltrBannerLogo.Text = "<img src='/images/" + dr["resim"].ToString() + "' alt='" + dr["sitebaslik"].ToString() + "' />";
                ltrFooterLogo.Text = "<img src='/images/" + dr["resim"].ToString() + "' alt='" + dr["sitebaslik"].ToString() + "' class='mt-10 mb-20' style='max-height: 100px !important;' />";
            }
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }

    protected void iletisimgetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select facebook, instagram, linkedin, adres, telefon, mailadresi from iletisim where ID=@ID", b.Baglanti);

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
                ltrBannerFacebook.Text = "<a href='" + dr["facebook"].ToString() + "' target='_blank'><i class='fa fa-facebook text-white'></i></a>";
                ltrBannerInstagram.Text = "<a href='" + dr["instagram"].ToString() + "' target='_blank'><i class='fa fa-instagram text-white'></i></a>";
                ltrBannerLinkedin.Text = "<a href='" + dr["linkedin"].ToString() + "' target='_blank'><i class='fa fa-linkedin text-white'></i></a>";
                ltrBannerTelefon.Text = "<a href='tel:" + dr["telefon"].ToString().Replace(" ","") + "'>" + dr["telefon"].ToString() + "</a>";
                ltrFooterFacebook.Text = "<a href='" + dr["facebook"].ToString() + "' target='_blank'><i class='fa fa-facebook text-white'></i></a>";
                ltrFooterInstagram.Text = "<a href='" + dr["instagram"].ToString() + "' target='_blank'><i class='fa fa-instagram text-white'></i></a>";
                ltrFooterLinkedin.Text = "<a href='" + dr["linkedin"].ToString() + "' target='_blank'><i class='fa fa-linkedin text-white'></i></a>";
                ltrFooterTelefon.Text = "<a href='tel:" + dr["telefon"].ToString().Replace(" ","") + "'>" + dr["telefon"].ToString() + "</a>";
            }
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

        SqlCommand com = new SqlCommand("select ID, kategoriadi from kategori where aktif=@aktif order by siralama", b.Baglanti);

        com.Parameters.AddWithValue("@aktif", "Evet");

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        SqlDataReader dr = com.ExecuteReader();

        if (dr.HasRows)
        {
            rptKategoriler.DataSource = dr;
            rptKategoriler.DataBind();
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }

    protected void tariflergetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select top(10) ID, yemekadi from tarif where aktif=@aktif order by newid()", b.Baglanti);

        com.Parameters.AddWithValue("@aktif", "Evet");

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        SqlDataReader dr = com.ExecuteReader();

        if (dr.HasRows)
        {
            rptTarifler.DataSource = dr;
            rptTarifler.DataBind();
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }

    protected void hakkimizdagetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select kisaaciklama from hakkimizda where ID=@ID", b.Baglanti);

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
                ltrFooterKisaAciklama.Text = dr["kisaaciklama"].ToString();
            }
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }
}
