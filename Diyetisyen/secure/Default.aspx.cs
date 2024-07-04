using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label1.Visible = true;
            Label2.Visible = false;
        }
        else if (TextBox2.Text == "")
        {
            Label1.Visible = false;
            Label2.Visible = true;
        }
        else
        {
            Label1.Visible = false;
            Label2.Visible = false;

            BaglantiBilgileri b = new BaglantiBilgileri();

            SqlCommand com = new SqlCommand("select kullaniciadi, sifre, mailadresi, ID from admin where kullaniciadi=@kullaniciadi and sifre=@sifre", b.Baglanti);

            com.Parameters.AddWithValue("@kullaniciadi", TextBox1.Text);
            com.Parameters.AddWithValue("@sifre", TextBox2.Text);

            if (com.Connection.State == ConnectionState.Closed)
            {
                com.Connection.Open();
            }

            SqlDataReader dr = com.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Session["kullaniciID"] = dr["ID"].ToString();
                    Session["kullaniciadi"] = dr[0].ToString();
                    Session["sifre"] = dr[1].ToString();
                    Session["mailadresi"] = dr[2].ToString();

                    Response.Redirect("Anasayfa.aspx");
                }
            }
            else
            {
                Label1.Visible = true;
                Label2.Visible = true;
            }

            com.Connection.Close();
        }
    }
}