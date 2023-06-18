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
    public partial class add_section : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var query = db.SECTEURs.ToList();


                SecteurID.DataSource = query;
                SecteurID.DataValueField = "IDSECTEUR";
                SecteurID.DataTextField = "INTITULE";
                SecteurID.DataBind();
            }
        }
        protected void Save(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var item = new SECTION();
                item.DESCRIPTION = IdtxtDescription.Text.Trim();
                item.IDSECTEUR = int.Parse(SecteurID.SelectedValue.Trim());
                item.IMAGESECTION = IdtxtDescription.Text.Trim();
                //item.INTITULE = IdtxtIntitule.Text.Trim();
                db.SECTIONs.Add(item);
                db.SaveChanges();
                Response.Redirect("/admin/secteur");
                return;
            }
        }
    }
}