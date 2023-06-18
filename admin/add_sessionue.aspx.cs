using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webschool;
using static System.Collections.Specialized.BitVector32;

namespace b_school.admin
{
    public partial class add_sessionue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var query = db.PROFESSEURs.ToList();
                var query2 = db.UEs.ToList();

                PROFESSEURID.DataSource = query;
                PROFESSEURID.DataValueField = "IDPROFESSEUR";
                PROFESSEURID.DataTextField ="NOM";
                PROFESSEURID.DataBind();
                UEID.DataSource = query2;
                UEID.DataValueField = "IDUE";
                UEID.DataTextField = "INTITULE";
                UEID.DataBind();
              
              

            }

            }
        protected void Save(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var item = new SESSIONUE();
                item.DATEDEBUT = DateTime.Parse(IdtxtDateDebut.Text.Trim());
                item.DATEFIN = DateTime.Parse(IdtxtDateFin.Text.Trim());
               // item.HEUREDEBUT = TimeSpan.Parse(IdtxtDateDebut.Text.Trim());
                //item.HEUREFIN = TimeSpan.Parse(IdtxtDateFin.Text.Trim());
                item.PERIODE = int.Parse(IdtxtPeriode.Text.Trim());
                item.IDPROFESSEUR = int.Parse(PROFESSEURID.SelectedValue.Trim());
                // item.IDUE = int.Parse(UEID.SelectedValue.Trim());
               // item.IDUE = int.Parse(UEID.SelectedValue.Trim());
                db.SESSIONUEs.Add(item);
                db.SaveChanges();
                Response.Redirect("/admin/sessionue");
                return;


                // ue.PERIODE = IdtxtPeriode.TextMode(int);
                // ue.ECTS = IdtxtEtcs.Text.Trim();
            //}
            //using (SqlConnection xSqlConnection = new SqlConnection(connctionString))
            //{
            //    string cmdText = "INSERT INTO sessionUE (Lieu,Periode,Etcs,DateDebut,DateFin) VALUES(@lieu,@periode,@etcs,@dateDebut,@dateFin)";
            //    SqlCommand xSqlCommand = new SqlCommand(cmdText, xSqlConnection);

            //    xSqlCommand.Parameters.AddWithValue("@lieu", IdtxtLieu.Text.Trim());
            //    xSqlCommand.Parameters.AddWithValue("@periode", IdtxtPeriode.Text.Trim());
            //    xSqlCommand.Parameters.AddWithValue("@etcs", IdtxtEtcs.Text.Trim());
            //    xSqlCommand.Parameters.AddWithValue("@dateDebut", IdtxtDateDebut.Text.Trim());
            //    //xSqlCommand.Parameters.AddWithValue("@grade", IdDdListGrade.SelectedValue);
            //    xSqlCommand.Parameters.AddWithValue("@dateFin", IdtxtDateFin.Text.Trim());

            //    xSqlConnection.Open();
            //    int isInserted = xSqlCommand.ExecuteNonQuery();
            //    xSqlConnection.Close();
            //    if (isInserted > 0)
            //    {
            //        Response.Redirect("/admin/sessionue");
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
            }
        }
    }
}