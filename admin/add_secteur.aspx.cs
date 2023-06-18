using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webschool;

namespace b_school.admin
{
    public partial class add_secteur : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Save(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var item = new SECTEUR();
                item.DATEFIN = DateTime.Parse(IdtxtDateDebut.Text.Trim());
                item.DATEDEBUT = DateTime.Parse(IdtxtDateDebut.Text.Trim());
                item.INTITULE = IdtxtIntitule.Text.Trim();
                db.SECTEURs.Add(item);
                db.SaveChanges();
                Response.Redirect("/admin/secteur");
                return;
            }
        }
    }
}