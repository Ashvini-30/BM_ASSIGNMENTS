using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace RegistrationForm
{
    public partial class Registration_Form : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.;database=EmployeeDB;trusted_connection=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Textfn_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Textpass_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int len = args.Value.Length;
            if(len>=8 && len<15)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
                
        }

        protected void Drops_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText ="Insert into RegistrationTB values('"+Textfn.Text+"','"+Textln.Text+"','"+Textuser.Text+"','"+Textpass.Text+"','"+Textcpass.Text+"','"+Textmn.Text+"')";
            cmd.ExecuteNonQuery();


        }
    }
}