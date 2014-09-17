using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class frmRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            //
            string user = this.TextBox1.Text;
            string pass = this.TextBox2.Text;
            string email = this.TextBox3.Text;

            //fixed user id awaiting integration
            string phone = '0'+this.TextBox4.Text;

            //


            //  Session["ID2"] = ID2;



            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection con = new SqlConnection(constring);

            SqlCommand command = new SqlCommand("spadduser", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.Decimal).Value = phone;


            con.Open();
            int rows = command.ExecuteNonQuery();
            con.Close();

            // clear fields
            this.TextBox1.Text = "";
            this.TextBox3.Text = "";
            this.TextBox2.Text = "";
            this.TextBox4.Text = "";




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
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}