using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_SiteSabitleri : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bilgigetir();
        }
    }

    protected void bilgigetir()
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select sitebaslik, siteustyazi, resim, googleanahtar, googleaciklama from sitesabitleri where ID=@ID", b.Baglanti);

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
                TextBox1.Text = dr["sitebaslik"].ToString();
                TextBox2.Text = dr["resim"].ToString();
                TextBox3.Text = dr["googleanahtar"].ToString();
                TextBox4.Text = dr["googleaciklama"].ToString();
                TextBox5.Text = dr["siteustyazi"].ToString();
            }

        }
        else
        {

        }
        dr.Close();
        com.Connection.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("update sitesabitleri set sitebaslik=@sitebaslik, siteustyazi=@siteustyazi, resim=@resim, googleanahtar=@googleanahtar, googleaciklama=@googleaciklama where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", "1");
        com.Parameters.AddWithValue("@sitebaslik", TextBox1.Text);
        com.Parameters.AddWithValue("@siteustyazi", TextBox5.Text);

        if (FileUpload1.HasFile)
        {
            FileInfo f = new FileInfo(FileUpload1.FileName);
            Guid benzersiz = Guid.NewGuid();
            String resimyol = benzersiz.ToString() + f.Name;
            FileUpload1.SaveAs(Server.MapPath("../images/" + "\\" + resimyol));

            com.Parameters.AddWithValue("@resim", resimyol);
        }
        else
        {
            if (TextBox3.Text == "ResimYok.png")
            {
                com.Parameters.AddWithValue("@resim", "ResimYok.png");
            }
            else
            {
                com.Parameters.AddWithValue("@resim", TextBox2.Text);
            }
        }

        com.Parameters.AddWithValue("@googleanahtar", TextBox3.Text);
        com.Parameters.AddWithValue("@googleaciklama", TextBox4.Text);

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Redirect("SiteSabitleri.aspx");
        }

        com.Connection.Close();
    }
}

// [sitebaslik]
// [resim]
// [googleanahtar]
// [googleaciklama]