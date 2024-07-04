using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_Kategori : System.Web.UI.Page
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

        SqlCommand com = new SqlCommand("insert into kategori (kategoriadi, resim, icerik, siralama, aktif, googleanahtar, googleaciklama) values (@kategoriadi, @resim, @icerik, @siralama, @aktif, @googleanahtar, @googleaciklama)", b.Baglanti);

        com.Parameters.AddWithValue("@kategoriadi", TextBox1.Text);

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

        com.Parameters.AddWithValue("@icerik", FCKeditor1.Value);
        com.Parameters.AddWithValue("@siralama", TextBox3.Text);
        com.Parameters.AddWithValue("@aktif", RadioButtonList1.SelectedItem.Text);
        com.Parameters.AddWithValue("@googleanahtar", TextBox4.Text);
        com.Parameters.AddWithValue("@googleaciklama", TextBox5.Text);


        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Redirect("Kategori.aspx");
        }

        com.Connection.Close();
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("update kategori set aktif=@aktif where ID=@ID", b.Baglanti);

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
            Response.Redirect("Kategori.aspx");
        }

        com.Connection.Close();
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        Label9.Text = tiklanan.CommandArgument.ToString();

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select kategoriadi, resim, icerik, siralama, aktif, googleanahtar, googleaciklama from kategori where ID=@ID", b.Baglanti);

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
                TextBox1.Text = dr[0].ToString();
                TextBox2.Text = dr[1].ToString();
                FCKeditor1.Value = dr[2].ToString();

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

        SqlCommand com = new SqlCommand("update kategori set kategoriadi=@kategoriadi, resim=@resim, icerik=@icerik, siralama=@siralama, aktif=@aktif, googleanahtar=@googleanahtar, googleaciklama=@googleaciklama where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", Label9.Text);
        com.Parameters.AddWithValue("@kategoriadi", TextBox1.Text);

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
            if (TextBox2.Text == "ResimYok.png")
            {
                com.Parameters.AddWithValue("@resim", "ResimYok.png");
            }
            else
            {
                com.Parameters.AddWithValue("@resim", TextBox2.Text);
            }
        }

        com.Parameters.AddWithValue("@icerik", FCKeditor1.Value);
        com.Parameters.AddWithValue("@siralama", TextBox3.Text);
        com.Parameters.AddWithValue("@aktif", RadioButtonList1.SelectedItem.Text);
        com.Parameters.AddWithValue("@googleanahtar", TextBox4.Text);
        com.Parameters.AddWithValue("@googleaciklama", TextBox5.Text);

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Redirect("Kategori.aspx");
        }

        com.Connection.Close();
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("delete from kategori where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", tiklanan.CommandArgument.ToString());

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Redirect("Kategori.aspx");
        }

        com.Connection.Close();
    }
}

//[kategoriadi]
      //,[resim]
      //,[icerik]
      //,[aktif]
      //,[siralama]
      //,[googleanahtar]
      //,[googleaciklama]