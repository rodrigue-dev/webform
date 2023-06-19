<%@ Page Language="C#" MasterPageFile="~/Site.Admin.Master" AutoEventWireup="true" CodeBehind="professeur.aspx.cs" Inherits="b_school.professeur" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Professeurs</h1>
    </div>
    <div class="row container mb-2">
        <a class="btn btn-outline-dark" href="/admin/add_professeur">Ajouter un professeur</a>
    </div>
    <div class="row">

        <div class="col-md-12 mb-4">
            <div class="card border-top-primary shadow h-100 py-2">
                <div class="card-body">
                    <asp:GridView ID="grvProfeseur" DataKeyNames="IDPROFESSEUR" runat="server" AutoGenerateColumns="False" OnRowCommand="grvStudent_RowCommand" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="NOM" HeaderText="Nom" />
                            <asp:BoundField DataField="PRENOM" HeaderText="Prenom" />
                            <asp:BoundField DataField="TELEPHONE" HeaderText="Telephone" />
                            <asp:BoundField DataField="EMAIL" HeaderText="Email" />

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="btnEdit" CausesValidation="false" CommandName="EditStudent" Text="Edit" />
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="btnDelete" CausesValidation="false" CommandName="DeleteStudent" Text="Delete" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

