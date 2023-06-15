using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace b_school.admin
{
    public partial class add_section : System.Web.UI.Page
    {
        private readonly string connctionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Save(object sender, EventArgs e)
        {
            using (SqlConnection xSqlConnection = new SqlConnection(connctionString))
            {
                string cmdText = "INSERT INTO section (Debouches,Description,ImageSection) VALUES(@debouchee,@description,@image)";
                SqlCommand xSqlCommand = new SqlCommand(cmdText, xSqlConnection);

                xSqlCommand.Parameters.AddWithValue("@debouchee", IdtxtDebouche.Text.Trim());
                xSqlCommand.Parameters.AddWithValue("@description", IdtxtDescription.Text.Trim());
                xSqlCommand.Parameters.AddWithValue("@image", IdtxtDescription.ToString());
                //xSqlCommand.Parameters.AddWithValue("@grade", IdDdListGrade.SelectedValue);
                //xSqlCommand.Parameters.AddWithValue("@secteur", 1);
                xSqlConnection.Open();
                int isInserted = xSqlCommand.ExecuteNonQuery();
                xSqlConnection.Close();
                if (isInserted > 0)
                {
                    Response.Redirect("/admin/section");
                    return;
                    /*
                    lblMessage.Text = "Data Saved Sucessfully.";
                    lblMessage.ForeColor = System.Drawing.Color.Green;*/
                }
                else
                {
                    /*  lblMessage.Text = "Data Not Saved.";
                      lblMessage.ForeColor = System.Drawing.Color.Red;*/
                }
            }
        }
    }
}