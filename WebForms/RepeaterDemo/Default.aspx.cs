using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepeaterDemo
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        public object RepeatInformation { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
    }
}