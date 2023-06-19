using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace webschool
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var query = db.SECTEURs.ToList();
                //SectionsID.DataSource = query;
                //SectionsID.DataTextField = "IDSECTEUR";
                //SectionsID.DataValueField = "IDSECTION";
                //SectionsID.DataBind();
                HtmlGenericControl ul = UList("Menuid", "menu");
                string[] arrays = {};
                foreach (var section in query)
                {
                    ul.Controls.Add(LIList(section.INTITULE, section.IDSECTEUR.ToString(), section.IDSECTEUR.ToString()));
                   // arrays.Append(section.DESCRIPTION);
                }
               // SectionsID.Controls.Add(ul);
            // unorderedList.DataSource = arrays;
                unorderedList.Controls.Add(ul);
          //  unorderedList.DataBind();
            }
           
           

        }
        protected void unorderedList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                string itemValue = (string)e.Item.DataItem;
                Literal myItem = (Literal)e.Item.FindControl("myItem");
                myItem.Text = itemValue;
            }
        }
        private HtmlGenericControl UList(string id, string cssClass)
        {
            HtmlGenericControl ul = new HtmlGenericControl("ul");
            ul.ID = id;
            ul.Attributes.Add("class", cssClass);
            return ul;
        }
        private HtmlGenericControl LIList(string innerHtml, string rel, string url)
        {
            HtmlGenericControl li = new HtmlGenericControl("li");
            li.Attributes.Add("rel", rel);
            li.InnerHtml = "<a href=/Secteurview?Item=" + string.Format(rel) + "&ID=" + string.Format(innerHtml) + ">" + innerHtml + "</a>";
            return li;
        }
    }
   
}