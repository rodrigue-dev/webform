using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webschool;

namespace b_school.admin
{
    public partial class add_professeur : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
               
            }
           

        }
        protected void Save(object sender, EventArgs e)
        {
            Console.WriteLine("All All student in the database:");
            using (var db = new Model1())
            {
                var prof = new PROFESSEUR();
                prof.NOM = IdtxtFirstName.Text.Trim();
                prof.PRENOM = IdtxtLastname.Text.Trim();
                prof.TELEPHONE = int.Parse(IdtxtPhone.Text.Trim());
                prof.EMAIL = IdtxtEmail.Text.Trim();
                db.PROFESSEURs.Add(prof);
                db.SaveChanges();
                Response.Redirect("/admin/professeur");
            return;
            }
            
        }
    }
}