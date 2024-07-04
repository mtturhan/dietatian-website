using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sss : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        sabitlerigetir();
        icerikgetir();
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
                this.Title = dr["sitebaslik"].ToString() + " | Sık Sorulan Sorular";
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

    protected void icerikgetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select ID, baslik, aciklama, Row_number() over(order by siralama) as sira from sss where aktif=@aktif order by siralama", b.Baglanti);

        com.Parameters.AddWithValue("@aktif", "Evet");

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        SqlDataReader dr = com.ExecuteReader();

        if (dr.HasRows)
        {
            rptIcerik.DataSource = dr;
            rptIcerik.DataBind();
        }
        else
        {

        }

        dr.Close();
        com.Connection.Close();
    }
}