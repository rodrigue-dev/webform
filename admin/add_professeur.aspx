<%@ Page Language="C#" MasterPageFile="~/Site.Admin.Master" AutoEventWireup="true" CodeBehind="add_professeur.aspx.cs" Inherits="b_school.admin.add_professeur" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Ajouter professeur</h1>
    </div>
    <div class="row">

        <!-- Earnings (Monthly) Card Example -->
        <div class="col-md-12 mb-4">
            <div class="card border-top-primary shadow h-100 py-2">
                <div class="card-body">
                    <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtFirstName">Nom</asp:Label>
                        <div>
                            <asp:TextBox ID="IdtxtFirstName" runat="server"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtLastname">Prenom</asp:Label>
                        <div>
                            <asp:TextBox ID="IdtxtLastname" runat="server"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtPhone">Telephone</asp:Label>
                        <div>
                            <asp:TextBox ID="IdtxtPhone" runat="server"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtEmail">Email</asp:Label>
                        <div>
                            <asp:TextBox ID="IdtxtEmail" runat="server"></asp:TextBox>
                        </div>

                    </div>
                    <%-- <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="Ues">UE</asp:Label>
                        <div>
                            <asp:DropDownList ID="Ues" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                     <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="SessionUe">SessionUe</asp:Label>
                        <div>
                            <asp:DropDownList ID="SessionUe" runat="server"></asp:DropDownList>
                        </div>
                    </div>--%>
                     <div style="margin-bottom: 10px">
               <div>
                  <asp:Button runat="server" OnClick="Save" Text="Enregistrer" />
               </div>
            </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
