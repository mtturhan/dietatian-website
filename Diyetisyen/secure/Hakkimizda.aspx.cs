using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_Hakkimizda : System.Web.UI.Page
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

        SqlCommand com = new SqlCommand("select baslik, resim, aciklama, kisaaciklama, googleanahtar, googleaciklama from hakkimizda where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", "1");

        if(com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        SqlDataReader dr = com.ExecuteReader();

        if (dr.HasRows)
        {
            while (dr.Read())
            {
                TextBox1.Text = dr["baslik"].ToString();
                TextBox2.Text = dr["resim"].ToString();
                TextBox3.Text = dr["kisaaciklama"].ToString();
                FCKeditor1.Value = dr["aciklama"].ToString();
                TextBox4.Text = dr["googleanahtar"].ToString();
                TextBox5.Text = dr["googleaciklama"].ToString();
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

        SqlCommand com = new SqlCommand("update hakkimizda set baslik=@baslik, resim=@resim, aciklama=@aciklama, kisaaciklama=@kisaaciklama, googleanahtar=@googleanahtar, googleaciklama=@googleaciklama where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", "1");
        com.Parameters.AddWithValue("@baslik", TextBox1.Text);

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
            if (TextBox3.Text=="ResimYok.png")
            {
                com.Parameters.AddWithValue("@resim", "ResimYok.png");
            }
            else
            {
                com.Parameters.AddWithValue("@resim", TextBox2.Text);
            }
        }

        com.Parameters.AddWithValue("@aciklama", FCKeditor1.Value);
        com.Parameters.AddWithValue("@kisaaciklama", TextBox3.Text);
        com.Parameters.AddWithValue("@googleanahtar", TextBox4.Text);
        com.Parameters.AddWithValue("@googleaciklama", TextBox5.Text);

        if(com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

       if (com.ExecuteNonQuery()>0) 
       {
           Response.Redirect("Hakkimizda.aspx");
       }

        com.Connection.Close();
    }
}