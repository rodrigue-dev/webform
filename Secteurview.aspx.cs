using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webschool
{
    public partial class Secteurview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;
           // ItemsList.DataSource = CreateDataSource();
           // ItemsList.DataBind();
            if (!string.IsNullOrEmpty(Request.QueryString["Item"]))
            {
                string searchTerm = Request.QueryString["Item"];
                string Id = Request.QueryString["ID"];
                
                //Literal1.Text = searchTerm;
                using (var db = new Model1())
                {
                    var query = db.SECTEURs.ToList().Find(p => p.IDSECTEUR == int.Parse(searchTerm));
                    if (query != null)
                    {
                        lblTitlesecteur.Text = query.INTITULE;
                    var querys = db.SECTIONs.ToList().FindAll(p=>p.IDSECTEUR == int.Parse(searchTerm));
                   // var query = db.SECTEURs.ToList();
                    dtlSecteurs.DataSource = querys;
                    dtlSecteurs.DataBind();
                    }
                 
                }

            }
        }
        ICollection CreateDataSource()
        {

            // Create sample data for the DataList control.
            DataTable dt = new DataTable();
            DataRow dr;

            // Define the columns of the table.
            dt.Columns.Add(new DataColumn("IntegerValue", typeof(Int32)));
            dt.Columns.Add(new DataColumn("StringValue", typeof(String)));
            dt.Columns.Add(new DataColumn("CurrencyValue", typeof(double)));
            dt.Columns.Add(new DataColumn("ImageValue", typeof(String)));

            // Populate the table with sample values.
            for (int i = 0; i < 9; i++)
            {
                dr = dt.NewRow();

                dr[0] = i;
                dr[1] = "Description for item " + i.ToString();
                dr[2] = 1.23 * (i + 1);
                dr[3] = "Image" + i.ToString() + ".jpg";

                dt.Rows.Add(dr);
            }

            DataView dv = new DataView(dt);
            return dv;
        }

        protected void dtlProdutos_ItemDataBound(object sender, DataListItemEventArgs e)
        {

            //if (e.Item.ItemType != ListItemType.Header && e.Item.ItemType != ListItemType.Footer)
            //{
            //    ((HyperLink)e.Item.FindControl("lnkNomeProduto")).Text = ((PRODUTO)e.Item.DataItem).NOME;
            //    ((HyperLink)e.Item.FindControl("lnkNomeProduto")).NavigateUrl = "Detalhes.aspx?produtos=" + ((PRODUTO)e.Item.DataItem).IDT_PRODUTO.ToString();

            //    ((HyperLink)e.Item.FindControl("lnkImgProduto")).NavigateUrl = "Detalhes.aspx?produtos=" + ((PRODUTO)e.Item.DataItem).IDT_PRODUTO.ToString();
            //    ((Image)e.Item.FindControl("imgProduto")).ImageUrl = "http://allan.com.rws6.my-hosting-panel.com/Produtos/" + ((PRODUTO)e.Item.DataItem).FOTO.ToString();

            //    ((Label)e.Item.FindControl("lblPrecoProduto")).Text = ((PRODUTO)e.Item.DataItem).VALOR.ToString("C");
            //    ((ImageButton)e.Item.FindControl("btnCarrinho")).CommandArgument = ((PRODUTO)e.Item.DataItem).IDT_PRODUTO.ToString();

            //}
        }

        protected void dtlProdutos_ItemCommand(object sender, DataListCommandEventArgs e)
        {
           
        }
    }
}