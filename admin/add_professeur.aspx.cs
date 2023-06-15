using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace b_school.admin
{
    public partial class add_professeur : System.Web.UI.Page
    {
        private readonly string connctionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection xSqlConnection = new SqlConnection(connctionString))
            {
                string cmdText = "SELECT * FROM uE";
                SqlCommand xSqlCommand = new SqlCommand(cmdText, xSqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(xSqlCommand);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Ues.DataValueField = "ID";
                Ues.DataTextField = "Titre";
                Ues.DataSource = ds;
                Ues.DataBind();
            }
            using (SqlConnection xSqlConnection = new SqlConnection(connctionString))
            {
                string cmdText = "SELECT * FROM SessionUE";
                SqlCommand xSqlCommand = new SqlCommand(cmdText, xSqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(xSqlCommand);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                SessionUe.DataValueField = "ID";
                SessionUe.DataTextField = "Periode";
                SessionUe.DataSource = ds;
                SessionUe.DataBind();
            }

        }
        protected void Save(object sender, EventArgs e)
        {
            using (SqlConnection xSqlConnection = new SqlConnection(connctionString))
            {
                string cmdText = "INSERT INTO professeur (FirstName,LastName,Phone,Email,UE_ID,SessionUE_ID) VALUES(@firstname,@lastname,@phone,@email,@ui,@sessionUE)";
                SqlCommand xSqlCommand = new SqlCommand(cmdText, xSqlConnection);

                xSqlCommand.Parameters.AddWithValue("@firstname", IdtxtFirstName.Text.Trim());
                xSqlCommand.Parameters.AddWithValue("@lastname", IdtxtLastname.Text.Trim());
                xSqlCommand.Parameters.AddWithValue("@phone", IdtxtPhone.Text.Trim());
                //xSqlCommand.Parameters.AddWithValue("@grade", IdDdListGrade.SelectedValue);
                xSqlCommand.Parameters.AddWithValue("@email", IdtxtEmail.Text.Trim());
                xSqlCommand.Parameters.AddWithValue("@ui", Ues.SelectedValue);
                xSqlCommand.Parameters.AddWithValue("@sessionUE", SessionUe.SelectedValue);
                xSqlConnection.Open();
                int isInserted = xSqlCommand.ExecuteNonQuery();
                xSqlConnection.Close();
                if (isInserted > 0)
                {
                    Response.Redirect("/admin/professeur");
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