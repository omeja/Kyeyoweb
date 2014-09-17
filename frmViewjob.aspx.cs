using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class frmViewjob : System.Web.UI.Page
{
    private string id;
    private string id5;
    private string field1;
  
    protected void Page_Load(object sender, EventArgs e)
    {

        //
         field1 = (string)(Session["ID"]);
        //
        //if(Request.QueryString["id6"] != null)
        //{
        //id5 = Request.QueryString["id6"];
        //}


        //
        if (Request.QueryString["id"] != null)
        {
             id = Request.QueryString["id"];
            //string field4 = TextBox1.Text;
             
       //  int val = (int)(field4);   
        
        
            
        //

        string constring = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        SqlCommand command = new SqlCommand("spjobsbyid", con);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@val", SqlDbType.Int).Value = id;
        try
        {

            con.Open();

           //DetailsView1.EmptyDataText = "No Job Postings Found";

           // DetailsView1.DataSource = command.ExecuteReader();

           // DetailsView1.DataBind();

            GridView1.EmptyDataText = "No Job Postings Found";

            GridView1.DataSource = command.ExecuteReader();

            GridView1.DataBind();


        }

        catch (Exception ex)
        {

            throw ex;

        }

        finally
        {

            con.Close();

            con.Dispose();

        }
        }
    }
    protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmApply.aspx?id2="+id+","+field1);
    }
    protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
    {

    }
    protected void DetailsView1_PageIndexChanging1(object sender, DetailsViewPageEventArgs e)
    {

    }
}