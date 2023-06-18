using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webschool
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var query = db.SECTIONs.ToList();
                SectionsID.DataSource = query;
                SectionsID.DataTextField = "IDSECTEUR";
                SectionsID.DataValueField = "IDSECTION";
                SectionsID.DataBind();
            }

        }
    }
}