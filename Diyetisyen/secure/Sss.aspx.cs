using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_Sss : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Panel1.Visible == false)
        {
            Panel1.Visible = true;
            Button1.Visible = true;
            Button2.Visible = false;
        }
        else
        {
            Panel1.Visible = false;
            Button1.Visible = false;
            Button2.Visible = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("insert into sss (baslik, aciklama, siralama, aktif) values (@baslik, @aciklama, @siralama, @aktif)", b.Baglanti);

        com.Parameters.AddWithValue("@baslik", TextBox1.Text);
        com.Parameters.AddWithValue("@aciklama", TextBox2.Text);
        com.Parameters.AddWithValue("@siralama", TextBox3.Text);
        com.Parameters.AddWithValue("@aktif", RadioButtonList1.SelectedItem.Text);

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Redirect("Sss.aspx");
        }

        com.Connection.Close();
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("update sss set aktif=@aktif where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", tiklanan.CommandArgument.ToString());

        if (tiklanan.Text == "Evet")
        {
            com.Parameters.AddWithValue("@aktif", "Hayır");
        }
        else
        {
            com.Parameters.AddWithValue("@aktif", "Evet");
        }

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Redirect("Sss.aspx");
        }

        com.Connection.Close();
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        Label8.Text = tiklanan.CommandArgument.ToString();

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select baslik, aciklama, siralama, aktif from sss where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", Label8.Text);

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        SqlDataReader dr = com.ExecuteReader();

        if (dr.HasRows)
        {
            Panel1.Visible = true;
            Button1.Visible = false;
            Button2.Visible = true;

            while (dr.Read())
            {
                TextBox1.Text = dr[0].ToString();
                TextBox2.Text = dr[1].ToString();
                TextBox3.Text = dr[2].ToString();

                if (dr[3].ToString() == "Evet")
                {
                    RadioButtonList1.SelectedIndex = 0;
                }
                else
                {
                    RadioButtonList1.SelectedIndex = 1;
                }
            }
        }
        else
        {

        }
        dr.Close();
        com.Connection.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("update sss set baslik=@baslik, aciklama=@aciklama, siralama=@siralama, aktif=@aktif where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", Label8.Text);
        com.Parameters.AddWithValue("@baslik", TextBox1.Text);
        com.Parameters.AddWithValue("@aciklama", TextBox2.Text);
        com.Parameters.AddWithValue("@siralama", TextBox3.Text);
        com.Parameters.AddWithValue("@aktif", RadioButtonList1.SelectedItem.Text);

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Redirect("Sss.aspx");
        }

        com.Connection.Close();
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("delete from sss where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", tiklanan.CommandArgument.ToString());

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Redirect("Sss.aspx");
        }

        com.Connection.Close();
    }
}