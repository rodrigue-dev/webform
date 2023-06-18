using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webschool;

namespace b_school.admin
{
    public partial class secteur : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var query = db.SECTEURs.ToList();


                grvSecteur.DataSource = query;
                grvSecteur.DataBind();
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
                */
            }
            if (e.CommandName == "DeleteStudent")
            {
                // bool isDeleted = Delete(Convert.ToInt32(hdID.Value));
                bool isDeleted = false;
                if (isDeleted)
                {
                    /* lblMessage.Text = "Data Deleted Sucessfully.";
                     lblMessage.ForeColor = System.Drawing.Color.Green;
               */
                }
                else
                {
                    /*   lblMessage.Text = "Data Not Deleted.";
                       lblMessage.ForeColor = System.Drawing.Color.Red;
                  */
                }
            }
        }

        public bool Delete(int ID)
        {
            int isDeleted = 0;
            if (ID != 0)
            {
               
            }
            return isDeleted > 0;
        }
    }
}