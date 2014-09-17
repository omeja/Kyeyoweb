using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string pss=null;
        string val = TextBox1.Text;
        string val2 = TextBox2.Text;

        try
        {
            //
            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection con = new SqlConnection(constring);

            SqlCommand command = new SqlCommand("spgetpass", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@val", SqlDbType.VarChar).Value = val;

            con.Open();
            //  int rows = command.ExecuteNonQuery();
            SqlDataReader rdr = null;
            rdr = command.ExecuteReader();

            // values retrieved
            while (rdr.Read())
            {
                 pss = rdr[0].ToString();
            }
            


            con.Close();

            //

          //  bool result = val2.Equals(pss, StringComparison.Ordinal);

            //

            if (pss.Equals(val2))
            {
               // Response.Redirect("frmJobs.aspx");
                // take user id 

                Response.Redirect("frmJobs.aspx?id5=" + val);
            }
            else {

                Label4.Text = "Password may be invalid..Try Again !";
            }

            if (rdr == null)
            { 
            
            }
          
          

        }
        catch (Exception ex)
        {
            throw;
        }

       


    }
}