<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Secteurview.aspx.cs" Inherits="webschool.Secteurview" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid bg-primary py-5 mb-5 page-header">
        <div class="container py-5">
            <div class="row justify-content-center">
                <div class="col-lg-10 text-center">
                    <h1 class="display-3 text-white animated slideInDown">Nos Sections</h1>

                    <nav aria-label="breadcrumb">
                        <ol class="breadcrumb justify-content-center">
                            <li class="breadcrumb-item"><a class="text-white" href="#">Home</a></li>
                            <li class="breadcrumb-item"><a class="text-white" href="#">Secteur</a></li>
                            <li class="breadcrumb-item text-white active" aria-current="page">
                                <asp:Label runat="server" ID="lblTitlesecteur" />
                            </li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <div class="container-xxl py-5">
        <div class="container">
        <div class="center_title_bar">
        </div>
        <asp:DataList
            runat="server" ID="dtlSecteurs"  BorderColor="black"
            RepeatColumns="3" OnItemDataBound="dtlProdutos_ItemDataBound" OnItemCommand="dtlProdutos_ItemCommand">
            <ItemTemplate>
                <div class="prod_box">
                    <div class="product_title">
                        Description:
                        <br />
                        <%# DataBinder.Eval(Container.DataItem, "DESCRIPTION") %>
                    </div>
                    <br />

                    <%--   Price: <%# DataBinder.Eval(Container.DataItem, "CurrencyValue", "{0:c}") %>--%>

                    <br />
                    <div class="product_img">
                        <asp:HyperLink ID="lnkImgProduto" runat="server" NavigateUrl="#">
                           <%-- <asp:Image ID="ProductImage" AlternateText="Product picture"
                                ImageUrl='<%# DataBinder.Eval(Container.DataItem, "IMAGESECTION") %>'
                                runat="server" />--%>
                            <asp:Image ID="imgProduto" runat="server" with="100px" Height="100px" ImageUrl="/Content/img/cat-2.jpg" BorderWidth="0" />
                        </asp:HyperLink>
                    </div>


                    <div class="bottom_prod_box">
                    </div>
                    <div class="mt-3">
                        <a class="btn btn-dark">Detail</a>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
        </div>

    <%--      <h3>DataList Example</h3>
 
      <asp:DataList id="ItemsList"
           BorderColor="black"
           CellPadding="5"
           CellSpacing="5"
           RepeatDirection="Vertical"
           RepeatLayout="Table"
           RepeatColumns="3"
           runat="server">

         <HeaderStyle BackColor="#aaaadd">
         </HeaderStyle>

         <AlternatingItemStyle BackColor="Gainsboro">
         </AlternatingItemStyle>

         <HeaderTemplate>

            List of items

         </HeaderTemplate>
               
         <ItemTemplate>

            Description: <br />
            <%# DataBinder.Eval(Container.DataItem, "StringValue") %>

            <br />

            Price: <%# DataBinder.Eval(Container.DataItem, "CurrencyValue", "{0:c}") %>

            <br />

            <asp:Image id="ProductImage" AlternateText="Product picture" 
                 ImageUrl='<%# DataBinder.Eval(Container.DataItem, "ImageValue") %>'
                 runat="server"/>

         </ItemTemplate>
 
      </asp:DataList>
    --%>
</asp:Content>
