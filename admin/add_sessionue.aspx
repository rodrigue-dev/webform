<%@ Page Language="C#"  MasterPageFile="~/Site.Admin.Master" AutoEventWireup="true" CodeBehind="add_sessionue.aspx.cs" Inherits="b_school.admin.add_sessionue" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Ajouter une sessionUE</h1>
    </div>
    <div class="row">

        <!-- Earnings (Monthly) Card Example -->
        <div class="col-md-12 mb-4">
            <div class="card border-top-primary shadow h-100 py-2">
                <div class="card-body">
                    <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtLieu">Lieu</asp:Label>
                        <div>
                            <asp:TextBox ID="IdtxtLieu" runat="server"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtPeriode">Periode</asp:Label>
                        <div>
                            <asp:TextBox ID="IdtxtPeriode" runat="server"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtDateDebut">Date de debut</asp:Label>
                        <div>
                            <asp:TextBox ID="IdtxtDateDebut" TextMode="Date" runat="server"></asp:TextBox>
                        </div>

                    </div>
                     <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtDateFin">Date de fin</asp:Label>
                        <div>
                            <asp:TextBox ID="IdtxtDateFin" TextMode="Date" runat="server"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group col-6">
                        <asp:Label runat="server" AssociatedControlID="IdtxtEtcs">Etcs</asp:Label>
                        <div>
                            <asp:TextBox ID="IdtxtEtcs" runat="server"></asp:TextBox>
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

