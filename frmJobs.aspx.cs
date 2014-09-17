using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class frmJobs : System.Web.UI.Page
{
    private string user;
    protected void Page_Load(object sender, EventArgs e)
    {
        //
             if (Request.QueryString["id5"] != null)
        {
             user = Request.QueryString["id5"];

             Session["ID"] = user;
            //

            String strConnString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            SqlConnection con = new SqlConnection(strConnString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "splistjobs";

            cmd.Connection = con;

            try
            {

                con.Open();
                GridView2.Visible = true;
                GridView2.EmptyDataText = "No Records Found";


                GridView2.DataSource = cmd.ExecuteReader();

                GridView2.DataBind();

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
    
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!DropDownList1.SelectedValue.Equals(null)) {

            int val = int.Parse(DropDownList1.SelectedValue);
            //

            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection con = new SqlConnection(constring);

            SqlCommand command = new SqlCommand("spjobsbycateg", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@val", SqlDbType.Int).Value = val;
            try
            {

                con.Open();
             //   DetailsView1.Visible = false;
               // GridView2.Visible = true;
                GridView2.EmptyDataText = "No Job Postings Found";

                GridView2.DataSource = command.ExecuteReader();

                GridView2.DataBind();

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
    protected void Button1_Click(object sender, EventArgs e)
    {
        String strConnString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        SqlConnection con = new SqlConnection(strConnString);

        SqlCommand cmd = new SqlCommand();

        cmd.CommandType = CommandType.StoredProcedure;

        cmd.CommandText = "splistjobs";

        cmd.Connection = con;

        try
        {

            con.Open();
           // DetailsView1.Visible = false;
           // GridView2.Visible = true;
            GridView2.EmptyDataText = "No Job Postings Found";
            

            GridView2.DataSource = cmd.ExecuteReader();

            GridView2.DataBind();

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
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

        //
        
                 //
        // Get the currently selected row using the SelectedRow property.
        GridViewRow row = GridView2.SelectedRow;

        // Display the first name from the selected row.
        // In this example, the third column (index 2) contains
        // the first name.
        Label2.Text = "You selected " + row.Cells[3].Text + ".";
        String id = row.Cells[1].Text;

        Object key = GridView2.SelectedDataKey.Value;
        id = key.ToString();
       // Session["ID1"] = id;
        //if ((Session["ID1"] != null))
        //{
            //TextBox1.Text = (string)(Session["ID1"]);
            //string field4 = TextBox1.Text;

            //  int val = (int)(field4);   

        GridView2.Visible = false;
        DetailsView1.Visible = true;
            //

            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection con = new SqlConnection(constring);

            SqlCommand command = new SqlCommand("spjobsbyid", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@val", SqlDbType.Int).Value = id;
            try
            {

                con.Open();

                DetailsView1.EmptyDataText = "No Job Postings Found";

                DetailsView1.DataSource = command.ExecuteReader();

                DetailsView1.DataBind();

                //

               
            }

            catch (Exception ex)
            {

                throw ex;

            }

            finally
            {

                con.Close();

                con.Dispose();

           // }

               // Response.Redirect("frmViewjob.aspx?id6=" + id + "," + user);
           
        }
    }
    protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {
       
    }
    protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmPostjob.aspx?iduser="+ user);
    }
}