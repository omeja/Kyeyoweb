using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class frmApply : System.Web.UI.Page
{
    private String id;
    //
    protected void Page_Load(object sender, EventArgs e)
    {
         id = Request.QueryString["id2"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (id != null)
        {
            try
            {
                // split id

                String[] prt = id.Split(',');
                
                //
                string jobid = prt[0];
                string jobstmt = this.txtstmt.Text;
                string jobamt = this.txtbid.Text;

                //fixed user id awaiting integration
                string jobbuser = prt[1];
               
                //


                //  Session["ID2"] = ID2;



                string constring = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(constring);

                SqlCommand command = new SqlCommand("spaddapp", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@stmt", SqlDbType.VarChar).Value = jobstmt;
                command.Parameters.Add("@jobid", SqlDbType.VarChar).Value = jobid;
                command.Parameters.Add("@userid", SqlDbType.VarChar).Value = jobbuser;
                command.Parameters.Add("@bidamt", SqlDbType.Decimal).Value = jobamt;
               

                con.Open();
                int rows = command.ExecuteNonQuery();
                con.Close();

                // clear fields
                // this.txtcode.Text = "";
                //this.cbocountry.Text = "";
                this.txtbid.Text = "";
                //this.cbocategory.SelectedItem.Value= "";
                this.txtstmt.Text = "";




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
}