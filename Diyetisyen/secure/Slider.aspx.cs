using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_Slider : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Panel1.Visible==false)
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

        SqlCommand com = new SqlCommand("insert into slider (resim, yazi, siralama, aktif) values (@resim, @yazi, @siralama, @aktif)", b.Baglanti);

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

        com.Parameters.AddWithValue("@yazi", txtYazi.Text);
        com.Parameters.AddWithValue("@siralama", txtSiralama.Text);
        com.Parameters.AddWithValue("@aktif", rbAktif.SelectedItem.Text);

        if(com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

       if (com.ExecuteNonQuery()>0) 
       {
           Response.Redirect("Slider.aspx");
       }

        com.Connection.Close();
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("update slider set aktif=@aktif where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", tiklanan.CommandArgument.ToString());

        if (tiklanan.Text=="Evet")
        {
            com.Parameters.AddWithValue("@aktif", "Hayır");
        }
        else
	    {
            com.Parameters.AddWithValue("@aktif", "Evet");
	    }

        if(com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

       if (com.ExecuteNonQuery()>0) 
       {
           Response.Redirect("Slider.aspx");
       }

        com.Connection.Close();
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        lblDegistirID.Text = tiklanan.CommandArgument.ToString();

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("select resim, yazi, siralama, aktif from slider where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", lblDegistirID.Text);

        if(com.Connection.State == ConnectionState.Closed)
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
                txtResim.Text = dr["resim"].ToString();
                txtYazi.Text = dr["yazi"].ToString();
                txtSiralama.Text = dr["siralama"].ToString();

                if (dr["aktif"].ToString()=="Evet")
                {
                    rbAktif.SelectedIndex = 0;
                }
                else
                {
                    rbAktif.SelectedIndex = 1;
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

        SqlCommand com = new SqlCommand("update slider set resim=@resim, yazi=@yazi, siralama=@siralama, aktif=@aktif where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", lblDegistirID.Text);

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
            if (txtResim.Text=="ResimYok.png")
            {
                com.Parameters.AddWithValue("@resim", "ResimYok.png");
            }
            else
            {
                com.Parameters.AddWithValue("@resim", txtResim.Text);
            }
        }

        com.Parameters.AddWithValue("@yazi", txtYazi.Text);
        com.Parameters.AddWithValue("@siralama", txtSiralama.Text);
        com.Parameters.AddWithValue("@aktif", rbAktif.SelectedItem.Text);

        if(com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

       if (com.ExecuteNonQuery()>0) 
       {


       }

        com.Connection.Close();
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("delete from slider where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", tiklanan.CommandArgument.ToString());

        if(com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

       if (com.ExecuteNonQuery()>0) 
       {
           Response.Redirect("Slider.aspx");
       }

        com.Connection.Close();
    }
}