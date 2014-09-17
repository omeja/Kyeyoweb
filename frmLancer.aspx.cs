using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class frmLancer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            //
            string fname = this.txtfname.Text;
            string lname = this.txtlname.Text;
            string email = this.txtemail.Text;
            string telephone = this.txtphone.Text;
            string pass = this.txtpass.Text;
            //


            //  Session["ID2"] = ID2;



            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection con = new SqlConnection(constring);

            SqlCommand command = new SqlCommand("spaddlancer", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@firstname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lastname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@telephone", SqlDbType.Decimal).Value = telephone;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;

            con.Open();
            int rows = command.ExecuteNonQuery();
            con.Close();

            // clear fields
            // this.txtcode.Text = "";
            //this.cbocountry.Text = "";
            this.txtfname.Text = "";
            //this.cbocategory.SelectedItem.Value= "";
            this.txtlname.Text = "";
            this.txtemail.Text = "";
            this.txtphone.Text = "";
            this.txtpass.Text = "";


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