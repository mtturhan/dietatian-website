using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_Tarif : System.Web.UI.Page
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

        SqlCommand com = new SqlCommand("insert into tarif (resim, yemekadi, aciklama, kalorimiktari, aktif, googleanahtar, googleaciklama) values (@resim, @yemekadi, @aciklama, @kalorimiktari, @aktif, @googleanahtar, @googleaciklama)", b.Baglanti);

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
            com.Parameters.AddWithValue("@resim", "ResimYok.png");
        }

        com.Parameters.AddWithValue("@yemekadi", TextBox2.Text);
        com.Parameters.AddWithValue("@aciklama", TextBox3.Text);
        com.Parameters.AddWithValue("@kalorimiktari", TextBox4.Text);
        com.Parameters.AddWithValue("@aktif", RadioButtonList1.SelectedItem.Text);
        com.Parameters.AddWithValue("@googleanahtar", TextBox5.Text);
        com.Parameters.AddWithValue("@googleaciklama", TextBox6.Text);


        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Redirect("Tarif.aspx");
        }

        com.Connection.Close();
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("update tarif set aktif=@aktif where ID=@ID", b.Baglanti);

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
            Response.Redirect("Tarif.aspx");
        }

        com.Connection.Close();
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        Label9.Text = tiklanan.CommandArgument.ToString();

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select resim, yemekadi, aciklama, kalorimiktari, aktif, googleanahtar, googleaciklama from tarif where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", Label9.Text);

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
                TextBox1.Text = dr["resim"].ToString();
                TextBox2.Text = dr["yemekadi"].ToString();
                TextBox3.Text = dr["aciklama"].ToString();
                TextBox4.Text = dr["kalorimiktari"].ToString();
                TextBox5.Text = dr["googleanahtar"].ToString();
                TextBox6.Text = dr["googleaciklama"].ToString();

                if (dr["aktif"].ToString() == "Evet")
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

        SqlCommand com = new SqlCommand("update tarif set resim=@resim, yemekadi=@yemekadi, aciklama=@aciklama, kalorimiktari=@kalorimiktari, aktif=@aktif, googleanahtar=@googleanahtar, googleaciklama=@googleaciklama where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", Label9.Text);

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
                com.Parameters.AddWithValue("@resim", TextBox1.Text);
            }
        }

        com.Parameters.AddWithValue("@yemekadi", TextBox2.Text);
        com.Parameters.AddWithValue("@aciklama", TextBox3.Text);
        com.Parameters.AddWithValue("@kalorimiktari", TextBox4.Text);
        com.Parameters.AddWithValue("@aktif", RadioButtonList1.SelectedItem.Text);
        com.Parameters.AddWithValue("@googleanahtar", TextBox5.Text);
        com.Parameters.AddWithValue("@googleaciklama", TextBox6.Text);

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Redirect("Tarif.aspx");
        }

        com.Connection.Close();
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("delete from tarif where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", tiklanan.CommandArgument.ToString());

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Redirect("Tarif.aspx");
        }

        com.Connection.Close();
    }
}

      // [resim]
      // [yemekadi]
      // [aciklama]
      // [kalorimiktari]
      // [aktif]
      // [googleanahtar]
      // [googleaciklama]