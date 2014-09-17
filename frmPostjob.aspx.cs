using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Postjob : System.Web.UI.Page
{
    private string field2;
    private string user;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["iduser"] != null)
        {
            user = Request.QueryString["iduser"];
            try
            {
                //
                // field2 = (string)(Session["ID"]);
                //
                string jobtitle = this.txttitle.Text;
                string jobcategory = this.cbocategory.Text;
                string jobdesc = this.txtdetails.Text;
                string jobbudget = this.txtbudget.Text;
                string jobdate = this.txtdt.Text;
               // string user = "osbert";
                //


                //  Session["ID2"] = ID2;



                string constring = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(constring);

                SqlCommand command = new SqlCommand("spaddpost", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@jobtitle", SqlDbType.VarChar).Value = jobtitle;
                command.Parameters.Add("@jobcategory", SqlDbType.Int).Value = jobcategory;
                command.Parameters.Add("@jobdesc", SqlDbType.VarChar).Value = jobdesc;
                command.Parameters.Add("@jobbudget", SqlDbType.Decimal).Value = jobbudget;
                command.Parameters.Add("@jobdate", SqlDbType.Date).Value = jobdate;
                command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;

                con.Open();
                int rows = command.ExecuteNonQuery();
                con.Close();

                // clear fields
                // this.txtcode.Text = "";
                //this.cbocountry.Text = "";
                this.txttitle.Text = "";
                //this.cbocategory.SelectedItem.Value= "";
                this.txtdetails.Text = "";
                this.txtbudget.Text = "";
                this.txtdt.Text = "";



                //if (rows == 1)
                //{

                //    MessageBox.Show("Data Saved Succesfully");
                //}
                //else
                //{
                //    MessageBox.Show("Data FAILED to Save!!");
                //} 
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}