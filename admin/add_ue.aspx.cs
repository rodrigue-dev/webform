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
using webschool;

namespace b_school.admin
{
    public partial class add_ue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var query = db.SECTIONs.ToList();


                SECTIONID.DataSource = query;
                SECTIONID.DataValueField = "IDSECTION";
                SECTIONID.DataTextField = "IDSECTION";
                SECTIONID.DataBind(); 
               
            }


            }
        protected void Save(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var ue = new UE();
                ue.TITRE = IdtxtTitre.Text.Trim();
                ue.DESCRIPTION = IdtxtEtcs.Text.Trim();
                ue.ECTS = int.Parse(IdtxtEtcs.Text.Trim());
                ue.PERIODE= int.Parse(IdtxtPeriode.Text.Trim());
                ue.IDSECTION= int.Parse(SECTIONID.SelectedValue.Trim());
                db.UEs.Add(ue);
                db.SaveChanges();
                Response.Redirect("/admin/ue");
                       return;


                // ue.PERIODE = IdtxtPeriode.TextMode(int);
                // ue.ECTS = IdtxtEtcs.Text.Trim();
            }
            //    using (SqlConnection xSqlConnection = new SqlConnection(connctionString))
            //{
            //    string cmdText = "INSERT INTO uE (Titre,Periode,Etcs) VALUES(@titre,@periode,@etcs)";
            //    SqlCommand xSqlCommand = new SqlCommand(cmdText, xSqlConnection);

            //    xSqlCommand.Parameters.AddWithValue("@titre", IdtxtTitre.Text.Trim());
            //    xSqlCommand.Parameters.AddWithValue("@periode", IdtxtPeriode.Text.Trim());
            //    xSqlCommand.Parameters.AddWithValue("@etcs", IdtxtEtcs.Text.Trim());


            //    xSqlConnection.Open();
            //    int isInserted = xSqlCommand.ExecuteNonQuery();
            //    xSqlConnection.Close();
            //    if (isInserted > 0)
            //    {
            //        Response.Redirect("/admin/ue");
            //        return;
            //        /*
            //        lblMessage.Text = "Data Saved Sucessfully.";
            //        lblMessage.ForeColor = System.Drawing.Color.Green;*/
            //    }
            //    else
            //    {
            //        /*  lblMessage.Text = "Data Not Saved.";
            //          lblMessage.ForeColor = System.Drawing.Color.Red;*/
            //    }
            //}
        }
    }
}