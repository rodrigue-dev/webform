using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace b_school
{
    public partial class professeur : System.Web.UI.Page
    {
        private readonly string connctionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection xSqlConnection = new SqlConnection(connctionString))
            {
                string cmdText = "SELECT * FROM professeur";
                SqlCommand xSqlCommand = new SqlCommand(cmdText, xSqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(xSqlCommand);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                grvStudent.DataSource = ds;
                grvStudent.DataBind();
            }

        }
        protected void grvStudent_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)((Control)e.CommandSource).NamingContainer;
            int index = row.RowIndex;
          //  hdID.Value = grvStudent.DataKeys[index].Value.ToString();

            if (e.CommandName == "EditStudent")
            {
           /*     hdID.Value = grvStudent.DataKeys[index].Value.ToString();
                IdtxtFirstName.Text = grvStudent.Rows[index].Cells[0].Text;
                IdtxtLastName.Text = grvStudent.Rows[index].Cells[1].Text;
                IdRbListGender.SelectedValue = grvStudent.Rows[index].Cells[2].Text;
                IdDdListGrade.SelectedValue = grvStudent.Rows[index].Cells[3].Text;
                IdtxtDtp.Text = DateTime.Parse(grvStudent.Rows[index].Cells[4].Text).ToString("yyyy-MM-dd");
           */ }
            if (e.CommandName == "DeleteStudent")
            {
               // bool isDeleted = Delete(Convert.ToInt32(hdID.Value));
                bool isDeleted = false;
                if (isDeleted)
                {
                   /* lblMessage.Text = "Data Deleted Sucessfully.";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
              */  }
                else
                {
                 /*   lblMessage.Text = "Data Not Deleted.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
               */ }
            }
        }

        public bool Delete(int ID)
        {
            int isDeleted = 0;
            if (ID != 0)
            {
                using (SqlConnection xSqlConnection = new SqlConnection(connctionString))
                {
                    string cmdText = "DELETE FROM TblStudent WHERE ID=@id";
                    SqlCommand xSqlCommand = new SqlCommand(cmdText, xSqlConnection);

                    xSqlCommand.Parameters.AddWithValue("@id", ID);

                    xSqlConnection.Open();
                    isDeleted = xSqlCommand.ExecuteNonQuery();
                    xSqlConnection.Close();
                }
            }
            return isDeleted > 0;
        }
    }
}