using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_Iletisim : System.Web.UI.Page
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

        SqlCommand com = new SqlCommand("select telefon, mailadresi, adres, facebook, instagram, linkedin from iletisim where ID=@ID", b.Baglanti);

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
                TextBox1.Text = dr["telefon"].ToString();
                TextBox2.Text = dr["mailadresi"].ToString();
                TextBox3.Text = dr["adres"].ToString();
                TextBox4.Text = dr["facebook"].ToString();
                TextBox5.Text = dr["instagram"].ToString();
                TextBox6.Text = dr["linkedin"].ToString();
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

        SqlCommand com = new SqlCommand("update iletisim set telefon=@telefon, mailadresi=@mailadresi, adres=@adres, facebook=@facebook, instagram=@instagram, linkedin=@linkedin where ID=@ID", b.Baglanti);

        com.Parameters.AddWithValue("@ID", "1");
        com.Parameters.AddWithValue("@telefon", TextBox1.Text);
        com.Parameters.AddWithValue("@mailadresi", TextBox2.Text);
        com.Parameters.AddWithValue("@adres", TextBox3.Text);
        com.Parameters.AddWithValue("@facebook", TextBox4.Text);
        com.Parameters.AddWithValue("@instagram", TextBox5.Text);
        com.Parameters.AddWithValue("@linkedin", TextBox6.Text);

        if (com.Connection.State == ConnectionState.Closed)
        {
            com.Connection.Open();
        }

        if (com.ExecuteNonQuery() > 0)
        {
            Response.Write("<script lang='JavaScript'>alert('Bilgiler Kaydedilmiştir!'); window.location = 'Iletisim.aspx'</script>");
        }

        com.Connection.Close();
    }
}