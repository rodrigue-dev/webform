using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace b_school.admin
{
    public partial class add_ue : System.Web.UI.Page
    {
        private readonly string connctionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }
        protected void Save(object sender, EventArgs e)
        {
            using (SqlConnection xSqlConnection = new SqlConnection(connctionString))
            {
                string cmdText = "INSERT INTO uE (Titre,Periode,Etcs) VALUES(@titre,@periode,@etcs)";
                SqlCommand xSqlCommand = new SqlCommand(cmdText, xSqlConnection);

                xSqlCommand.Parameters.AddWithValue("@titre", IdtxtTitre.Text.Trim());
                xSqlCommand.Parameters.AddWithValue("@periode", IdtxtPeriode.Text.Trim());
                xSqlCommand.Parameters.AddWithValue("@etcs", IdtxtEtcs.Text.Trim());
                
               
                xSqlConnection.Open();
                int isInserted = xSqlCommand.ExecuteNonQuery();
                xSqlConnection.Close();
                if (isInserted > 0)
                {
                    Response.Redirect("/admin/ue");
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