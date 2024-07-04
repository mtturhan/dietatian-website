using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_secure : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            int test = Convert.ToInt32(Session["kullaniciID"].ToString());
        }
        catch (Exception)
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Giriş Yapınız!'); window.location = 'Default.aspx'</script>");
        }
    }
}
