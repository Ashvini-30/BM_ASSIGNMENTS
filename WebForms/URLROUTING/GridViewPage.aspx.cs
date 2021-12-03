using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace URLROUTINGDEMO
{
    public partial class GridViewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("server=.;database=EmployeeDB;trusted_connection=true");
            SqlCommand cmd = new SqlCommand("select * from Article", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            GridView1.DataSource=ds.Tables[0];
            GridView1.DataBind();

        }
        protected string GetTitle(object str)
        {
            return str.ToString().Replace(' ', '-');
        }
    }
}