using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_AdminTanim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Panel1.Visible == false)
        {
            Panel1.Visible = true;
        }
        else
        {
            Panel1.Visible = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
        {
            Label5.Visible = true;
            Label5.Text = "Boş alan bırakmayınız";
        }
        else
        {
            Label5.Visible = false;
            Label5.Text = "";

            BaglantiBilgileri b = new BaglantiBilgileri();

            SqlCommand com = new SqlCommand("insert into admin (kullaniciadi, sifre, mailadresi) values (@kullaniciadi, @sifre, @mailadresi)", b.Baglanti);

            com.Parameters.AddWithValue("@kullaniciadi", TextBox1.Text);
            com.Parameters.AddWithValue("@sifre", TextBox2.Text);
            com.Parameters.AddWithValue("@mailadresi", TextBox3.Text);

            if (com.Connection.State == ConnectionState.Closed)
            {
                com.Connection.Open();
            }

            if (com.ExecuteNonQuery() > 0)
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                Panel1.Visible = false;
                GridView1.DataBind();
            }
            else
            {

            }

            com.Connection.Close();
        }
    }
}