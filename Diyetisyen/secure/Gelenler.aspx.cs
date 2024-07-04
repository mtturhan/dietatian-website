using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_Gelenler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;
    
        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("delete from gelenler where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", tiklanan.CommandArgument.ToString());

        if(com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery()>0) 
        {
           Response.Redirect("Gelenler.aspx");
        }

        com.Connection.Close();
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        LinkButton tiklanan = (LinkButton)sender;

        BaglantiBilgileri b = new BaglantiBilgileri();

        SqlCommand com = new SqlCommand("update gelenler set okundu=@okundu where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", tiklanan.CommandArgument.ToString());

        if (tiklanan.Text=="Evet")
        {
            com.Parameters.AddWithValue("@okundu", "Hayır");
        }
        else
        {
            com.Parameters.AddWithValue("@okundu", "Evet");
        }

        if(com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

       if (com.ExecuteNonQuery()>0) 
       {
           Response.Redirect("Gelenler.aspx");
       }

        com.Connection.Close();
    }
}