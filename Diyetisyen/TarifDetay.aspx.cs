using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TarifDetay : System.Web.UI.Page
{
    string sitebaslik = "";

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

        SqlCommand com = new SqlCommand("select yemekadi, aciklama, kalorimiktari, resim, googleanahtar, googleaciklama from tarif where ID=@ID", b.Baglanti);

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
                this.Title = sitebaslik + " | " + dr["yemekadi"].ToString();
                this.MetaKeywords = dr["googleanahtar"].ToString();
                this.MetaDescription = dr["googleaciklama"].ToString();
                ltrYemekAdi.Text = dr["yemekadi"].ToString();
                ltrKalori.Text = dr["kalorimiktari"].ToString();
                ltrAciklama.Text = dr["aciklama"].ToString();
                ltrResim.Text = "<img class='img-fullwidth' src='/images/" + dr["resim"].ToString() + "' alt='" + dr["yemekadi"].ToString() + "'>";
            }
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }
}