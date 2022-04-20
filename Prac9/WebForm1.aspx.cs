using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Prac9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string constr = WebConfigurationManager.ConnectionStrings["jdpracConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Students WHERE StudentId= ' " + DropDownList1.SelectedValue + "'");
            try
            {
                SqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    TextBox1.Text = myReader["StudentId"].ToString();
                    TextBox2.Text = myReader[2].ToString();
                    TextBox3.Text = myReader[3].ToString();
                    TextBox4.Text = myReader[4].ToString();
                    TextBox4.Text = myReader[5].ToString();
                }
                myReader.Close();
                this.DataBind();
            }
            catch(Exception err)
            {
                resultLabel.Text += err.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}