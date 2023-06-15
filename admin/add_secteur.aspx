<%@ Page Language="C#" MasterPageFile="~/Site.Admin.Master" AutoEventWireup="true" CodeBehind="add_secteur.aspx.cs" Inherits="b_school.admin.add_secteur" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Ajouter secteur</h1>
    </div>
    <div class="row">

        <!-- Earnings (Monthly) Card Example -->
        <div class="col-md-12 mb-4">
            <div class="card border-top-primary shadow h-100 py-2">
                <div class="card-body">
                    <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtIntitule">Intitule</asp:Label>
                        <div>
                            <asp:TextBox ID="IdtxtIntitule" runat="server"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtDateDebut">DateDebut</asp:Label>
                        <div>
                            <asp:TextBox TextMode="Date" ID="IdtxtDateDebut" runat="server"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtDateFin">DateFin</asp:Label>
                      <div>
                            <asp:TextBox TextMode="Date" ID="IdtxtDateFin" runat="server"></asp:TextBox>
                        </div>

                    </div>
                  
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
