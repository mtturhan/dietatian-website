using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hizmetlerimiz : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        sabitlerigetir();
        hizmetlergetir();
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
                this.Title = dr["sitebaslik"].ToString() + " | Hizmetlerimiz";
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
}