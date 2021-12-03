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
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.RouteData.Values["id"].ToString() != null)
            {
                string rid=Page.RouteData.Values["id"].ToString();
                SqlConnection con = new SqlConnection("server=.;database=EmployeeDB;trusted_connection=true");
                SqlCommand cmd = new SqlCommand("select * from Article where id="+rid, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                string title = ds.Tables[0].Rows[0]["Title"].ToString();
                string desc = ds.Tables[0].Rows[0]["Description"].ToString();
                Label1.Text = title;
                Label2.Text = desc;
                Page.DataBind();


            }

        }
    }
}